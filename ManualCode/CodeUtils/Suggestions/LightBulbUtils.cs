﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;
using System.Threading;
using CodeFlow.GenioManual;
using CodeFlow.ManualOperations;

namespace CodeFlow.CodeUtils.Suggestions
{
    [Export(typeof(ISuggestedActionsSourceProvider))]
    [Name("Code flow suggestions")]
    [ContentType("text")]
    internal class CodeFlowSuggestedActionsSourceProvider : ISuggestedActionsSourceProvider
    {
        [Import(typeof(ITextStructureNavigatorSelectorService))]
        internal ITextStructureNavigatorSelectorService NavigatorService { get; set; }
        public ISuggestedActionsSource CreateSuggestedActionsSource(ITextView textView, ITextBuffer textBuffer)
        {
            if (textBuffer == null && textView == null)
            {
                return null;
            }
            return new CodeFlowSuggestedActionsSource(this, textView, textBuffer);
        }
    }

    internal class CodeFlowSuggestedActionsSource : ISuggestedActionsSource
    {
        private readonly CodeFlowSuggestedActionsSourceProvider factory;
        private readonly ITextBuffer textBuffer;
        private readonly ITextView textView;
#pragma warning disable CS0067 // #warning directive
        public event EventHandler<EventArgs> SuggestedActionsChanged;
#pragma warning restore CS0067 // #warning directive

        public CodeFlowSuggestedActionsSource(CodeFlowSuggestedActionsSourceProvider testSuggestedActionsSourceProvider, ITextView textView, ITextBuffer textBuffer)
        {
            factory = testSuggestedActionsSourceProvider;
            this.textBuffer = textBuffer;
            this.textView = textView;
        }

        private bool TryGetManual(SnapshotSpan range, out IManual manua)
        {
            manua = null;
            CommandHandler.CommandHandler handler = new CommandHandler.CommandHandler();
            if (String.IsNullOrEmpty(handler.GetCurrentSelection()))
            {
                string code = range.Snapshot.GetText();
                int pos = range.Start;
                VSCodeManualMatcher vSCodeManualMatcher = new VSCodeManualMatcher(code, pos, PackageOperations.Instance.DTE.ActiveDocument.FullName);
                List<IManual> codeList = vSCodeManualMatcher.Match();

                if (codeList.Count == 1)
                    manua = codeList[0];
            }
            return manua != null;
        }

        public Task<bool> HasSuggestedActionsAsync(ISuggestedActionCategorySet requestedActionCategories, SnapshotSpan range, CancellationToken cancellationToken)
        {
            TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            return Task.Factory.StartNew(
                () =>
                {
                    return PackageOperations.Instance.ContinuousAnalysis && TryGetManual(range, out IManual _);
                },
                CancellationToken.None,
                TaskCreationOptions.None,
                uiScheduler);
        }

        public IEnumerable<SuggestedActionSet> GetSuggestedActions(ISuggestedActionCategorySet requestedActionCategories, SnapshotSpan range, CancellationToken cancellationToken)
        {
            if (PackageOperations.Instance.ContinuousAnalysis 
                && !cancellationToken.IsCancellationRequested 
                && TryGetManual(range, out IManual man))
            {
                List<ISuggestedAction> actions = new List<ISuggestedAction>();

                CompareDBSuggestion compare = new CompareDBSuggestion(man);
                actions.Add(compare);

                CommitSuggestion export = new CommitSuggestion(man);
                actions.Add(export);
                
                CompareCommitBSuggestion compareExport = new CompareCommitBSuggestion(man);
                actions.Add(compareExport);

                if (man.LocalMatch.CodeStart > 0 && man.LocalMatch.CodeLength > 0)
                {
                    UpdateSuggestion import = new UpdateSuggestion(man.LocalMatch.CodeStart, man.LocalMatch.CodeLength, textView, textBuffer, man.CodeId);
                    actions.Add(import);
                }

                if (!String.IsNullOrEmpty(PackageOperations.Instance.GetActiveProfile().GenioConfiguration.CheckoutPath)
                    && !String.IsNullOrEmpty(PackageOperations.Instance.GetActiveProfile().GenioConfiguration.SystemInitials))
                {
                    OpenSVNSuggestion openSVNSuggestion = new OpenSVNSuggestion(man, PackageOperations.Instance.GetActiveProfile());
                    actions.Add(openSVNSuggestion);

                    BlameSVNSuggestion blameSVNSuggestion = new BlameSVNSuggestion(man, PackageOperations.Instance.GetActiveProfile());
                    actions.Add(blameSVNSuggestion);
                }
                return new SuggestedActionSet[] { new SuggestedActionSet(actions.ToArray()) };
            }
            return Enumerable.Empty<SuggestedActionSet>();
        }

        public void Dispose()
        {
        }

        public bool TryGetTelemetryId(out Guid telemetryId)
        {
            // This is a sample provider and doesn't participate in LightBulb telemetry  
            telemetryId = Guid.Empty;
            return false;
        }
    }
}

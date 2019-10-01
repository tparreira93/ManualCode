﻿using Microsoft.VisualStudio.Imaging.Interop;
using Microsoft.VisualStudio.Language.Intellisense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFlowUI;
using CodeFlowLibrary.Genio;
using CodeFlowLibrary.GenioCode;
using CodeFlowLibrary.CodeControl.Analyzer;
using CodeFlowLibrary.Bridge;
using CodeFlowUI.Manager;
using CodeFlowLibrary.Package;

namespace CodeFlow.CodeUtils.Suggestions
{
    internal class CommitSuggestion : ISuggestedAction
    {
        private readonly CodeFlowPackage package;
        private readonly IManual _manual;
        private readonly string _display;
        private readonly Profile _profile;

        public CommitSuggestion(CodeFlowPackage package, IManual manual, Profile profile)
        {
            this.package = package;
            _manual = manual;
            _display = string.Format("Commit manual code");
            _profile = profile;
        }

        public string DisplayText
        {
            get
            {
                return _display;
            }
        }

        public string IconAutomationText
        {
            get
            {
                return null;
            }
        }

        ImageMoniker ISuggestedAction.IconMoniker
        {
            get
            {
                return default(ImageMoniker);
            }
        }

        public string InputGestureText
        {
            get
            {
                return null;
            }
        }

        public bool HasActionSets
        {
            get
            {
                return false;
            }
        }

        public Task<IEnumerable<SuggestedActionSet>> GetActionSetsAsync(CancellationToken cancellationToken)
        {
            return null;
        }

        public bool HasPreview
        {
            get
            {
                return false;
            }
        }

        public Task<object> GetPreviewAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult<object>(null);
        }

        public void Dispose()
        {
        }

        public void Invoke(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }
            if (_manual is ManuaCode)
            {
                try
                {
                    ChangeAnalyzer diffs = new ChangeAnalyzer();
                    diffs.CheckForDifferences(_manual, _profile);
                    CodeFlowUIManager.Open(new CommitForm(package, _profile, diffs));
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format(CodeFlowResources.Resources.UnableToExecuteOperation, ex.Message),
                        CodeFlowResources.Resources.Export, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        public bool TryGetTelemetryId(out Guid telemetryId)
        {
            telemetryId = Guid.Empty;
            return false;
        }
    }
}
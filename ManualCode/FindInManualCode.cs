﻿namespace CodeFlow
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;
    using System.Collections.Generic;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("93a46544-0f88-491b-b820-06fddb518d20")]
    public class FindInManualCode : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindInManualCode"/> class.
        /// </summary>
        public FindInManualCode() : base(null)
        {
            this.Caption = "Find manual code";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new FindManwinControl();
        }

        public void SetComboData(List<string> data)
        {
            if (Content is null)
                return;
            FindManwinControl control = Content as FindManwinControl;
            control.SetComboData(data);
        }
    }
}

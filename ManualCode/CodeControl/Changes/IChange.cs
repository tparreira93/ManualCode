﻿using CodeFlow.ManualOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFlow.GenioManual;
using CodeFlow.Genio;

namespace CodeFlow.CodeControl
{
    public interface IChange
    {
        IOperation GetOperation();
        IManual Mine { get; set; }
        IManual Theirs { get; set; }
        IManual Merged { get; set; }
        bool IsMerged { get; set; }
        bool HasDifference();
        IChange Merge();
        void Compare();
        string GetDescription();
        IRule FlagedRule { get; set; }
    }
}

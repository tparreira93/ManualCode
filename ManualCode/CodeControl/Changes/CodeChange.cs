﻿using CodeFlow.ManualOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFlow.GenioManual;

namespace CodeFlow.CodeControl
{
    public class CodeChange : ManualChange
    {
        public CodeChange(IManual mine, IManual theirs, Profile profile) : base(mine, theirs, profile)
        {

        }

        public override string GetDescription()
        {
            return "Modified";
        }

        public override IOperation GetOperation()
        {
            return new ChangeOperation(this, ChangeProfile);
        }
    }
}

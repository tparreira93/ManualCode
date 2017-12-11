﻿using System;
using System.Collections.Generic;
using CodeFlow.GenioManual;
using CodeFlow.ManualOperations;

namespace CodeFlow.CodeControl.Analyzer
{
    public class ChangeAnalyzer
    {
        public ChangeAnalyzer()
        {
            ModifiedConflict = new ConflictList();
            Modifications = new ChangeList();
        }

        public ConflictList ModifiedConflict { get; }

        public ChangeList Modifications { get; }

        public void CheckForDifferences(IManual toCheck, Profile profile)
        {
            IManual bd = Manual.GetManual(toCheck.GetType(), toCheck.CodeId, profile);

            //Compara com o que esta na BD
            if (bd == null)
            {
                // Codigo foi apagado por isso criamos um vazio
                CodeNotFound diff = new CodeNotFound(toCheck);
                Modifications.AsList.Add(diff);
            }
            else
            {
                IChange change = null;
                if (String.IsNullOrWhiteSpace(toCheck.Code))
                    change = new CodeEmpty(toCheck, bd);

                else if (!bd.Code.Equals(toCheck.Code))
                    change = new CodeChange(toCheck, bd);
                else
                    return;

                IChange diff = Modifications.AsList.Find(x => x.Mine.CodeId.Equals(toCheck.CodeId));

                if (diff != null)
                {
                    Modifications.AsList.Remove(diff);
                    ModifiedConflict.AsList.Add(new Conflict(diff.Mine.CodeId, new ChangeList(new List<IChange>() { change, diff })));
                }

                // Já inseriu um conflito
                // Verifica
                else if (ModifiedConflict.AsList.Find(x => x.Id.Equals(toCheck.CodeId)) is Conflict conflict)
                    conflict.DifferenceList.AsList.Add(change);

                else
                    Modifications.AsList.Add(change);
            }
        }

        public void CheckForDifferences(IEnumerable<IManual> toCheck, Profile profile)
        {
            foreach (IManual manual in toCheck)
                CheckForDifferences(manual, profile);
        }
    }
}

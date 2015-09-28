﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Accounting
{
    public class NewCommand : D_Command
    {
        private ListCases OldList = null;
        
        public NewCommand(MainViewModel vm, ListCases lc) : base(vm, lc)
        {
            OldList = lc;
        }

        public override void Execute()
        {
            ViewModel.Cases = new ListCases();
        }

        public override void ExecuteReverse()
        {
            ViewModel.Cases = OldList;
        }
    }
}

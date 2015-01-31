﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_AccountingCore
{
    public class AmountCase : AbstractCase
    {
        public decimal Amount
        {
            get
            {
                return mAmount;
            }
            set
            {
                mAmount = value;
                OnPropertyChanged("Amount");
                OnPropertyChanged("IsNegative");
            }
        }
        private decimal mAmount;

        public bool IsNegative
        {
            get
            {
                return mAmount < 0;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_p391
{
    class CardComparer_bySuit
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit < y.Suit)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            else
                return 0;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAZOPCommon
{
    public class DisplayReasons
    {
        public int RecordID
        {
            set;
            get;
        }
        string _ReasonText;
        public string ReasonText
        {
            set
            {
                this._ReasonText = value;
            }
            get
            {
                return this._ReasonText;
            }
        }

        public int Type
        {
            set;
            get;
        }

        public int IntroducerId
        {
            get;
            set;
        }
    }
}

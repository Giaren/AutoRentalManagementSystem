﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ARMSDALayer
{
    public class USStateDTO
    {
        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }
}
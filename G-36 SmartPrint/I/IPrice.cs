﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace G_36_SmartPrint.I
{
    internal interface IPrice
    {
        decimal CalculateTotal();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailDesktopUI.ViewModels
{
    public class ShellViewModel
    {
        private ICalculations _calculations;

        public ShellViewModel(ICalculations calculations)
        {
            _calculations = calculations;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC.Applications.Desktop.AdminPanel.ViewModels.Abstract;

public interface IViewModel
{
    public Func<string, string, bool> MessageBoxYesNo { get; set; }
}

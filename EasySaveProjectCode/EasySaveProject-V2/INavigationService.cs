﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySaveProject_V2
{
    public interface INavigationService
    {
        void NavigateTo(string pageKey);
        //void RegisterPage(string pageKey, Func<UserControl> createPageFunc);
    }
}

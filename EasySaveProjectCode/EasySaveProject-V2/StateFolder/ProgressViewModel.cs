﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasySaveProject_V2.ExecuteFolder;

namespace EasySaveProject_V2.StateFolder
{
    public class ProgressViewModel
    {
        WorkListService _workListService;

        public ProgressViewModel(WorkListService workListService)
        {
            _workListService = workListService;
        }

        public void states()
        {
            var workList = _workListService.LoadWorkListFromFile();

            foreach (var work in workList)
            {
                if (work.saveType == "Active")
                {
                    int progress = work.Progress;
                    Console.WriteLine(progress);
                }
                else
                {
                    Console.WriteLine("No work is running");
                }
            }

        }

    }
}

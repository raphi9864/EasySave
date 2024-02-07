﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EasySaveProject.Observer
{
    //define se of named constants for the status 
    public enum WorkStatus
    {
        Running,
        Done, 
        InProgress,
    }

    public class FormatStateStrategyJson
    {
        //the workList we already have
        private readonly WorkListService _workListService;
        
        //Variable to stock the file copied
        private long _Copied;

        private WorkStatus Status;

        //constructor
        public FormatStateStrategyJson(WorkListService workList)
        {
            _workListService = workList;
        }

        //method to calculate size of file within the repos
        public long GetSize(string repos)
        {
            long size = 0;

            //retriever all the file paths and include all subdirectories in the search
            string[] files = Directory.GetFiles(repos, "*.*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                //create a fileInfo object
                FileInfo fileInfo = new FileInfo(file);
                
                // accumulate the size of the current file
                size += fileInfo.Length;
            }

            return size;
        }

        //Method to calculate progress
        public int Progress (string sourceRepo)
        {
            //Get the size 
            long totalSize = GetSize(sourceRepo);

            //Calculate the pourcentage of the progress
            double progress = ((double)_Copied / totalSize) * 100;

            //ensure thta it does not exceed 100%
            int result = (int)Math.Min(Progress, 100);

            return result;
        }

        public void UpdateCopiedSize(long size)
        {
            _Copied += size;
        }

        public void write() { }
    }

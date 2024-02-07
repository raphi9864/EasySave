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
<<<<<<< HEAD
=======
    //define se of named constants for the status 
    public enum WorkStatus
    {
        Running,
        Done, 
        InProgress,
    }
>>>>>>> d52808d200ff41d3d2ea5d0112b2149d4cacc555

    public class FormatStateStrategyJson
    {
        //the workList we already have
        private readonly WorkListService _workListService;
<<<<<<< HEAD

        //Variable to stock the file copied
        private long _Copied;

=======
        
        //Variable to stock the file copied
        private long _Copied;

        private WorkStatus Status;
>>>>>>> d52808d200ff41d3d2ea5d0112b2149d4cacc555

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
<<<<<<< HEAD

=======
                
>>>>>>> d52808d200ff41d3d2ea5d0112b2149d4cacc555
                // accumulate the size of the current file
                size += fileInfo.Length;
            }

            return size;
        }

        //Method to calculate progress
<<<<<<< HEAD
        public int Progress(string sourceRepo)
=======
        public int Progress (string sourceRepo)
>>>>>>> d52808d200ff41d3d2ea5d0112b2149d4cacc555
        {
            //Get the size 
            long totalSize = GetSize(sourceRepo);

            //Calculate the pourcentage of the progress
            double progress = ((double)_Copied / totalSize) * 100;

            //ensure thta it does not exceed 100%
<<<<<<< HEAD
            int result = (int)Math.Min(progress, 100);
=======
            int result = (int)Math.Min(Progress, 100);
>>>>>>> d52808d200ff41d3d2ea5d0112b2149d4cacc555

            return result;
        }

        public void UpdateCopiedSize(long size)
        {
            _Copied += size;
        }

<<<<<<< HEAD
        public string status(int totalFiles, int nbFilesLeft)
        {
            int x = 0;
            if (totalFiles > nbFilesLeft)
            {
                x = 1;
            }
            else if (totalFiles > nbFilesLeft && nbFilesLeft == 0)
            {
                x = 2;
            }
            else if (totalFiles == 0)
            {
                x = 3;
            }

            switch (x)
            {
                case 1:
                    return "InProgress";
                case 2:
                    return "Active";
                case 3:
                    return "End";
                default:
                    return "Error";
            }
        }

        public async Task write()
        {
            var workList = _workListService.GetWorkList();

            foreach (var work in workList)
            {
                work.state = status(work.totalFilesToCopy, work.nbFilesLeftToDo);
                work.progression = Progress(work.SourceRepo);
            }

            string FileName = "state.json";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);

            //list to have the have the existant informations + the new ones 
            List<SaveWorkModel> allWorks = new List<SaveWorkModel>();

            //check if the fie already exists 
            if (File.Exists(filePath))
            {
                //if the file exists deserialize it and read it
                string existingJson = await File.ReadAllTextAsync(filePath);
                allWorks = JsonSerializer.Deserialize<List<SaveWorkModel>>(existingJson) ?? new List<SaveWorkModel>();
            }

            //Add the new information to the list
            allWorks.AddRange(workList);

            //JsonSerializer method to convert the informations into JSON
            // new JsonSerializerOptions { WriteIndented = true } to make the JSON format more readable 
            string jsonFile = JsonSerializer.Serialize(allWorks, new JsonSerializerOptions { WriteIndented = true });

            //Writing the json in the file 
            File.WriteAllText(FileName, jsonFile);
        }
    }
}
=======
        public void write() { }
    }
>>>>>>> d52808d200ff41d3d2ea5d0112b2149d4cacc555

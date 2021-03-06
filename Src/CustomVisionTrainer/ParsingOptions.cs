﻿using CommandLineParser.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomVisionTrainer
{
    // fields of this class will be bound
    public class ParsingOptions
    {
        //class has several fields and properties bound to various argument types

        [ValueArgument(typeof(string), 't', "trainingkey", Description = "Specify the training key", Optional = false)]
        public string TrainingKey { get; set; }

        [ValueArgument(typeof(Guid), 'p', "project", Description = "Specify the project to upload images for", Optional = false)]
        public Guid ProjectId { get; set; }

        [ValueArgument(typeof(string), 'f', "folder", Description = "Specify the directory that contains the images to be used for training", Optional = false)]
        public string Folder { get; set; }

        [ValueArgument(typeof(int), 'w', "width", Description = "Specify the width of the images", Optional = true)]
        public int? Width { get; set; }

        [ValueArgument(typeof(int), 'h', "height", Description = "Specify the height of the images", Optional = true)]
        public int? Height { get; set; }

        [SwitchArgument('d', "delete", defaultValue: false, Description = "Set to just delete images and tags and exits", Optional = true)]
        public bool Delete { get; set; }

    }
}

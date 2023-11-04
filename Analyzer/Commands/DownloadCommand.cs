﻿using CommandLine.Text;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using System.Text.Json;

namespace Analyzer.Commands
{
    [Verb("download", HelpText = "Download a file")]
    internal class DownloadCommand : ICommand
    {
        [Option('n', "name", Required = true, HelpText = "File name")]
        public string FileName { get; set; }

        [Value(0, MetaName = "path", Required = true, HelpText = "Download path location")]
        public string Path { get; set; }

        public void Execute()
        {
            var collection = ModelCache.Get(FileName);


            //download
            ModelCache.Remove(FileName);
        }
    }
}

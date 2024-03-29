﻿using CommandLine;
using Memory;
using Models.Interfaces;

namespace FileParser.Commands
{
    [Verb("smaller", HelpText = "Smaller than")]
    internal class SmallerThanCommand : ICommand
    {

        [Option('t', "than", HelpText = "Property name")]
        public string Property { get; set; }

        [Value(0, MetaName = "value", Required = true, HelpText = "Value to compare with a property")]
        public string Value { get; set; }

        public void Execute()
        {
            var objects = ModelCache.Current();
            if (objects == null)
            {
                Console.WriteLine("Not working on any file.");
                return;
            }

            try
            {
                var modified = objects.Cast<IValueComparable>().Where(x => x.Compare(Value, Property) > 0).AsEnumerable();
                ModelCache.Override(modified);
                Console.WriteLine("File updated.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Property and value have different type.");
            }
        }
    }
}

﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Analyzer.FileParserAbstractFactory.FileParser
{
    public class JsonFileParser : FileParser
    {
        public JsonFileParser(string content) : base (content) { }

        public override List<string?> ParseFile(string attribute)
        {
            JObject json = JObject.Parse(_content);

            List<string?> list = json.Properties()
                .Descendants()
                .OfType<JProperty>()
                .Where(x => x.Name == attribute)
                .Values<string?>()
                .ToList();

            if (list.Count == 0)
            {
                throw new KeyNotFoundException();
            }
            return list;
        }
    }
}

﻿using Newtonsoft.JsonV4.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.JsonV4.Schema;

namespace Newtonsoft.JsonV4.Tests.Documentation.Samples.Schema
{
    public class JsonSchemaParse
    {
        public void Example()
        {
            #region Usage
            string schemaJson = @"{
              'description': 'A person',
              'type': 'object',
              'properties': {
                'name': {'type':'string'},
                'hobbies': {
                  'type': 'array',
                  'items': {'type':'string'}
                }
              }
            }";

            JsonSchema schema = JsonSchema.Parse(schemaJson);

            Console.WriteLine(schema.Type);
            // Object

            foreach (var property in schema.Properties)
            {
                Console.WriteLine(property.Key + " - " + property.Value.Type);
            }
            // name - String
            // hobbies - Array
            #endregion
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.JsonV4.Linq;

namespace Newtonsoft.JsonV4.Tests.Documentation.Samples.Linq
{
    public class QueryJsonSelectToken
    {
        public void Example()
        {
            #region Usage
            JObject o = JObject.Parse(@"{
              'Stores': [
                'Lambton Quay',
                'Willis Street'
              ],
              'Manufacturers': [
                {
                  'Name': 'Acme Co',
                  'Products': [
                    {
                      'Name': 'Anvil',
                      'Price': 50
                    }
                  ]
                },
                {
                  'Name': 'Contoso',
                  'Products': [
                    {
                      'Name': 'Elbow Grease',
                      'Price': 99.95
                    },
                    {
                      'Name': 'Headlight Fluid',
                      'Price': 4
                    }
                  ]
                }
              ]
            }");

            string name = (string)o.SelectToken("Manufacturers[0].Name");

            Console.WriteLine(name);
            // Acme Co

            decimal productPrice = (decimal)o.SelectToken("Manufacturers[0].Products[0].Price");

            Console.WriteLine(productPrice);
            // 50

            string productName = (string)o.SelectToken("Manufacturers[1].Products[0].Name");

            Console.WriteLine(productName);
            // Elbow Grease
            #endregion
        }
    }
}
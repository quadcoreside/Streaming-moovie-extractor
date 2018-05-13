using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aSgare_Bot
{
    public class ConfigObject
    {
        public string Name { get; set; }
        public string Urls { get; set; }

        public string itemsCollectionIndices { get; set; }
        public string itemsNameIndices { get; set; }
        public string itemsUrlIndices { get; set; }
        public string itemsImageIndices { get; set; }

        public string itemUrlSourceIndices { get; set; }
        public string itemDescriptionIndices { get; set; }

        public bool nameAsUnique { get; set; }
        public bool recheckStepOne { get; set; }

        public string itemPartCollectionIndices { get; set; }
        public string itemPartNameIndices { get; set; }
        public string itemPartUrlSourceIndices { get; set; }
    }
}

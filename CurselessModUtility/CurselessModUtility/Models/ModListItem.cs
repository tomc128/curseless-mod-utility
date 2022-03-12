using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurselessModUtility.Models
{
    internal class ModListItem
    {
        public string Url { get; set; }
        public string? Name { get; set; }
        public string? Id { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ModListItem other && Url == other.Url;
        }
    }
}

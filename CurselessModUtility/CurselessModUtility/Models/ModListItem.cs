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

        public ModListItem(string url)
        {
            Url = url;
        }

        public override bool Equals(object? obj) => obj is ModListItem other && Url == other.Url;

        public override int GetHashCode() => base.GetHashCode();
    }
}

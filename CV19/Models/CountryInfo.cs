using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19.Models
{
    internal class CountryInfo : PlaceInfo 
    {
        public IEnumerable<ProvinceInfo> ProvinceCounts { get; set; }

    }
}

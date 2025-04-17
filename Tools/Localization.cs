using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WGU.C969.SoftwareII.Tools
{
    internal class Localization
    {
        public static string DetermineCountry()
        {
            //determines location
            var regionInfo = RegionInfo.CurrentRegion;
            var regionName = regionInfo.EnglishName;
            MessageBox.Show(regionName);
            return regionName;
        }

    }
}

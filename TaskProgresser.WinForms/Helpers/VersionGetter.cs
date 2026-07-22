
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskProgresser.WinForms.Services
{
    internal static class VersionGetter
    {
        private static readonly Version _version = Assembly.GetExecutingAssembly().GetName().Version;
        
        public static Version Version { get => _version; }
        public static string FullVersion { get => _version.ToString(); }
        public static string ShortVersion { get => $"{_version.Major}.{_version.Minor}{(_version.Build !=0 || _version.Revision != 0 ? $".{_version.Build}" : "")}{(_version.Revision != 0 ? $".{_version.Revision}" : "")}"; }

    }
}

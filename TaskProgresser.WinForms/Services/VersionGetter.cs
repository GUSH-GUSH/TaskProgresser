
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
        private static readonly Version Version = Assembly.GetExecutingAssembly().GetName().Version;

        public static string FullVersion { get => Version.ToString(); }
        public static string ShortVersion { get => $"{Version.Major}.{Version.Minor}{(Version.Build !=0 || Version.Revision != 0 ? $".{Version.Build}" : "")}{(Version.Revision != 0 ? $".{Version.Revision}" : "")}"; }

    }
}

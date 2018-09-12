using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Nodio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {
    }

    public static class Globals
    {
        public static string PROJECT_PATH = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        public static string SOUND_PATH = Path.Combine(PROJECT_PATH, "../data/sound");
    }
}

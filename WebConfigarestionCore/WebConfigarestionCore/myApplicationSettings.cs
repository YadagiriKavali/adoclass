using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConfigarestionCore
{
    public class MyWindowClass
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
       
        
    }
    public class myApplicationSettings
    {
        public string ConnectionString { get; set; }
        public MyWindowClass MainWindow { get; set; }
    }
}

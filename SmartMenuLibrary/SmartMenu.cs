using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            // Read the text file
            String line;
            // String list for each line (works like array but with arbitrary size;
            List<String> lines = new List<string>();

            System.IO.StreamReader textFile = new System.IO.StreamReader(path);
            while((line = textFile.ReadLine()) != null) {
                lines.Add(line);
            }
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}

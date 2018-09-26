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
            String line;
            // String list for each line (works like array but with arbitrary size;
            List<String> lines = new List<string>();

            System.IO.StreamReader textFile = new System.IO.StreamReader(path);
            while((line = textFile.ReadLine()) != null) {
                lines.Add(line);
            }

            Console.WriteLine("Lines read");
            foreach(String msg in lines) {
                Console.WriteLine(msg);
            }
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}

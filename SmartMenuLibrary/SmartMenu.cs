using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        private String MenuTitle;
        private String InputDescription;
        private string[,] menuPoints;

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

            // Set title and description
            MenuTitle = lines[0];
            InputDescription = lines[1];

            // Read in menu points.
            menuPoints = new string[lines.Count - 2, 2];
            for(int i=2; i < lines.Count; i++) {
                string[] split = lines[i].Split(';');
                // Point title
                menuPoints[i - 2, 0] = split[0];
                // Point ID
                menuPoints[i - 2, 1] = split[1];
            }
        }

        public void Activate()
        {
            // Implement ...
        }
    }
}

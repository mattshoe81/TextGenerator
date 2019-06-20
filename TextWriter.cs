using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGenerator
{
    public class TextWriter
    {
        public void Write(string path, string text)
        {
            try
            {
                File.WriteAllText(path + "/insert.sql", text);
            }
            catch (Exception ex)
            {
            }
        }
    }
}

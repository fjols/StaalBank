using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaalBank
{
    public class WriteToFile
    {
        public void FileWriting(List<string> txtBox)
        {
            List<string> text = new List<string>(); // Text to use.
            foreach(string txt in txtBox)
            {
                text.Add(txt);
            }
            
            System.IO.File.WriteAllLines("C:\\Users\\Charlie.CHARLIE-SAN\\Desktop\\Code\\StaalBank_\\StaalBank\\StaalBank\\test.txt", text);
             
            
        }
    }
}

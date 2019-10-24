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
            List<string> m_sText = new List<string>(); // New list to use.

            foreach(string txt in txtBox) // For every text element in the list.
            {
                m_sText.Add(txt); // Add each element of the given list to this list.
            }
            
            System.IO.File.WriteAllLines("C:\\Users\\Charlie.CHARLIE-SAN\\Desktop\\Code\\staalBankProject\\StaalBank\\test.txt", m_sText); // Write everything to the text file.
        }
    }
}

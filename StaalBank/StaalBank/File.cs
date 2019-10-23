using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StaalBank
{
    class File
    {
        File(TextBox fileName)
        {
            string sFileName = @"C:\Users\Charlie.CHARLIE-SAN\Desktop\Code\StaalBank_\StaalBank\StaalBank" + fileName;
            try
            {
                if(System.IO.File.Exists(sFileName))
                {
                    System.IO.File.Delete(sFileName);
                }
                using (FileStream fileStream = System.IO.File.Create(sFileName))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes("CHARACTER FILE"); // Title
                    fileStream.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("CHARLIE JENKINSON");
                    fileStream.Write(author, 0, author.Length);
                }

                using (StreamReader streamReader = System.IO.File.OpenText(sFileName))
                {
                    string s = "";
                    while((s = streamReader.ReadLine()) != null)
                    {
                        // Read text.
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StaalBank
{
    public class File
    {
        public Form1 mainForm;
        public File()
        {
        }

        public void CreateFile(string fileName)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Charlie.CHARLIE-SAN\Desktop\Code\staalBankProject\StaalBank\" + fileName + ".txt"); // Create a new file.
            file.Close();
        }

        public void LoadFile(Form1 form)
        {
            this.mainForm = form;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            Stream stream;

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                if((stream = openFileDialog.OpenFile()) != null)
                {
                    string path = openFileDialog.FileName;
                    string[] l_sFileLines = System.IO.File.ReadAllLines(path); // Get the file to read.
                    this.mainForm.GetPlayerName().AppendText(l_sFileLines[0].Substring(12));
                    this.mainForm.GetCharacterName().AppendText(l_sFileLines[1].Substring(16));
                    this.mainForm.GetRace().AppendText(l_sFileLines[2].Substring(6));
                    this.mainForm.GetClass().AppendText(l_sFileLines[3].Substring(7));
                    this.mainForm.GetHeight().AppendText(l_sFileLines[4].Substring(13));
                    this.mainForm.GetWeight().AppendText(l_sFileLines[5].Substring(13));
                    for(int i = 6; i < l_sFileLines.Count(); i++)
                    {
                        this.mainForm.GetInventory().AppendText(l_sFileLines[i] + Environment.NewLine);
                    }
                    
                    stream.Dispose();
                }
            }
        }

    }
}

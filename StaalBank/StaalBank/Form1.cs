using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StaalBank
{
    public partial class Form1 : Form
    {
        List<string> m_sCharacterInfo = new List<string>(); // Creates a new list.

        public Form1()
        {
            InitializeComponent();
        }

        public TextBox GetPlayerName()
        {
            return txtPlayerName;
        }

        public TextBox GetCharacterName()
        {
            return txtCharacterName;
        }

        public TextBox GetRace()
        {
            return txtRace;
        }

        public TextBox GetClass()
        {
            return txtClass;
        }

        public TextBox GetHeight()
        {
            return txtHeight;
        }

        public TextBox GetWeight()
        {
            return txtWeight;
        }

        public TextBox GetInventory()
        {
            return txtInventory;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            WriteToFile file = new WriteToFile(); // File object.

            m_sCharacterInfo.Add("Player Name: " + txtPlayerName.Text); // Adds a player name to the list.
            m_sCharacterInfo.Add("Character Name: " + txtCharacterName.Text); // Adds a character name to the list.
            m_sCharacterInfo.Add("Race: " + txtRace.Text); // Adds the race to the list.
            m_sCharacterInfo.Add("Class: " + txtClass.Text); // Adds the class to the list.
            m_sCharacterInfo.Add("Height(cm): " + txtHeight.Text); // Adds the height to the list.
            m_sCharacterInfo.Add("Weight(lbs): " + txtWeight.Text); // Adds the width to the list.
            string[] inventoryLines = txtInventory.Text.Split('\n'); // Split each line up in the inventory multiline text box. The lines will be stored in the array.

            for(int i = 0; i < inventoryLines.Count(); i++) // Iterate through each element in the array, which are the lines of the multiline text box.
            {
                  m_sCharacterInfo.Add("Inventory: " + inventoryLines[i]); // Add the line to the list.
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            Stream stream;
            string path;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    path = openFileDialog.FileName; // The file write the text to.
                    file.FileWriting(m_sCharacterInfo, path); // Write the list to the file.
                }
                stream.Close();
                stream.Dispose();
            }
        }
        /*
        public string GetFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            Stream stream;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    string path = openFileDialog.FileName; // The file write the text to.
                    return path;
                }
                stream.Close();
                stream.Dispose();
            }
            return "error";
        }
        */
        private void btnLoadFileForm_Click(object sender, EventArgs e)
        {
            Form2 fileForm = new Form2();
            fileForm.Show();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            File file = new File();
            file.LoadFile(this);
        }
    }
}

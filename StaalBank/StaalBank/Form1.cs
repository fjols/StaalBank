using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaalBank
{
    public partial class Form1 : Form
    {
        List<string> m_sCharacterInfo = new List<string>(); // Creates a new list.

        public Form1()
        {
            InitializeComponent();
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

            file.FileWriting(m_sCharacterInfo); // Write the list to the file.

        }
    }
}

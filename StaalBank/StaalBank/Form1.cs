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
        List<string> m_sCharacterInfo = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            //m_sCharacterInfo.Add(txtPlayerName.Text);
        }

        private void txtCharacterName_TextChanged(object sender, EventArgs e)
        {
            //m_sCharacterInfo.Add(txtCharacterName.Text);
        }

        private void txtRace_TextChanged(object sender, EventArgs e)
        {
            //m_sCharacterInfo.Add(txtRace.Text);
        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            //m_sCharacterInfo.Add(txtClass.Text);
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
           // m_sCharacterInfo.Add(txtHeight.Text);
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
           // m_sCharacterInfo.Add(txtWeight.Text);
        }

        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //m_sCharacterInfo.Add(lstInventory.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            WriteToFile file = new WriteToFile(); // File object.

            m_sCharacterInfo.Add("Player Name: " + txtPlayerName.Text);
            m_sCharacterInfo.Add("Character Name: " + txtCharacterName.Text);
            m_sCharacterInfo.Add("Race: " + txtRace.Text);
            m_sCharacterInfo.Add("Class: " + txtClass.Text);
            m_sCharacterInfo.Add("Height(cm): " + txtHeight.Text);
            m_sCharacterInfo.Add("Weight(lbs): " + txtWeight.Text);
            m_sCharacterInfo.Add("Inventory: " + lstInventory.Text);

            file.FileWriting(m_sCharacterInfo);
        }
    }
}

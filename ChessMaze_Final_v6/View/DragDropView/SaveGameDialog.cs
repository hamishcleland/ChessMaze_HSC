using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMaze_Final
{
    public partial class SaveGameDialog : Form
    {
        public string textString { get { return SaveGameString.Text; } }

    public SaveGameDialog()
        {
            InitializeComponent();
        }
        
        private void SaveGameDialog_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveGameString_Leave(object sender, EventArgs e)
        {
            string textString = SaveGameString.Text;
        }
    }
}

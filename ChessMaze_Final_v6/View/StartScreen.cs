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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            ChessMaze chessMaze = new ChessMaze(controller);
            chessMaze.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            ProgramView programView = new ProgramView(controller);
            this.Hide();
        }
    }
}

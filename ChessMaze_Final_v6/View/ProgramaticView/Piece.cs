using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace ChessMaze_Final
{
    public class Piece : PictureBox
    {
        // Sizes the requried pciturebox approraitely
        public Piece()
        {
            this.Size = new Size(65, 65);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
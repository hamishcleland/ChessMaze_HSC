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
    public class ProgramView : Form
    {
        Controller _controller = new Controller();
        // These lists contain all pictureboxes on the form and the picture boxes that will be displayed respectively
        public List<List<PictureBox>> allPictureBoxes = new List<List<PictureBox>>();
        public List<PictureBox> pictureBoxesForDisplay = new List<PictureBox>();

        // Creating the form objects
        Form form1 = new Form();
        Button undo = new Button();
        Label moveCountLabel = new Label();
        public TextBox moveCountNum = new TextBox();
        MenuStrip menuStrip = new MenuStrip();
        ToolStripMenuItem easyMode = new ToolStripMenuItem();
        ToolStripMenuItem mediumMode = new ToolStripMenuItem();
        ToolStripMenuItem hardMode = new ToolStripMenuItem();
        ToolStripMenuItem loadSave = new ToolStripMenuItem();
        ToolStripMenuItem loadTool = new ToolStripMenuItem();
        ToolStripMenuItem saveTool = new ToolStripMenuItem();
        ToolStripMenuItem restartGame = new ToolStripMenuItem();
        ToolStripMenuItem quit = new ToolStripMenuItem();
        ToolStripMenuItem startGame = new ToolStripMenuItem();
        public Piece pictureBox0_0 = new Piece();
        public Piece pictureBox0_1 = new Piece();
        public Piece pictureBox0_2 = new Piece();
        public Piece pictureBox0_3 = new Piece();
        public Piece pictureBox0_4 = new Piece();
        public Piece pictureBox0_5 = new Piece();
        public Piece pictureBox0_6 = new Piece();
        public Piece pictureBox0_7 = new Piece();
        public Piece pictureBox1_0 = new Piece();
        public Piece pictureBox1_1 = new Piece();
        public Piece pictureBox1_2 = new Piece();
        public Piece pictureBox1_3 = new Piece();
        public Piece pictureBox1_4 = new Piece();
        public Piece pictureBox1_5 = new Piece();
        public Piece pictureBox1_6 = new Piece();
        public Piece pictureBox1_7 = new Piece();
        public Piece pictureBox2_0 = new Piece();
        public Piece pictureBox2_1 = new Piece();
        public Piece pictureBox2_2 = new Piece();
        public Piece pictureBox2_3 = new Piece();
        public Piece pictureBox2_4 = new Piece();
        public Piece pictureBox2_5 = new Piece();
        public Piece pictureBox2_6 = new Piece();
        public Piece pictureBox2_7 = new Piece();
        public Piece pictureBox3_0 = new Piece();
        public Piece pictureBox3_1 = new Piece();
        public Piece pictureBox3_2 = new Piece();
        public Piece pictureBox3_3 = new Piece();
        public Piece pictureBox3_4 = new Piece();
        public Piece pictureBox3_5 = new Piece();
        public Piece pictureBox3_6 = new Piece();
        public Piece pictureBox3_7 = new Piece();
        public Piece pictureBox4_0 = new Piece();
        public Piece pictureBox4_1 = new Piece();
        public Piece pictureBox4_2 = new Piece();
        public Piece pictureBox4_3 = new Piece();
        public Piece pictureBox4_4 = new Piece();
        public Piece pictureBox4_5 = new Piece();
        public Piece pictureBox4_6 = new Piece();
        public Piece pictureBox4_7 = new Piece();
        public Piece pictureBox5_0 = new Piece();
        public Piece pictureBox5_1 = new Piece();
        public Piece pictureBox5_2 = new Piece();
        public Piece pictureBox5_3 = new Piece();
        public Piece pictureBox5_4 = new Piece();
        public Piece pictureBox5_5 = new Piece();
        public Piece pictureBox5_6 = new Piece();
        public Piece pictureBox5_7 = new Piece();
        public Piece pictureBox6_0 = new Piece();
        public Piece pictureBox6_1 = new Piece();
        public Piece pictureBox6_2 = new Piece();
        public Piece pictureBox6_3 = new Piece();
        public Piece pictureBox6_4 = new Piece();
        public Piece pictureBox6_5 = new Piece();
        public Piece pictureBox6_6 = new Piece();
        public Piece pictureBox6_7 = new Piece();
        public Piece pictureBox7_0 = new Piece();
        public Piece pictureBox7_1 = new Piece();
        public Piece pictureBox7_2 = new Piece();
        public Piece pictureBox7_3 = new Piece();
        public Piece pictureBox7_4 = new Piece();
        public Piece pictureBox7_5 = new Piece();
        public Piece pictureBox7_6 = new Piece();
        public Piece pictureBox7_7 = new Piece();

        public ProgramView(Controller _controller)
        {
            // Determining object properties
            form1.Size = new Size(652, 749);
            form1.Text = "Chess Maze";
            undo.Text = "Undo Move";
            undo.Size = new Size(100, 25);
            undo.Location = new Point(47, 85);
            undo.Click += new EventHandler(Undo_Click);
            form1.Controls.Add(undo);
            moveCountLabel.Text = "Move Count";
            moveCountLabel.Size = new Size(73, 15);
            moveCountLabel.Location = new Point(151, 67);
            form1.Controls.Add(moveCountLabel);
            moveCountNum.Text = "0";
            moveCountNum.Size = new Size(28, 23);
            moveCountNum.Location = new Point(174, 85);
            moveCountNum.TextChanged += new EventHandler(MoveCount_TextChanged);
            form1.Controls.Add(moveCountNum);
            menuStrip.Size = new Size(632, 24);
            form1.Controls.Add(menuStrip);
            startGame.Text = "Start Game";
            menuStrip.Items.Add(startGame);
            loadSave.Text = "Load/Save";
            menuStrip.Items.Add(loadSave);
            restartGame.Text = "Restart Game";
            menuStrip.Items.Add(restartGame);
            quit.Text = "Quit";
            menuStrip.Items.Add(quit);
            easyMode.Text = "Easy Mode";
            startGame.DropDownItems.Add(easyMode);
            mediumMode.Text = "Medium Mode";
            startGame.DropDownItems.Add(mediumMode);
            hardMode.Text = "Hard Mode";
            startGame.DropDownItems.Add(hardMode);
            loadTool.Text = "Load";
            saveTool.Text = "Save";
            loadSave.DropDownItems.Add(loadTool);
            loadSave.DropDownItems.Add(saveTool);
            pictureBox0_0.Location = new Point(47, 143);
            form1.Controls.Add(pictureBox0_0);
            pictureBox0_1.Location = new Point(47, 208);
            form1.Controls.Add(pictureBox0_1);
            pictureBox0_2.Location = new Point(47, 273);
            form1.Controls.Add(pictureBox0_2);
            pictureBox0_3.Location = new Point(47, 338);
            form1.Controls.Add(pictureBox0_3);
            pictureBox0_4.Location = new Point(47, 403);
            form1.Controls.Add(pictureBox0_4);
            pictureBox0_5.Location = new Point(47, 468);
            form1.Controls.Add(pictureBox0_5);
            pictureBox0_6.Location = new Point(47, 533);
            form1.Controls.Add(pictureBox0_6);
            pictureBox0_7.Location = new Point(47, 598);
            form1.Controls.Add(pictureBox0_7);
            pictureBox1_0.Location = new Point(112, 143);
            form1.Controls.Add(pictureBox1_0);
            pictureBox1_1.Location = new Point(112, 208);
            form1.Controls.Add(pictureBox1_1);
            pictureBox1_2.Location = new Point(112, 273);
            form1.Controls.Add(pictureBox1_2);
            pictureBox1_3.Location = new Point(112, 338);
            form1.Controls.Add(pictureBox1_3);
            pictureBox1_4.Location = new Point(112, 403);
            form1.Controls.Add(pictureBox1_4);
            pictureBox1_5.Location = new Point(112, 468);
            form1.Controls.Add(pictureBox1_5);
            pictureBox1_6.Location = new Point(112, 533);
            form1.Controls.Add(pictureBox1_6);
            pictureBox1_7.Location = new Point(112, 598);
            form1.Controls.Add(pictureBox1_7);
            pictureBox2_0.Location = new Point(177, 143);
            form1.Controls.Add(pictureBox2_0);
            pictureBox2_1.Location = new Point(177, 208);
            form1.Controls.Add(pictureBox2_1);
            pictureBox2_2.Location = new Point(177, 273);
            form1.Controls.Add(pictureBox2_2);
            pictureBox2_3.Location = new Point(177, 338);
            form1.Controls.Add(pictureBox2_3);
            pictureBox2_4.Location = new Point(177, 403);
            form1.Controls.Add(pictureBox2_4);
            pictureBox2_5.Location = new Point(177, 468);
            form1.Controls.Add(pictureBox2_5);
            pictureBox2_6.Location = new Point(177, 533);
            form1.Controls.Add(pictureBox2_6);
            pictureBox2_7.Location = new Point(177, 598);
            form1.Controls.Add(pictureBox2_7);
            pictureBox3_0.Location = new Point(242, 143);
            form1.Controls.Add(pictureBox3_0);
            pictureBox3_1.Location = new Point(242, 208);
            pictureBox3_1.Size = new Size(65, 65);
            form1.Controls.Add(pictureBox3_1);
            pictureBox3_2.Location = new Point(242, 273);
            form1.Controls.Add(pictureBox3_2);
            pictureBox3_3.Location = new Point(242, 338);
            form1.Controls.Add(pictureBox3_3);
            pictureBox3_4.Location = new Point(242, 403);
            form1.Controls.Add(pictureBox3_4);
            pictureBox3_5.Location = new Point(242, 468);
            form1.Controls.Add(pictureBox3_5);
            pictureBox3_6.Location = new Point(242, 533);
            form1.Controls.Add(pictureBox3_6);
            pictureBox3_7.Location = new Point(242, 598);
            form1.Controls.Add(pictureBox3_7);
            pictureBox4_0.Location = new Point(307, 143);
            form1.Controls.Add(pictureBox4_0);
            pictureBox4_1.Location = new Point(307, 208);
            form1.Controls.Add(pictureBox4_1);
            pictureBox4_2.Location = new Point(307, 273);
            form1.Controls.Add(pictureBox4_2);
            pictureBox4_3.Location = new Point(307, 338);
            form1.Controls.Add(pictureBox4_3);
            pictureBox4_4.Location = new Point(307, 403);
            form1.Controls.Add(pictureBox4_4);
            pictureBox4_5.Location = new Point(307, 468);
            form1.Controls.Add(pictureBox4_5);
            pictureBox4_6.Location = new Point(307, 533);
            form1.Controls.Add(pictureBox4_6);
            pictureBox4_7.Location = new Point(307, 598);
            form1.Controls.Add(pictureBox4_7);
            pictureBox5_0.Location = new Point(372, 143);
            form1.Controls.Add(pictureBox5_0);
            pictureBox5_1.Location = new Point(372, 208);
            form1.Controls.Add(pictureBox5_1);
            pictureBox5_2.Location = new Point(372, 273);
            form1.Controls.Add(pictureBox5_2);
            pictureBox5_3.Location = new Point(372, 338);
            form1.Controls.Add(pictureBox5_3);
            pictureBox5_4.Location = new Point(372, 403);
            form1.Controls.Add(pictureBox5_4);
            pictureBox5_5.Location = new Point(372, 468);
            form1.Controls.Add(pictureBox5_5);
            pictureBox5_6.Location = new Point(372, 533);
            form1.Controls.Add(pictureBox5_6);
            pictureBox5_7.Location = new Point(372, 598);
            form1.Controls.Add(pictureBox5_7);
            pictureBox6_0.Location = new Point(437, 143);
            form1.Controls.Add(pictureBox6_0);
            pictureBox6_1.Location = new Point(437, 208);
            form1.Controls.Add(pictureBox6_1);
            pictureBox6_2.Location = new Point(437, 273);
            form1.Controls.Add(pictureBox6_2);
            pictureBox6_3.Location = new Point(437, 338);
            form1.Controls.Add(pictureBox6_3);
            pictureBox6_4.Location = new Point(437, 403);
            form1.Controls.Add(pictureBox6_4);
            pictureBox6_5.Location = new Point(437, 468);
            form1.Controls.Add(pictureBox6_5);
            pictureBox6_6.Location = new Point(437, 533);
            form1.Controls.Add(pictureBox6_6);
            pictureBox6_7.Location = new Point(437, 598);
            form1.Controls.Add(pictureBox6_7);
            pictureBox7_0.Location = new Point(502, 143);
            form1.Controls.Add(pictureBox7_0);
            pictureBox7_1.Location = new Point(502, 208);
            form1.Controls.Add(pictureBox7_1);
            pictureBox7_2.Location = new Point(502, 273);
            form1.Controls.Add(pictureBox7_2);
            pictureBox7_3.Location = new Point(502, 338);
            form1.Controls.Add(pictureBox7_3);
            pictureBox7_4.Location = new Point(502, 403);
            form1.Controls.Add(pictureBox7_4);
            pictureBox7_5.Location = new Point(502, 468);
            form1.Controls.Add(pictureBox7_5);
            pictureBox7_6.Location = new Point(502, 533);
            form1.Controls.Add(pictureBox7_6);
            pictureBox7_7.Location = new Point(502, 598);
            form1.Controls.Add(pictureBox7_7);
            // Creating events to be handled
            easyMode.Click += new EventHandler(EasyMode_Click);
            mediumMode.Click += new EventHandler(MediumMode_Click);
            hardMode.Click += new EventHandler(HardMode_Click);
            loadTool.Click += new EventHandler(LoadTool_Click);
            saveTool.Click += new EventHandler(SaveTool_Click);
            restartGame.Click += new EventHandler(RestartGame_Click);
            quit.Click += new EventHandler(Quit_Click);
            pictureBox0_0.Click += new EventHandler(pictureBox0_0_Click);
            pictureBox0_1.Click += new EventHandler(pictureBox0_1_Click);
            pictureBox0_2.Click += new EventHandler(pictureBox0_2_Click);
            pictureBox0_3.Click += new EventHandler(pictureBox0_3_Click);
            pictureBox0_4.Click += new EventHandler(pictureBox0_4_Click);
            pictureBox0_5.Click += new EventHandler(pictureBox0_5_Click);
            pictureBox0_6.Click += new EventHandler(pictureBox0_6_Click);
            pictureBox0_7.Click += new EventHandler(pictureBox0_7_Click);
            pictureBox1_0.Click += new EventHandler(pictureBox1_0_Click);
            pictureBox1_1.Click += new EventHandler(pictureBox1_1_Click);
            pictureBox1_2.Click += new EventHandler(pictureBox1_2_Click);
            pictureBox1_3.Click += new EventHandler(pictureBox1_3_Click);
            pictureBox1_4.Click += new EventHandler(pictureBox1_4_Click);
            pictureBox1_5.Click += new EventHandler(pictureBox1_5_Click);
            pictureBox1_6.Click += new EventHandler(pictureBox1_6_Click);
            pictureBox1_7.Click += new EventHandler(pictureBox1_7_Click);
            pictureBox2_0.Click += new EventHandler(pictureBox2_0_Click);
            pictureBox2_1.Click += new EventHandler(pictureBox2_1_Click);
            pictureBox2_2.Click += new EventHandler(pictureBox2_2_Click);
            pictureBox2_3.Click += new EventHandler(pictureBox2_3_Click);
            pictureBox2_4.Click += new EventHandler(pictureBox2_4_Click);
            pictureBox2_5.Click += new EventHandler(pictureBox2_5_Click);
            pictureBox2_6.Click += new EventHandler(pictureBox2_6_Click);
            pictureBox2_7.Click += new EventHandler(pictureBox2_7_Click);
            pictureBox3_0.Click += new EventHandler(pictureBox3_0_Click);
            pictureBox3_1.Click += new EventHandler(pictureBox3_1_Click);
            pictureBox3_2.Click += new EventHandler(pictureBox3_2_Click);
            pictureBox3_3.Click += new EventHandler(pictureBox3_3_Click);
            pictureBox3_4.Click += new EventHandler(pictureBox3_4_Click);
            pictureBox3_5.Click += new EventHandler(pictureBox3_5_Click);
            pictureBox3_6.Click += new EventHandler(pictureBox3_6_Click);
            pictureBox3_7.Click += new EventHandler(pictureBox3_7_Click);
            pictureBox4_0.Click += new EventHandler(pictureBox4_0_Click);
            pictureBox4_1.Click += new EventHandler(pictureBox4_1_Click);
            pictureBox4_2.Click += new EventHandler(pictureBox4_2_Click);
            pictureBox4_3.Click += new EventHandler(pictureBox4_3_Click);
            pictureBox4_4.Click += new EventHandler(pictureBox4_4_Click);
            pictureBox4_5.Click += new EventHandler(pictureBox4_5_Click);
            pictureBox4_6.Click += new EventHandler(pictureBox4_6_Click);
            pictureBox4_7.Click += new EventHandler(pictureBox4_7_Click);
            pictureBox5_0.Click += new EventHandler(pictureBox5_0_Click);
            pictureBox5_1.Click += new EventHandler(pictureBox5_1_Click);
            pictureBox5_2.Click += new EventHandler(pictureBox5_2_Click);
            pictureBox5_3.Click += new EventHandler(pictureBox5_3_Click);
            pictureBox5_4.Click += new EventHandler(pictureBox5_4_Click);
            pictureBox5_5.Click += new EventHandler(pictureBox5_5_Click);
            pictureBox5_6.Click += new EventHandler(pictureBox5_6_Click);
            pictureBox5_7.Click += new EventHandler(pictureBox5_7_Click);
            pictureBox6_0.Click += new EventHandler(pictureBox6_0_Click);
            pictureBox6_1.Click += new EventHandler(pictureBox6_1_Click);
            pictureBox6_2.Click += new EventHandler(pictureBox6_2_Click);
            pictureBox6_3.Click += new EventHandler(pictureBox6_3_Click);
            pictureBox6_4.Click += new EventHandler(pictureBox6_4_Click);
            pictureBox6_5.Click += new EventHandler(pictureBox6_5_Click);
            pictureBox6_6.Click += new EventHandler(pictureBox6_6_Click);
            pictureBox6_7.Click += new EventHandler(pictureBox6_7_Click);
            pictureBox7_0.Click += new EventHandler(pictureBox7_0_Click);
            pictureBox7_1.Click += new EventHandler(pictureBox7_1_Click);
            pictureBox7_2.Click += new EventHandler(pictureBox7_2_Click);
            pictureBox7_3.Click += new EventHandler(pictureBox7_3_Click);
            pictureBox7_4.Click += new EventHandler(pictureBox7_4_Click);
            pictureBox7_5.Click += new EventHandler(pictureBox7_5_Click);
            pictureBox7_6.Click += new EventHandler(pictureBox7_6_Click);
            pictureBox7_7.Click += new EventHandler(pictureBox7_7_Click);
            form1.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            //Adding items to lists
            List<PictureBox> row1Boxes = new List<PictureBox>();
            List<PictureBox> row2Boxes = new List<PictureBox>();
            List<PictureBox> row3Boxes = new List<PictureBox>();
            List<PictureBox> row4Boxes = new List<PictureBox>();
            List<PictureBox> row5Boxes = new List<PictureBox>();
            List<PictureBox> row6Boxes = new List<PictureBox>();
            List<PictureBox> row7Boxes = new List<PictureBox>();
            List<PictureBox> row8Boxes = new List<PictureBox>();
            allPictureBoxes.Add(row1Boxes);
            allPictureBoxes.Add(row2Boxes);
            allPictureBoxes.Add(row3Boxes);
            allPictureBoxes.Add(row4Boxes);
            allPictureBoxes.Add(row5Boxes);
            allPictureBoxes.Add(row6Boxes);
            allPictureBoxes.Add(row7Boxes);
            allPictureBoxes.Add(row8Boxes);
            int xMapSize = _controller.GetColumnCount();
            int yMapSize = _controller.GetRowCount();
            row1Boxes.Add(pictureBox0_0);
            row1Boxes.Add(pictureBox1_0);
            row1Boxes.Add(pictureBox2_0);
            row1Boxes.Add(pictureBox3_0);
            row1Boxes.Add(pictureBox4_0);
            row1Boxes.Add(pictureBox5_0);
            row1Boxes.Add(pictureBox6_0);
            row1Boxes.Add(pictureBox7_0);
            row2Boxes.Add(pictureBox0_1);
            row2Boxes.Add(pictureBox1_1);
            row2Boxes.Add(pictureBox2_1);
            row2Boxes.Add(pictureBox3_1);
            row2Boxes.Add(pictureBox4_1);
            row2Boxes.Add(pictureBox5_1);
            row2Boxes.Add(pictureBox6_1);
            row2Boxes.Add(pictureBox7_1);
            row3Boxes.Add(pictureBox0_2);
            row3Boxes.Add(pictureBox1_2);
            row3Boxes.Add(pictureBox2_2);
            row3Boxes.Add(pictureBox3_2);
            row3Boxes.Add(pictureBox4_2);
            row3Boxes.Add(pictureBox5_2);
            row3Boxes.Add(pictureBox6_2);
            row3Boxes.Add(pictureBox7_2);
            row4Boxes.Add(pictureBox0_3);
            row4Boxes.Add(pictureBox1_3);
            row4Boxes.Add(pictureBox2_3);
            row4Boxes.Add(pictureBox3_3);
            row4Boxes.Add(pictureBox4_3);
            row4Boxes.Add(pictureBox5_3);
            row4Boxes.Add(pictureBox6_3);
            row4Boxes.Add(pictureBox7_3);
            row5Boxes.Add(pictureBox0_4);
            row5Boxes.Add(pictureBox1_4);
            row5Boxes.Add(pictureBox2_4);
            row5Boxes.Add(pictureBox3_4);
            row5Boxes.Add(pictureBox4_4);
            row5Boxes.Add(pictureBox5_4);
            row5Boxes.Add(pictureBox6_4);
            row5Boxes.Add(pictureBox7_4);
            row6Boxes.Add(pictureBox0_5);
            row6Boxes.Add(pictureBox1_5);
            row6Boxes.Add(pictureBox2_5);
            row6Boxes.Add(pictureBox3_5);
            row6Boxes.Add(pictureBox4_5);
            row6Boxes.Add(pictureBox5_5);
            row6Boxes.Add(pictureBox6_5);
            row6Boxes.Add(pictureBox7_5);
            row7Boxes.Add(pictureBox0_6);
            row7Boxes.Add(pictureBox1_6);
            row7Boxes.Add(pictureBox2_6);
            row7Boxes.Add(pictureBox3_6);
            row7Boxes.Add(pictureBox4_6);
            row7Boxes.Add(pictureBox5_6);
            row7Boxes.Add(pictureBox6_6);
            row7Boxes.Add(pictureBox7_6);
            row8Boxes.Add(pictureBox0_7);
            row8Boxes.Add(pictureBox1_7);
            row8Boxes.Add(pictureBox2_7);
            row8Boxes.Add(pictureBox3_7);
            row8Boxes.Add(pictureBox4_7);
            row8Boxes.Add(pictureBox5_7);
            row8Boxes.Add(pictureBox6_7);
            row8Boxes.Add(pictureBox7_7);
            form1.ShowDialog();
        }
        // Events
        private void pictureBox0_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 0, pictureBox0_0, allPictureBoxes, moveCountNum);
        }

        private void pictureBox1_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 0, pictureBox1_0, allPictureBoxes, moveCountNum);
        }

        private void pictureBox2_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 0, pictureBox2_0, allPictureBoxes, moveCountNum);
        }

        private void pictureBox3_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 0, pictureBox3_0, allPictureBoxes, moveCountNum);
        }

        private void pictureBox4_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 0, pictureBox4_0, allPictureBoxes, moveCountNum);
        }

        private void pictureBox5_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 0, pictureBox5_0, allPictureBoxes, moveCountNum);
        }

        private void pictureBox6_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 0, pictureBox6_0, allPictureBoxes, moveCountNum);
        }

        private void pictureBox7_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 0, pictureBox7_0, allPictureBoxes, moveCountNum);
        }

        private void pictureBox0_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 1, pictureBox0_1, allPictureBoxes, moveCountNum);

        }

        private void pictureBox1_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 1, pictureBox1_1, allPictureBoxes, moveCountNum);
        }

        private void pictureBox2_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 1, pictureBox2_1, allPictureBoxes, moveCountNum);
        }

        private void pictureBox3_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 1, pictureBox3_1, allPictureBoxes, moveCountNum);
        }

        private void pictureBox4_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 1, pictureBox4_1, allPictureBoxes, moveCountNum);
        }

        private void pictureBox5_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 1, pictureBox5_1, allPictureBoxes, moveCountNum);
        }

        private void pictureBox6_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 1, pictureBox6_1, allPictureBoxes, moveCountNum);
        }

        private void pictureBox7_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 1, pictureBox7_1, allPictureBoxes, moveCountNum);
        }

        private void pictureBox0_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 2, pictureBox0_2, allPictureBoxes, moveCountNum);

        }

        private void pictureBox1_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 2, pictureBox1_2, allPictureBoxes, moveCountNum);
        }

        private void pictureBox2_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 2, pictureBox2_2, allPictureBoxes, moveCountNum);
        }

        private void pictureBox3_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 2, pictureBox3_2, allPictureBoxes, moveCountNum);
        }

        private void pictureBox4_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 2, pictureBox4_2, allPictureBoxes, moveCountNum);
        }

        private void pictureBox5_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 2, pictureBox5_2, allPictureBoxes, moveCountNum);
        }

        private void pictureBox6_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 2, pictureBox6_2, allPictureBoxes, moveCountNum);
        }

        private void pictureBox7_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 2, pictureBox7_2, allPictureBoxes, moveCountNum);
        }

        private void pictureBox0_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 3, pictureBox0_3, allPictureBoxes, moveCountNum);

        }

        private void pictureBox1_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 3, pictureBox1_3, allPictureBoxes, moveCountNum);
        }

        private void pictureBox2_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 3, pictureBox2_3, allPictureBoxes, moveCountNum);
        }

        private void pictureBox3_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 3, pictureBox3_3, allPictureBoxes, moveCountNum);
        }

        private void pictureBox4_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 3, pictureBox4_3, allPictureBoxes, moveCountNum);
        }

        private void pictureBox5_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 3, pictureBox5_3, allPictureBoxes, moveCountNum);
        }

        private void pictureBox6_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 3, pictureBox6_3, allPictureBoxes, moveCountNum);
        }

        private void pictureBox7_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 3, pictureBox7_3, allPictureBoxes, moveCountNum);
        }

        private void pictureBox0_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 4, pictureBox0_4, allPictureBoxes, moveCountNum);

        }

        private void pictureBox1_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 4, pictureBox1_4, allPictureBoxes, moveCountNum);
        }

        private void pictureBox2_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 4, pictureBox2_4, allPictureBoxes, moveCountNum);
        }

        private void pictureBox3_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 4, pictureBox3_4, allPictureBoxes, moveCountNum);
        }

        private void pictureBox4_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 4, pictureBox4_4, allPictureBoxes, moveCountNum);
        }

        private void pictureBox5_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 4, pictureBox5_4, allPictureBoxes, moveCountNum);
        }

        private void pictureBox6_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 4, pictureBox6_4, allPictureBoxes, moveCountNum);
        }

        private void pictureBox7_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 4, pictureBox7_4, allPictureBoxes, moveCountNum);
        }

        private void pictureBox0_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 5, pictureBox0_5, allPictureBoxes, moveCountNum);

        }

        private void pictureBox1_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 5, pictureBox1_5, allPictureBoxes, moveCountNum);
        }

        private void pictureBox2_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 5, pictureBox2_5, allPictureBoxes, moveCountNum);
        }

        private void pictureBox3_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 5, pictureBox3_5, allPictureBoxes, moveCountNum);
        }

        private void pictureBox4_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 5, pictureBox4_5, allPictureBoxes, moveCountNum);
        }

        private void pictureBox5_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 5, pictureBox5_5, allPictureBoxes, moveCountNum);
        }

        private void pictureBox6_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 5, pictureBox6_5, allPictureBoxes, moveCountNum);
        }

        private void pictureBox7_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 5, pictureBox7_5, allPictureBoxes, moveCountNum);
        }

        private void pictureBox0_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 6, pictureBox0_6, allPictureBoxes, moveCountNum);

        }

        private void pictureBox1_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 6, pictureBox1_6, allPictureBoxes, moveCountNum);
        }

        private void pictureBox2_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 6, pictureBox2_6, allPictureBoxes, moveCountNum);
        }

        private void pictureBox3_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 6, pictureBox3_6, allPictureBoxes, moveCountNum);
        }

        private void pictureBox4_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 6, pictureBox4_6, allPictureBoxes, moveCountNum);
        }

        private void pictureBox5_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 6, pictureBox5_6, allPictureBoxes, moveCountNum);
        }

        private void pictureBox6_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 6, pictureBox6_6, allPictureBoxes, moveCountNum);
        }

        private void pictureBox7_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 6, pictureBox7_6, allPictureBoxes, moveCountNum);
        }

        private void pictureBox0_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 7, pictureBox0_7, allPictureBoxes, moveCountNum);

        }

        private void pictureBox1_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 7, pictureBox1_7, allPictureBoxes, moveCountNum);
        }

        private void pictureBox2_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 7, pictureBox2_7, allPictureBoxes, moveCountNum);
        }

        private void pictureBox3_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 7, pictureBox3_7, allPictureBoxes, moveCountNum);
        }

        private void pictureBox4_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 7, pictureBox4_7, allPictureBoxes, moveCountNum);
        }

        private void pictureBox5_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 7, pictureBox5_7, allPictureBoxes, moveCountNum);
        }

        private void pictureBox6_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 7, pictureBox6_7, allPictureBoxes, moveCountNum);
        }

        private void pictureBox7_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 7, pictureBox7_7, allPictureBoxes, moveCountNum);
        }

        private void EasyMode_Click(object sender, EventArgs e)
        {
            _controller.Go("rEN\nEER\nBBQ");
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, form1, true);
        }

        private void MediumMode_Click(object sender, EventArgs e)
        {

            _controller.Go("qBBBRK\nEEREBN\nNEREEE\nBNEBNB\nNBEBER\nBBEBNQ");
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, form1, true);
        }

        private void HardMode_Click(object sender, EventArgs e)
        {
            _controller.Go("qEKBEERK\nEEERENEB\nENEEENEN\nEBEERBEB\nEBNEERER\nEEBBREEE\nBEEEEERE\nREEREEEK");
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, form1, true);
        }

        private void RestartGame_Click(object sender, EventArgs e)
        {
            _controller.RestartGame();
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, form1, true);
            int theMoveCount = _controller.GetMoveCount();
            moveCountNum.Text = theMoveCount.ToString();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            form1.Close();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            PictureBox playerPosBox = _controller.DetPlayerPos(allPictureBoxes);
            Tuple<int, int> playerPos = _controller.GetPlayerPosition();
            _controller.UndoMove();
            _controller.UpdateView(playerPos.Item1, playerPos.Item2, playerPosBox, allPictureBoxes, moveCountNum, true);
        }
        private void MoveCount_TextChanged(object sender, EventArgs e)
        {
            _controller.GetMoveCount();
        }

        private void LoadTool_Click(object sender, EventArgs e)
        {
            GameFile testFile = new GameFile();
            // "rEN\nEER\nBBQ"
            List<List<Part>> exampleBoard = new List<List<Part>>();
            List<Part> partList1 = new List<Part>();
            List<Part> partList2 = new List<Part>();
            List<Part> partList3 = new List<Part>();
            partList1.Add(Part.Rook);
            partList1.Add(Part.Empty);
            partList1.Add(Part.Bishop);
            exampleBoard.Add(partList1);
            partList2.Clear();
            partList2.Add(Part.Empty);
            partList2.Add(Part.Empty);
            partList2.Add(Part.Bishop);
            exampleBoard.Add(partList2);
            partList3.Clear();
            partList3.Add(Part.PlayerOnBishop);
            partList3.Add(Part.Bishop);
            partList3.Add(Part.Queen);
            exampleBoard.Add(partList3);
            testFile.exportMoveCount = 1;
            testFile.ExportBoard = exampleBoard;
            var playerMoveListXAxis = new List<int> { 0, 0 };
            testFile.ExportPlayerMoveListXAxis = playerMoveListXAxis;
            var playerMoveListYAxis = new List<int> { 0, 2 };
            testFile.exportMoveCount = 1;
            testFile.ExportPlayerMoveListYAxis = playerMoveListYAxis;
            testFile.name = "Test File";
            _controller.LoadLevel(testFile);
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, this, true);
            moveCountNum.Text = _controller.GetMoveCount().ToString();
            MessageBox.Show("You have loaded a saved game " + testFile.name);
        }

        private void SaveTool_Click(object sender, EventArgs e)
        {
            // Creating secondary form
            string input;
            Size size = new Size(200, 100);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Name";

            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, size.Height - 70);
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(5, size.Height - 40);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, size.Height - 40);
            inputBox.Controls.Add(cancelButton);

            Label label = new Label();
            label.Text = "Enter Your Level Name";
            label.Location = new Point(5, 5);
            inputBox.Controls.Add(label);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog(this);

            input = textBox.Text;

            if (result == DialogResult.OK)
            {
                MessageBox.Show("You have saved your level named " + input);
                _controller.SaveLevel(input);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Chess Maze", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
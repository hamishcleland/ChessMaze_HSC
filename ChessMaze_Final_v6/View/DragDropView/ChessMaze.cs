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
    public partial class ChessMaze : Form
    {
        Controller _controller = new Controller();

        // These lists contain all pictureboxes on the form and the picture boxes that will be displayed respectively
        public List<List<PictureBox>> allPictureBoxes = new List<List<PictureBox>>();

        public List<PictureBox> pictureBoxesForDisplay = new List<PictureBox>();


        public ChessMaze(Controller controller)
        {
            InitializeComponent();
            // Add all empty rows of pictureboxes
            List<PictureBox> row1Boxes = new List<PictureBox>();
            List<PictureBox> row2Boxes = new List<PictureBox>();
            List<PictureBox> row3Boxes = new List<PictureBox>();
            List<PictureBox> row4Boxes = new List<PictureBox>();
            List<PictureBox> row5Boxes = new List<PictureBox>();
            List<PictureBox> row6Boxes = new List<PictureBox>();
            List<PictureBox> row7Boxes = new List<PictureBox>();
            List<PictureBox> row8Boxes = new List<PictureBox>();
            // Add to 2D list
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
            // Add the pictureboxes
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
        }
        private void MoveCount_TextChanged(object sender, EventArgs e)
        {
            _controller.GetMoveCount();
        }

        // Clicks trigger the update view function, contain the coordinates for the picture box
        private void pictureBox0_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 0, pictureBox0_0, allPictureBoxes, MoveCount);
        }

        private void pictureBox1_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 0, pictureBox1_0, allPictureBoxes, MoveCount);
        }

        private void pictureBox2_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 0, pictureBox2_0, allPictureBoxes, MoveCount);
        }

        private void pictureBox3_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 0, pictureBox3_0, allPictureBoxes, MoveCount);
        }

        private void pictureBox4_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 0, pictureBox4_0, allPictureBoxes, MoveCount);
        }

        private void pictureBox5_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 0, pictureBox5_0, allPictureBoxes, MoveCount);
        }

        private void pictureBox6_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 0, pictureBox6_0, allPictureBoxes, MoveCount);
        }

        private void pictureBox7_0_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 0, pictureBox7_0, allPictureBoxes, MoveCount);
        }

        private void pictureBox0_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 1, pictureBox0_1, allPictureBoxes, MoveCount);

        }

        private void pictureBox1_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 1, pictureBox1_1, allPictureBoxes, MoveCount);
        }

        private void pictureBox2_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 1, pictureBox2_1, allPictureBoxes, MoveCount);
        }

        private void pictureBox3_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 1, pictureBox3_1, allPictureBoxes, MoveCount);
        }

        private void pictureBox4_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 1, pictureBox4_1, allPictureBoxes, MoveCount);
        }

        private void pictureBox5_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 1, pictureBox5_1, allPictureBoxes, MoveCount);
        }

        private void pictureBox6_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 1, pictureBox6_1, allPictureBoxes, MoveCount);
        }

        private void pictureBox7_1_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 1, pictureBox7_1, allPictureBoxes, MoveCount);
        }

        private void pictureBox0_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 2, pictureBox0_2, allPictureBoxes, MoveCount);
        }

        private void pictureBox1_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 2, pictureBox1_2, allPictureBoxes, MoveCount);
        }

        private void pictureBox2_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 2, pictureBox2_2, allPictureBoxes, MoveCount);
        }

        private void pictureBox3_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 2, pictureBox3_2, allPictureBoxes, MoveCount);
        }

        private void pictureBox4_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 2, pictureBox4_2, allPictureBoxes, MoveCount);
        }

        private void pictureBox5_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 2, pictureBox5_2, allPictureBoxes, MoveCount);
        }

        private void pictureBox6_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 2, pictureBox6_2, allPictureBoxes, MoveCount);
        }

        private void pictureBox7_2_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 2, pictureBox7_2, allPictureBoxes, MoveCount);
        }

        private void pictureBox0_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 3, pictureBox0_3, allPictureBoxes, MoveCount);

        }

        private void pictureBox1_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 3, pictureBox1_3, allPictureBoxes, MoveCount);
        }

        private void pictureBox2_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 3, pictureBox2_3, allPictureBoxes, MoveCount);
        }

        private void pictureBox3_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 3, pictureBox3_3, allPictureBoxes, MoveCount);
        }

        private void pictureBox4_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 3, pictureBox4_3, allPictureBoxes, MoveCount);
        }

        private void pictureBox5_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 3, pictureBox5_3, allPictureBoxes, MoveCount);
        }

        private void pictureBox6_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 3, pictureBox6_3, allPictureBoxes, MoveCount);
        }

        private void pictureBox7_3_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 3, pictureBox7_3, allPictureBoxes, MoveCount);
        }

        private void pictureBox0_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 4, pictureBox0_4, allPictureBoxes, MoveCount);

        }

        private void pictureBox1_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 4, pictureBox1_4, allPictureBoxes, MoveCount);
        }

        private void pictureBox2_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 4, pictureBox2_4, allPictureBoxes, MoveCount);
        }

        private void pictureBox3_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 4, pictureBox3_4, allPictureBoxes, MoveCount);
        }

        private void pictureBox4_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 4, pictureBox4_4, allPictureBoxes, MoveCount);
        }

        private void pictureBox5_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 4, pictureBox5_4, allPictureBoxes, MoveCount);
        }

        private void pictureBox6_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 4, pictureBox6_4, allPictureBoxes, MoveCount);
        }

        private void pictureBox7_4_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 4, pictureBox7_4, allPictureBoxes, MoveCount);
        }

        private void pictureBox0_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 5, pictureBox0_5, allPictureBoxes, MoveCount);

        }

        private void pictureBox1_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 5, pictureBox1_5, allPictureBoxes, MoveCount);
        }

        private void pictureBox2_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 5, pictureBox2_5, allPictureBoxes, MoveCount);
        }

        private void pictureBox3_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 5, pictureBox3_5, allPictureBoxes, MoveCount);
        }

        private void pictureBox4_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 5, pictureBox4_5, allPictureBoxes, MoveCount);
        }

        private void pictureBox5_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 5, pictureBox5_5, allPictureBoxes, MoveCount);
        }

        private void pictureBox6_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 5, pictureBox6_5, allPictureBoxes, MoveCount);
        }

        private void pictureBox7_5_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 5, pictureBox7_5, allPictureBoxes, MoveCount);
        }

        private void pictureBox0_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 6, pictureBox0_6, allPictureBoxes, MoveCount);

        }

        private void pictureBox1_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 6, pictureBox1_6, allPictureBoxes, MoveCount);
        }

        private void pictureBox2_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 6, pictureBox2_6, allPictureBoxes, MoveCount);
        }

        private void pictureBox3_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 6, pictureBox3_6, allPictureBoxes, MoveCount);
        }

        private void pictureBox4_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 6, pictureBox4_6, allPictureBoxes, MoveCount);
        }

        private void pictureBox5_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 6, pictureBox5_6, allPictureBoxes, MoveCount);
        }

        private void pictureBox6_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 6, pictureBox6_6, allPictureBoxes, MoveCount);
        }

        private void pictureBox7_6_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 6, pictureBox7_6, allPictureBoxes, MoveCount);
        }

        private void pictureBox0_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(0, 7, pictureBox0_7, allPictureBoxes, MoveCount);
        }

        private void pictureBox1_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(1, 7, pictureBox1_7, allPictureBoxes, MoveCount);
        }

        private void pictureBox2_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(2, 7, pictureBox2_7, allPictureBoxes, MoveCount);
        }

        private void pictureBox3_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(3, 7, pictureBox3_7, allPictureBoxes, MoveCount);
        }

        private void pictureBox4_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(4, 7, pictureBox4_7, allPictureBoxes, MoveCount);
        }

        private void pictureBox5_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(5, 7, pictureBox5_7, allPictureBoxes, MoveCount);
        }

        private void pictureBox6_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(6, 7, pictureBox6_7, allPictureBoxes, MoveCount);
        }

        private void pictureBox7_7_Click(object sender, EventArgs e)
        {
            _controller.UpdateView(7, 7, pictureBox7_7, allPictureBoxes, MoveCount);
        }

        
        // Note that this function would require a filer to pass an object to it
        // Example code creating such an object is placed here for testing 
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // START OF TEST CODE
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
            var playerMoveListXAxis = new List<int> {0,0};
            testFile.ExportPlayerMoveListXAxis = playerMoveListXAxis;
            var playerMoveListYAxis = new List<int> {0,2};
            testFile.exportMoveCount = 1;
            testFile.ExportPlayerMoveListYAxis = playerMoveListYAxis;
            testFile.name = "Test File";
            // END OF TEST CODE
            _controller.LoadLevel(testFile);
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, this, true);
            MoveCount.Text = _controller.GetMoveCount().ToString();
            MessageBox.Show("You have loaded a saved game " + testFile.name);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveGameDialog newForm = new SaveGameDialog();
            newForm.ShowDialog(this);
            if (newForm.textString != "")
            {
                MessageBox.Show("You have saved your level " + newForm.textString);
                _controller.SaveLevel(newForm.textString);
            }
        }
        private void ChessMaze_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void easyModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.Go("rEN\nEER\nBBQ");
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes,this, true);
        }

        private void mediumModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            _controller.Go("qBBBRK\nEEREBN\nNEREEE\nBNEBNB\nNBEBER\nBBEBNQ");
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, this, true);
        }

        private void hardModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.Go("qEKBEERK\nEEERENEB\nENEEENEN\nEBEERBEB\nEBNEERER\nEEBBREEE\nBEEEEERE\nREEREEEK");
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, this, true);
        }

        private void restartGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _controller.RestartGame();
            _controller.LoadPictureBoxes(pictureBoxesForDisplay, allPictureBoxes, this, true);
            int theMoveCount = _controller.GetMoveCount();
            MoveCount.Text = theMoveCount.ToString();
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Undo_Click(object sender, EventArgs e)
        {
            PictureBox playerPosBox = _controller.DetPlayerPos(allPictureBoxes);
            Tuple<int, int> playerPos = _controller.GetPlayerPosition();
            _controller.UndoMove();
            _controller.UpdateView(playerPos.Item1, playerPos.Item2, playerPosBox, allPictureBoxes, MoveCount, true);
        }
    }
}

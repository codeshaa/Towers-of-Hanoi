using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    public partial class MainForm : Form
    {
        private Board Board;
        private DiskMove DiskMove;
        private bool isStepping = false;
        private Disk[,] disks = new Disk[3, 4];
        private int MoveCount = 0;
        private int targetPole = 0;
        private int animateLine = 0;
        private string lastMove = "";
        public MainForm()
        {
            InitializeComponent();
            disks[0, 3] = new Disk(lblDisk1, 1, 4);
            disks[0, 2] = new Disk(lblDisk2, 1, 3);
            disks[0, 1] = new Disk(lblDisk3, 1, 2);
            disks[0, 0] = new Disk(lblDisk4, 1, 1);
            Board = new Board(disks[0, 0], disks[0, 1], disks[0, 2], disks[0, 3]);
        }

        private bool DropOnPole(int oldPole, int oldLevel, int newPole)
        //Move a disk from its current position to the next available position
        //on the new pole and check that the move is valid
        {
            int newLevel;
            string theMove = "", textMove = "";
            oldPole--;
            oldLevel--;
            newPole--;

            if (disks[newPole, 3] != null)
            {
                MessageBox.Show("Invalid Move - pole is full");
                return false;
            }
            else if (disks[oldPole, oldLevel] == null)
            {
                MessageBox.Show("Invalid Move - no disk at start point");
                return false;
            }

            if (oldLevel < 3)
            {
                if (disks[oldPole, oldLevel + 1] != null)
                {
                    MessageBox.Show("Invalid Move - can only move top disk");
                    return false;
                }
            }

            newLevel = 3;
            for (int i = 0; i < 4; i++)
            {
                if (disks[newPole, i] == null)
                {
                    newLevel = i;
                    break;
                }
            }

            if (newLevel > 0)
            {
                if (disks[oldPole, oldLevel].thisDisk.Width > disks[newPole, newLevel - 1].thisDisk.Width)
                {
                    MessageBox.Show("Invalid Move - cannot drop bigger disk on smaller");
                    return false;
                }
            }

            if (newLevel == oldLevel + 1 && newPole == oldPole)
            {
                MessageBox.Show("Invalid Move - cannot move on the same peg");
                return false;
            }

            disks[newPole, newLevel] = disks[oldPole, oldLevel];
            disks[oldPole, oldLevel] = null;
            disks[newPole, newLevel].Move(newPole + 1, newLevel + 1);
            if (!isStepping)
            {
                {
                    theMove = disks[newPole, newLevel].thisDisk.Name + ','
                        + (newPole + 1).ToString() + ',' + (newLevel + 1).ToString() + "\r\n";
                    txtMoves.AppendText(theMove);
                    textMove = returnDiskID(disks[newPole, newLevel].thisDisk.Name).ToString() + ','
                        + (newPole).ToString() + "\r\n";
                    DiskMove = new DiskMove(textMove);
                    txtMove.AppendText(DiskMove.AsText() + "\r\n");
                    MoveCount++;
                    lblMoves.Text = MoveCount.ToString();
                }


                if (theMove == "lblDisk1,3,4\r\n" && lastMove == "lblDisk2,3,3\r\n")
                {
                    if (lblMoves.Text == "15")
                    {
                        MessageBox.Show("Congrats! You have successfully completed the game with minimum number of moves");
                    }
                    else
                    {
                        MessageBox.Show("Game Over: You have successfully completed the game but not with the minimum number of moves");
                    }
                }

                lastMove = theMove;
            }
            return true;
        }

        private int returnDiskID(string diskName)
        //given a string with the .Name property of a disk
        //return an index value to that disk assuming that only valid names are passed
        {
            int ret = 0;

            if (diskName == "lblDisk1")
            {
                ret = 0;
            }
            else if (diskName == "lblDisk2" || diskName == "\nlblDisk2")
            {
                ret = 1;
            }
            else if (diskName == "lblDisk3")
            {
                ret = 2;
            }
            else if (diskName == "lblDisk4")
            {
                ret = 3;
            }

            return ret;
        }


        private void lblDisk1_MouseDown(object sender, MouseEventArgs e)
        {
            Label alabel = (sender as Label);
            int pole, level;
            getPoleAndLevel(out pole, out level, alabel);

            DragDropEffects result = alabel.DoDragDrop(alabel, DragDropEffects.All);
            if (result != DragDropEffects.None)
            {
                DropOnPole(pole, level, targetPole);
            }
        }

        void getPoleAndLevel(out int pole, out int level, Label thislabel)
        //given an object reference to the label representing a disk
        //find its position in the 3x4 disks array of possible positions
        {
            pole = -1;
            level = -1;
            for (int ipole = 0; ipole < 3; ipole++)
            {
                for (int jlevel = 0; jlevel < 4; jlevel++)
                {
                    if (disks[ipole, jlevel] != null)
                    {
                        if (disks[ipole, jlevel].thisDisk == thislabel)
                        {
                            pole = ipole + 1;
                            level = jlevel + 1;
                            break;
                        }
                    }
                }
                if (pole > -1) break;
            }
        }

        private void lblPeg1_DragDrop(object sender, DragEventArgs e)
        {
            Label alabel = (sender as Label);
            if (alabel == lblPeg1) targetPole = 1;
            else if (alabel == lblPeg2) targetPole = 2;
            else if (alabel == lblPeg3) targetPole = 3;
        }

        private void lblPeg1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


        private bool MakeNextMove()
        //repeat one of the moves stored in the textbox
        {
            int oldPole, oldLevel, newPole;
            bool MoveOK = false;
            try
            {
                string aMove = txtMoves.Lines[animateLine];
                if (aMove == "")
                {
                    return false;
                }
                string[] parts = aMove.Split(',');
                Label aDisk = getDisk(parts[0]);
                newPole = Convert.ToInt32(parts[1]);
                getPoleAndLevel(out oldPole, out oldLevel, aDisk);
                isStepping = true; //will prevent adding more moves to the textbox from the replay
                MoveOK = DropOnPole(oldPole, oldLevel, newPole);
                isStepping = false;

                if (!MoveOK)
                {
                    return false;
                }

                animateLine++;
                if (animateLine >= txtMoves.Lines.Length)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
            

        private Label getDisk(string DiskName)
        //given a string with the .Name property of a disk
        //return a reference to that disk assuming that only valid names are passed
        {

            if (DiskName == "lblDisk1")
            {
                return lblDisk1;
            }
            else if (DiskName == "lblDisk2")
            {
                return lblDisk2;
            }
            else if (DiskName == "lblDisk3")
            {
                return lblDisk3;
            }
            else if (DiskName == "lblDisk4")
            {
                return lblDisk4;
            }
            else return lblDisk4;
        }

        private void animateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //repeat one of the moves stored in the textbox each time the timer fires
        {
            if (!MakeNextMove())
            {
                animateTimer.Enabled = false;
            }
        }

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            Board.reset();
            MoveCount = 0;
            targetPole = 0;
            animateLine = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    disks[i, j] = null;
                }
            }

            disks[0, 3] = new Disk(lblDisk1, 1, 4);
            disks[0, 2] = new Disk(lblDisk2, 1, 3);
            disks[0, 1] = new Disk(lblDisk3, 1, 2);
            disks[0, 0] = new Disk(lblDisk4, 1, 1);
            animateTimer.Enabled = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            txtMoves.Text = "";
            lblMoves.Text = "0";
            txtMove.Text = "";
            MoveCount = 0;
            targetPole = 0;
            Board.reset();
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<4; j++)
                {
                    disks[i, j] = null;
                }
            }

            disks[0, 3] = new Disk(lblDisk1, 1, 4);
            disks[0, 2] = new Disk(lblDisk2, 1, 3);
            disks[0, 1] = new Disk(lblDisk3, 1, 2);
            disks[0, 0] = new Disk(lblDisk4, 1, 1);
        }

        private void animateTimer_Elapsed(object sender, EventArgs e)
        {
            if (!MakeNextMove())
            {
                animateTimer.Enabled = false;
            }
        }


        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"SavedGame.txt");
                System.IO.File.WriteAllText(filePath, string.Empty);
                System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true);
                file.WriteLine(txtMoves.Text);

                file.Close();
                MessageBox.Show("Game saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Something went wrong, Code:" + ex);
                return;
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            Board.reset();
            targetPole = 0;
            MoveCount = 0;
            txtMove.Text = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    disks[i, j] = null;
                }
            }
            disks[0, 3] = new Disk(lblDisk1, 1, 4);
            disks[0, 2] = new Disk(lblDisk2, 1, 3);
            disks[0, 1] = new Disk(lblDisk3, 1, 2);
            disks[0, 0] = new Disk(lblDisk4, 1, 1);
            string filePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"SavedGame.txt");
            string getFile = System.IO.File.ReadAllText(filePath);
            getFile = getFile.TrimEnd('\r', '\n');
            txtMoves.Text = getFile + "\r\n";
            string[] fileParts = txtMoves.Text.Split('\r');

            try
            {
                foreach (string Parts in fileParts)
                {
                    string[] partSplit = Parts.Split(',');
                    int pegID = Convert.ToInt32(partSplit[1]) - 1;
                    string textMove = returnDiskID(partSplit[0]).ToString() + ',' + pegID;
                    DiskMove = new DiskMove(textMove);
                    txtMove.AppendText(DiskMove.AsText() + "\r\n");
                }
            }
            catch (Exception ex)
            {
            }

            MoveCount = fileParts.Length;
            lblMoves.Text = (--MoveCount).ToString();
            animateLine = 0;

            targetPole = 0;
            animateTimer.Enabled = true;
        }

    }
}

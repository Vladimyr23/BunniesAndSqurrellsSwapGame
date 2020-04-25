using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BunniesAndSqurrellsSwapGame
{
    public partial class Form1 : Form
    {
        Point point1 = new Point(70, 90);
        Point point2 = new Point(155, 60);
        Point point3 = new Point(235, 90);
        Point point4 = new Point(15, 145);
        Point point5 = new Point(300, 145);
        Point point6 = new Point(70, 205);
        Point point7 = new Point(155, 230);
        Point point8 = new Point(235, 205);

        int[] animalLocations = new int[4] { 1, 3, 6, 8 };
        int animalSelected = -1;
        int frame1Location = -1;
        int frame2Location = -1;

        int moves = 0;

        public Form1()
        {
            InitializeComponent();       
            
            pBoxFrame1.Visible = false;
            pBoxFrame2.Visible = false;

        }

        private void restartGame(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void getBunny1(object sender, EventArgs e)
        {            
            if (pBoxBunny1.BorderStyle == BorderStyle.None) {
                animalSelected = -1;
                pBoxBunny2.BorderStyle = BorderStyle.None;
                pBoxSquirrel1.BorderStyle = BorderStyle.None;
                pBoxSquirrel2.BorderStyle = BorderStyle.None;
                pBoxFrame1.Visible = false;
                pBoxFrame2.Visible = false;
                pBoxFrame1.Enabled = false;
                pBoxFrame2.Enabled = false;

                animalSelected = 0;
                pBoxBunny1.BorderStyle = BorderStyle.Fixed3D;
                placeFrames(animalLocations[0]);
            }
            else
            {
                animalSelected = -1;
                pBoxBunny1.BorderStyle = BorderStyle.None;
                pBoxFrame1.Visible = false;
                pBoxFrame2.Visible = false;
                pBoxFrame1.Enabled = false;
                pBoxFrame2.Enabled = false;
            }
            
        }

        private void getBunny2(object sender, EventArgs e)
        {
            if (pBoxBunny2.BorderStyle == BorderStyle.None)
            {
                animalSelected = -1;
                pBoxBunny1.BorderStyle = BorderStyle.None;
                pBoxSquirrel1.BorderStyle = BorderStyle.None;
                pBoxSquirrel2.BorderStyle = BorderStyle.None;
                pBoxFrame1.Visible = false;
                pBoxFrame2.Visible = false;
                pBoxFrame1.Enabled = false;
                pBoxFrame2.Enabled = false;

                animalSelected = 1;
                pBoxBunny2.BorderStyle = BorderStyle.Fixed3D;
                placeFrames(animalLocations[1]);
            }
            else
            {
                animalSelected = -1;
                pBoxBunny2.BorderStyle = BorderStyle.None;
                pBoxFrame1.Visible = false;
                pBoxFrame2.Visible = false;
                pBoxFrame1.Enabled = false;
                pBoxFrame2.Enabled = false;
            }

        }

        private void getSquirrel1(object sender, EventArgs e)
        {
            if (pBoxSquirrel1.BorderStyle == BorderStyle.None)
            {
                animalSelected = -1;
                pBoxBunny1.BorderStyle = BorderStyle.None;
                pBoxBunny2.BorderStyle = BorderStyle.None;
                pBoxSquirrel2.BorderStyle = BorderStyle.None;
                pBoxFrame1.Visible = false;
                pBoxFrame2.Visible = false;
                pBoxFrame1.Enabled = false;
                pBoxFrame2.Enabled = false;

                animalSelected = 2;
                pBoxSquirrel1.BorderStyle = BorderStyle.Fixed3D;
                placeFrames(animalLocations[2]);
            }
            else
            {
                animalSelected = -1;
                pBoxSquirrel1.BorderStyle = BorderStyle.None;
                pBoxFrame1.Visible = false;
                pBoxFrame2.Visible = false;
                pBoxFrame1.Enabled = false;
                pBoxFrame2.Enabled = false;
            }
        }

        private void getSquirrel2(object sender, EventArgs e)
        {
            if (pBoxSquirrel2.BorderStyle == BorderStyle.None)
            {
                animalSelected = -1;
                pBoxBunny1.BorderStyle = BorderStyle.None;
                pBoxBunny2.BorderStyle = BorderStyle.None;
                pBoxSquirrel1.BorderStyle = BorderStyle.None;
                pBoxFrame1.Visible = false;
                pBoxFrame2.Visible = false;
                pBoxFrame1.Enabled = false;
                pBoxFrame2.Enabled = false;

                animalSelected = 3;
                pBoxSquirrel2.BorderStyle = BorderStyle.Fixed3D;
                placeFrames(animalLocations[3]);
            }
            else
            {
                animalSelected = -1;
                pBoxSquirrel2.BorderStyle = BorderStyle.None;
                pBoxFrame1.Visible = false;
                pBoxFrame2.Visible = false;
                pBoxFrame1.Enabled = false;
                pBoxFrame2.Enabled = false;
            }
        }

        private void placeFrames(int location)
        {
            switch (location)
            {
                case 1:
                    //Location 1 animal is selected

                    if (animalLocations.Contains(5) == false)
                    {
                        pBoxFrame1.Enabled = true;
                        pBoxFrame1.Visible = true;
                        pBoxFrame1.Location = point5;
                        frame1Location = 5;
                    }
                    else
                    {
                        pBoxFrame1.Location = new Point(0, 0);
                        frame1Location = -1;
                    }

                    if (animalLocations.Contains(7) == false)
                    {
                        pBoxFrame2.Enabled = true;
                        pBoxFrame2.Visible = true;                        
                        pBoxFrame2.Location = point7;
                        frame2Location = 7;
                        
                    }
                    else
                    {
                        pBoxFrame2.Location = new Point(0, 0);
                        frame2Location = -1;
                    }
                    break;

                case 2:
                    //Location 2 animal is selected

                    if (animalLocations.Contains(6) == false)
                    {
                        pBoxFrame1.Enabled = true;
                        pBoxFrame1.Visible = true;
                        pBoxFrame1.Location = point6;
                        frame1Location = 6;
                    }
                    else
                    {
                        pBoxFrame1.Location = new Point(0, 0);
                        frame1Location = -1;
                    }

                    if (animalLocations.Contains(8) == false)
                    {
                        pBoxFrame2.Enabled = true;
                        pBoxFrame2.Visible = true;
                        pBoxFrame2.Location = point8;
                        frame2Location = 8;                        
                    }
                    else
                    {
                        pBoxFrame2.Location = new Point(0, 0);
                        frame2Location = -1;
                    }
                    break;
                case 3:

                    //Location 3 animal is selected

                    if (animalLocations.Contains(4) == false)
                    {
                        pBoxFrame1.Enabled = true;
                        pBoxFrame1.Visible = true;
                        pBoxFrame1.Location = point4;
                        frame1Location = 4;                        
                    }
                    else
                    {
                        pBoxFrame1.Location = new Point(0, 0);
                        frame1Location = -1;
                    }

                    if (animalLocations.Contains(7) == false)
                    {
                        pBoxFrame2.Enabled = true;
                        pBoxFrame2.Visible = true;
                        pBoxFrame2.Location = point7;
                        frame2Location = 7;                        
                    }
                    else
                    {
                        pBoxFrame2.Location = new Point(0, 0);
                        frame2Location = -1;
                    }
                    break;
                case 4:
                    //Location 4 animal is selected

                    if (animalLocations.Contains(3) == false)
                    {
                        pBoxFrame1.Enabled = true;
                        pBoxFrame1.Visible = true;
                        pBoxFrame1.Location = point3;
                        frame1Location = 3;
                    }
                    else
                    {
                        pBoxFrame1.Location = new Point(0, 0);
                        frame1Location = -1;
                    }

                    if (animalLocations.Contains(8) == false)
                    {
                        pBoxFrame2.Enabled = true;
                        pBoxFrame2.Visible = true;
                        pBoxFrame2.Location = point8;
                        frame2Location = 8;                        
                    }
                    else
                    {
                        pBoxFrame2.Location = new Point(0, 0);
                        frame2Location = -1;
                    }
                    break;
                case 5:
                    //Location 5 animal is selected
                    if (animalLocations.Contains(1) == false)
                    {
                        pBoxFrame1.Enabled = true;
                        pBoxFrame1.Visible = true;
                        pBoxFrame1.Location = point1;
                        frame1Location = 1;
                    }
                    else
                    {
                        pBoxFrame1.Location = new Point(0, 0);
                        frame1Location = -1;
                    }

                    if (animalLocations.Contains(6) == false)
                    {
                        pBoxFrame2.Enabled = true;
                        pBoxFrame2.Visible = true;
                        pBoxFrame2.Location = point6;
                        frame2Location = 6;
                    }
                    else
                    {
                        pBoxFrame2.Location = new Point(0, 0);
                        frame1Location = -1;
                    }
                    break;
                case 6:
                    //Location 6 animal is selected
                    if (animalLocations.Contains(2) == false)
                    {
                        pBoxFrame1.Enabled = true;
                        pBoxFrame1.Visible = true;
                        pBoxFrame1.Location = point2;
                        frame1Location = 2;
                    }
                    else
                    {
                        pBoxFrame1.Location = new Point(0, 0);
                        frame1Location = -1;
                    }

                    if (animalLocations.Contains(5) == false)
                    {
                        pBoxFrame2.Enabled = true;
                        pBoxFrame2.Visible = true;
                        pBoxFrame2.Location = point5;
                        frame2Location = 5;
                    }
                    else
                    {
                        pBoxFrame2.Location = new Point(0, 0);
                        frame2Location = -1;
                    }
                    break;
                case 7:
                    //Location 7 animal is selected
                    if (animalLocations.Contains(1) == false)
                    {
                        pBoxFrame1.Enabled = true;
                        pBoxFrame1.Visible = true;
                        pBoxFrame1.Location = point1;
                        frame1Location = 1;
                    }
                    else
                    {
                        pBoxFrame1.Location = new Point(0, 0);
                        frame1Location = -1;
                    }

                    if (animalLocations.Contains(3) == false)
                    {
                        pBoxFrame2.Enabled = true;
                        pBoxFrame2.Visible = true;
                        pBoxFrame2.Location = point3;
                        frame2Location = 3;
                    }
                    else
                    {
                        pBoxFrame2.Location = new Point(0, 0);
                        frame2Location = -1;
                    }
                    break;
                case 8:
                    //Location 8 animal is selected
                    if (animalLocations.Contains(4) == false)
                    {
                        pBoxFrame1.Enabled = true;
                        pBoxFrame1.Visible = true;
                        pBoxFrame1.Location = point4;
                        frame1Location = 4;
                    }
                    else
                    {
                        pBoxFrame1.Location = new Point(0, 0);
                        frame1Location = -1;
                    }

                    if (animalLocations.Contains(2) == false)
                    {
                        pBoxFrame2.Enabled = true;
                        pBoxFrame2.Visible = true;
                        pBoxFrame2.Location = point2;
                        frame2Location = 2;
                    }
                    else
                    {
                        pBoxFrame2.Location = new Point(0, 0);
                        frame2Location = -1;
                    }
                    break;

                default:
                    break;

            }
        }

        private void moveAnimalIntoPos1(object sender, EventArgs e)
        {
            //moveAnimal(pBoxFrame1.Location);
            //Point newAnimalLocation = new Point(pBoxFrame1.Left, pBoxFrame1.Top);
            pBoxFrame1.Visible = false;
            pBoxFrame2.Visible = false;
            pBoxFrame1.Enabled = false;
            pBoxFrame2.Enabled = false;
            if (animalSelected == 0)
            {
                pBoxBunny1.BorderStyle = BorderStyle.None;
                pBoxBunny1.Location = pBoxFrame1.Location;
                animalLocations[0] = frame1Location;
                frame1Location = -1;
                frame2Location = -1;
                moves++;
            }
            else if(animalSelected == 1)
            {
                pBoxBunny2.BorderStyle = BorderStyle.None;
                pBoxBunny2.Location = pBoxFrame1.Location;
                animalLocations[1] = frame1Location;
                frame1Location = -1;
                frame2Location = -1;
                moves++;
            }
            else if (animalSelected == 2)
            {
                pBoxSquirrel1.BorderStyle = BorderStyle.None;
                pBoxSquirrel1.Location = pBoxFrame1.Location;
                animalLocations[2] = frame1Location;
                frame1Location = -1;
                frame2Location = -1;
                moves++;
            }
            else if (animalSelected == 3)
            {
                pBoxSquirrel2.BorderStyle = BorderStyle.None;
                pBoxSquirrel2.Location = pBoxFrame1.Location;
                animalLocations[3] = frame1Location;
                frame1Location = -1;
                frame2Location = -1;
                moves++;
            }
            lblMoves.Text = "Moves made: " + moves;
            isVictory();
        }
        

        private void moveAnimalIntoPos2(object sender, EventArgs e)
        {
            //moveAnimal(pBoxFrame2.Location);
            //Point pBoxFrame2.Location = new Point(pBoxFrame1.Left, pBoxFrame1.Top);
            pBoxFrame1.Visible = false;
            pBoxFrame2.Visible = false;
            pBoxFrame1.Enabled = false;
            pBoxFrame2.Enabled = false;
            if (animalSelected == 0)
            {
                pBoxBunny1.BorderStyle = BorderStyle.None;
                pBoxBunny1.Location = pBoxFrame2.Location;
                animalLocations[0] = frame2Location;
                frame1Location = -1;
                frame2Location = -1;
                moves++;
            }
            else if (animalSelected == 1)
            {
                pBoxBunny2.BorderStyle = BorderStyle.None;
                pBoxBunny2.Location = pBoxFrame2.Location;
                animalLocations[1] = frame2Location;
                frame1Location = -1;
                frame2Location = -1;
                moves++;
            }
            else if (animalSelected == 2)
            {
                pBoxSquirrel1.BorderStyle = BorderStyle.None;
                pBoxSquirrel1.Location = pBoxFrame2.Location;
                animalLocations[2] = frame2Location;
                frame1Location = -1;
                frame2Location = -1;
                moves++;
            }
            else if (animalSelected == 3)
            {
                pBoxSquirrel2.BorderStyle = BorderStyle.None;
                pBoxSquirrel2.Location = pBoxFrame2.Location;
                animalLocations[3] = frame2Location;
                frame1Location = -1;
                frame2Location = -1;
                moves++;
            }
            lblMoves.Text = "Moves made: " + moves;
            isVictory();
        }

        private void isVictory()
        {
            if ((moves <= 16) && (animalLocations[0] == 6 || animalLocations[0] == 8) && (animalLocations[1] == 6 || animalLocations[1] == 8) && (animalLocations[2] == 1 || animalLocations[2] == 3) && (animalLocations[3] == 1 || animalLocations[3] == 3))
            {
                MessageBox.Show("You WIN !");
            }else if(moves > 16)
            {
                MessageBox.Show("Press 'Restart' button. Moves amount should not exceed 16.");
                lblTarget.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}

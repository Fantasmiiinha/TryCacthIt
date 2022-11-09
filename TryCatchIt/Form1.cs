using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchIt
{
    public partial class Frm_Main : Form
    {
        int playerSpeed = 8;
        int foodSpeed = 3;
        int gameTime = 0;
        int points = 0;
        int lastNum = 0;
        int lastXSpawed = 0;
        int lifes = 3;
        bool movingLeft, movingRight;
        List<Food> foodList = new List<Food>();
        Random rnd = new Random();
        Configs cfg = new Configs();

        public Frm_Main()
        {
            InitializeComponent();

            for (int i = 0; i < 15; i++)
            {
                PictureBox pbx = (PictureBox)this.Controls["imgFood" + (i + 1)];
                foodList.Add(new Food(pbx, rnd.Next(1, 3)));
            }

        }

        private void foodSpawTimer_Tick(object sender, EventArgs e)
        {
            foreach (Food f in foodList)
            {
                PictureBox pbx = f.getPictureBox();

                pbx.Location = new Point(pbx.Location.X, pbx.Location.Y + foodSpeed);
            }

            foreach (Food f in foodList)
            {
                if(lastXSpawed == 0)
                {
                    lastXSpawed = rnd.Next(3, 695);
                }

                PictureBox pbx = f.getPictureBox();

                if(imgPlayer.Bounds.IntersectsWith(pbx.Bounds))
                {
                    RePositionFood(pbx);
                    points += f.getPoints();
                    txtScore.Text = "SCORE: " + points;
                }

                if (pbx.Location.Y > 645)
                {
                    lifes--;
                    RePositionFood(pbx);
                }

            }

            if(lifes == 2)
            {
                imgLife3.Visible = false;
            } else if (lifes == 1)
            {
                imgLife2.Visible = false;
            } else if (lifes == 0)
            {
                GameOver();
            }
        }

        private void RePositionFood(PictureBox pbx)
        {
            int iniX, finX;

            pbx.Location = new Point(lastXSpawed, ((Panel)this.Controls["pn" + PanelRandom()]).Location.Y);

            if (lastXSpawed - 100 > 0)
            {
                iniX = lastXSpawed - 100;
            }
            else
            {
                iniX = 0;
            }
            if (lastXSpawed + 101 < 695)
            {
                finX = lastXSpawed + 101;
            }
            else
            {
                finX = 695;
            }
            lastXSpawed = rnd.Next(iniX, finX);
        }

        private int PanelRandom()
        {
            int num = rnd.Next(1, 4);
            while(num == lastNum)
            {
                num = rnd.Next(1, 4);
            }
            lastNum = num;
            return num;
        }

        private void GameTick(object sender, EventArgs e)
        {
            if (movingLeft && imgPlayer.Location.X > 0)
            {
                imgPlayer.Location = new Point(imgPlayer.Location.X - playerSpeed, imgPlayer.Location.Y);
            }
            if (movingRight && imgPlayer.Location.X < cfg.getFieldX() - cfg.getPlayerX() + 5) 
            {
                imgPlayer.Location = new Point(imgPlayer.Location.X + playerSpeed, imgPlayer.Location.Y);
            }
        }

        private void stopWatch_Tick(object sender, EventArgs e)
        {
           /* txtTime.Text = "Speed: " + foodSpeed;

            if (gameTime == 20 && foodSpeed + 1 < 5) {
                foodSpeed = 3;
            }

            if (gameTime == 40 && foodSpeed + 1 < 5)
            {
                foodSpeed = 4;
            }

            if (foodSpeed == 4)
            {
                playerSpeed += 2;
            }

            gameTime++;*/
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            gameTimer.Enabled = true;
            foodSpawTimer.Enabled = true;
            stopWatch.Enabled = true;
        }

        private void Frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                movingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                movingRight = true;
            }
            if (e.KeyCode == Keys.Space && movingLeft)
            {
                for(int i = 1; i < 101; i++)
                {
                    imgPlayer.Location = new Point(imgPlayer.Location.X - 1, imgPlayer.Location.Y); 
                }
                
            } 
            else if (e.KeyCode == Keys.Space && movingRight)
            {
                for(int i = 1; i < 101; i++)
                {
                    imgPlayer.Location = new Point(imgPlayer.Location.X + 1, imgPlayer.Location.Y); 
                }
                
            }
        }

        private void Frm_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                movingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                movingRight = false;
            }
        }

        private void GameOver()
        {
            gameTimer.Enabled = false;
            foodSpawTimer.Enabled = false;
            btnStart.Enabled = true;
            lifes = 3;
            imgLife2.Visible = true;
            imgLife3.Visible = true;

            MessageBox.Show("Você perdeu \n" +
                "Score: " + points);

            points = 0;
        }
    }
}

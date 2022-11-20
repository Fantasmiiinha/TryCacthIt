using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TryCatchIt
{
    public partial class Frm_Main : Form
    {
        int playerSpeed = 8;
        int foodSpeed = 3;
        int points = 0;
        int lastNum = 0;
        int lastXSpawed = 0;
        int lifes = 3;
        int diffTick = 0;
        bool movingLeft, movingRight;
        List<Food> foodList = new List<Food>();
        Random rnd = new Random();
        Configs cfg = new Configs();
        bool lifeFalling = false;
        SoundPlayer radio = new SoundPlayer();

        public Frm_Main()
        {
            InitializeComponent();

            imgPlayer.Parent = BackgroundImg;
            pbxGame.Parent = BackgroundImg;
            pbxGame2.Parent = BackgroundImg;
            pbxEx1.Parent = BackgroundImg;
            pbxEx2.Parent = BackgroundImg;
            pbxEx3.Parent = BackgroundImg;
            pbxEx4.Parent = BackgroundImg;
            pbxLife.Parent = BackgroundImg;
            pbxLife.Visible = false;
            lbl1.Parent = BackgroundImg;
            lbl2.Parent = BackgroundImg;
            lbl3.Parent = BackgroundImg;
            lbl4.Parent = BackgroundImg;
            btnStart.Parent = BackgroundImg;

            Dao dao = new Dao();
            dao.OpenConnection();

            for (int i = 0; i < 13; i++)
            {
                PictureBox pbx = (PictureBox)this.Controls["imgFood" + (i + 1)];
                pbx.Parent = BackgroundImg;
                foodList.Add(new Food(pbx, rnd.Next(1, 5)));
            }

            RandomSpawn();

            radio.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\ost2.wav";
            radio.PlayLooping();
        }

        private void foodSpawTimer_Tick(object sender, EventArgs e)
        {
            foreach (Food f in foodList)
            {
                PictureBox pbx = f.getPictureBox();

                pbx.Location = new Point(pbx.Location.X, pbx.Location.Y + foodSpeed);
            }

            if(lifeFalling)
            {
                pbxLife.Visible = true;
                pbxLife.Location = new Point(pbxLife.Location.X, pbxLife.Location.Y + 2);
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
                    txtScore.Text = "" + points;
                }

                if (pbx.Location.Y > 645)
                {
                    lifes--;
                    RePositionFood(pbx);
                }

                if(imgPlayer.Bounds.IntersectsWith(pbxLife.Bounds))
                {
                    lifes++;
                    lifeFalling = false;
                    pbxLife.Location = new Point(387, 0);
                    pbxLife.Visible = false;

                    if(imgLife2.Visible == false)
                    {
                        imgLife2.Visible = true;
                    } else if(imgLife3.Visible == false)
                    {
                        imgLife3.Visible = true;
                    }
                }
            }

            if(lifes == 2)
            {
                imgLife3.Visible = false;
            } else if (lifes == 1)
            {
                imgLife2.Visible = false;
            } else if (lifes < 1)
            {
                GameOver();
            }
        }
        private void RandomSpawn()
        {
            lastXSpawed = rnd.Next(3, 695);
            foreach(Food f in foodList)
            {
                PictureBox pbx = f.getPictureBox();
                RePositionFood(pbx);
                pbx.Location = new Point(pbx.Location.X,  pbx.Location.Y - rnd.Next(1, 100)); 
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
            diffTick++;
            if(diffTick%3 == 0)
            {
                lifeFalling = true;
            }else if(diffTick%4 == 0)
            {
                playerSpeed += 2;
                foodSpeed++;
            }
        }

        private void Frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                imgPlayer.Image = (Image)TryCatchIt.Properties.Resources.dog1flip;
                movingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                imgPlayer.Image = (Image)TryCatchIt.Properties.Resources.dog1;
                movingRight = true;
            }
            if (e.KeyCode == Keys.Space && movingLeft)
            {
                if (imgPlayer.Location.X - 100 < 0)
                {
                    imgPlayer.Location = new Point(20, imgPlayer.Location.Y);
                }
                else
                {
                    for (int i = 1; i < 101; i++)
                    {
                        imgPlayer.Location = new Point(imgPlayer.Location.X - 1, imgPlayer.Location.Y);
                    }
                }
                
            } 
            else if (e.KeyCode == Keys.Space && movingRight)
            {
                if (imgPlayer.Location.X + 100 > 680)
                {
                    imgPlayer.Location = new Point(600, imgPlayer.Location.Y);
                }
                else
                {
                    for (int i = 1; i < 101; i++)
                    {
                        imgPlayer.Location = new Point(imgPlayer.Location.X + 1, imgPlayer.Location.Y);
                    }
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

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            gameTimer.Enabled = true;
            foodSpawTimer.Enabled = true;
            DiffTimer.Enabled = true;
            BackgroundImg.Image = (Image)TryCatchIt.Properties.Resources.fundo1;

            btnStart.Visible = false;
            pbxGame.Visible = false;
            pbxGame2.Visible = false;
            pbxEx1.Visible = false;
            pbxEx2.Visible = false;
            pbxEx3.Visible = false;
            pbxEx4.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.Image = (Image)TryCatchIt.Properties.Resources.start21;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Image = (Image)TryCatchIt.Properties.Resources.start1;
        }

        private void GameOver()
        {
            gameTimer.Enabled = false;
            foodSpawTimer.Enabled = false;
            btnStart.Enabled = true;
            lifes = 3;
            imgLife2.Visible = true;
            imgLife3.Visible = true;

            gameTimer.Enabled = false;
            foodSpawTimer.Enabled = false;
            DiffTimer.Enabled = false;

            MessageBox.Show("Você perdeu \n" +
                "Score: " + points);

            points = 0;
            RandomSpawn();
            imgPlayer.Location = new Point(322, 527);

            btnStart.Visible = true;
            pbxGame.Visible = true;
            pbxGame2.Visible = true;
            pbxEx1.Visible = true;
            pbxEx2.Visible = true;
            pbxEx3.Visible = true;
            pbxEx4.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            BackgroundImg.Image = (Image)TryCatchIt.Properties.Resources.fundo___Copia;

            playerSpeed = 8;
            foodSpeed = 3;
            diffTick = 0;
        }
    }
}

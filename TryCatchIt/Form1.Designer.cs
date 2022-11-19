namespace TryCatchIt
{
    partial class Frm_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.btnStart = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.foodSpawTimer = new System.Windows.Forms.Timer(this.components);
            this.pn1 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.pn3 = new System.Windows.Forms.Panel();
            this.DiffTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.pbxGame2 = new System.Windows.Forms.PictureBox();
            this.pbxGame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxLife = new System.Windows.Forms.PictureBox();
            this.imgFood12 = new System.Windows.Forms.PictureBox();
            this.pbxHeigthRnd = new System.Windows.Forms.PictureBox();
            this.imgFood13 = new System.Windows.Forms.PictureBox();
            this.imgFood11 = new System.Windows.Forms.PictureBox();
            this.imgFood4 = new System.Windows.Forms.PictureBox();
            this.imgFood5 = new System.Windows.Forms.PictureBox();
            this.imgFood7 = new System.Windows.Forms.PictureBox();
            this.imgFood8 = new System.Windows.Forms.PictureBox();
            this.imgFood10 = new System.Windows.Forms.PictureBox();
            this.imgFood9 = new System.Windows.Forms.PictureBox();
            this.imgFood2 = new System.Windows.Forms.PictureBox();
            this.imgFood6 = new System.Windows.Forms.PictureBox();
            this.imgFood3 = new System.Windows.Forms.PictureBox();
            this.imgFood1 = new System.Windows.Forms.PictureBox();
            this.imgLife3 = new System.Windows.Forms.PictureBox();
            this.imgLife2 = new System.Windows.Forms.PictureBox();
            this.imgLife1 = new System.Windows.Forms.PictureBox();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.BackgroundImg = new System.Windows.Forms.PictureBox();
            this.pbxEx1 = new System.Windows.Forms.PictureBox();
            this.pbxEx2 = new System.Windows.Forms.PictureBox();
            this.pbxEx3 = new System.Windows.Forms.PictureBox();
            this.pbxEx4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeigthRnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEx4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(280, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 73);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.GameTick);
            // 
            // foodSpawTimer
            // 
            this.foodSpawTimer.Interval = 2;
            this.foodSpawTimer.Tick += new System.EventHandler(this.foodSpawTimer_Tick);
            // 
            // pn1
            // 
            this.pn1.Location = new System.Drawing.Point(2, -100);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(730, 100);
            this.pn1.TabIndex = 36;
            // 
            // pn2
            // 
            this.pn2.Location = new System.Drawing.Point(2, -250);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(730, 100);
            this.pn2.TabIndex = 37;
            // 
            // pn3
            // 
            this.pn3.Location = new System.Drawing.Point(2, -400);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(730, 100);
            this.pn3.TabIndex = 38;
            // 
            // DiffTimer
            // 
            this.DiffTimer.Interval = 15000;
            this.DiffTimer.Tick += new System.EventHandler(this.stopWatch_Tick);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(136, 721);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(106, 25);
            this.txtScore.TabIndex = 42;
            // 
            // pbxGame2
            // 
            this.pbxGame2.BackColor = System.Drawing.Color.Transparent;
            this.pbxGame2.Image = global::TryCatchIt.Properties.Resources.fonte2;
            this.pbxGame2.Location = new System.Drawing.Point(238, 387);
            this.pbxGame2.Name = "pbxGame2";
            this.pbxGame2.Size = new System.Drawing.Size(262, 100);
            this.pbxGame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGame2.TabIndex = 44;
            this.pbxGame2.TabStop = false;
            // 
            // pbxGame
            // 
            this.pbxGame.BackColor = System.Drawing.Color.Transparent;
            this.pbxGame.Image = global::TryCatchIt.Properties.Resources.titulo2;
            this.pbxGame.Location = new System.Drawing.Point(158, 50);
            this.pbxGame.Name = "pbxGame";
            this.pbxGame.Size = new System.Drawing.Size(417, 206);
            this.pbxGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGame.TabIndex = 43;
            this.pbxGame.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TryCatchIt.Properties.Resources.fonte1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 686);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pbxLife
            // 
            this.pbxLife.BackColor = System.Drawing.Color.Transparent;
            this.pbxLife.Image = global::TryCatchIt.Properties.Resources.coracao1;
            this.pbxLife.Location = new System.Drawing.Point(387, 0);
            this.pbxLife.Name = "pbxLife";
            this.pbxLife.Size = new System.Drawing.Size(35, 35);
            this.pbxLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLife.TabIndex = 40;
            this.pbxLife.TabStop = false;
            // 
            // imgFood12
            // 
            this.imgFood12.BackColor = System.Drawing.Color.Transparent;
            this.imgFood12.Location = new System.Drawing.Point(100, 141);
            this.imgFood12.Name = "imgFood12";
            this.imgFood12.Size = new System.Drawing.Size(35, 35);
            this.imgFood12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood12.TabIndex = 18;
            this.imgFood12.TabStop = false;
            // 
            // pbxHeigthRnd
            // 
            this.pbxHeigthRnd.Location = new System.Drawing.Point(0, -100);
            this.pbxHeigthRnd.Name = "pbxHeigthRnd";
            this.pbxHeigthRnd.Size = new System.Drawing.Size(591, 1);
            this.pbxHeigthRnd.TabIndex = 34;
            this.pbxHeigthRnd.TabStop = false;
            // 
            // imgFood13
            // 
            this.imgFood13.BackColor = System.Drawing.Color.Transparent;
            this.imgFood13.Location = new System.Drawing.Point(100, 182);
            this.imgFood13.Name = "imgFood13";
            this.imgFood13.Size = new System.Drawing.Size(35, 35);
            this.imgFood13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood13.TabIndex = 19;
            this.imgFood13.TabStop = false;
            // 
            // imgFood11
            // 
            this.imgFood11.BackColor = System.Drawing.Color.Transparent;
            this.imgFood11.Location = new System.Drawing.Point(59, 141);
            this.imgFood11.Name = "imgFood11";
            this.imgFood11.Size = new System.Drawing.Size(35, 35);
            this.imgFood11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood11.TabIndex = 17;
            this.imgFood11.TabStop = false;
            // 
            // imgFood4
            // 
            this.imgFood4.BackColor = System.Drawing.Color.Transparent;
            this.imgFood4.Location = new System.Drawing.Point(100, 18);
            this.imgFood4.Name = "imgFood4";
            this.imgFood4.Size = new System.Drawing.Size(35, 35);
            this.imgFood4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood4.TabIndex = 16;
            this.imgFood4.TabStop = false;
            // 
            // imgFood5
            // 
            this.imgFood5.BackColor = System.Drawing.Color.Transparent;
            this.imgFood5.Image = global::TryCatchIt.Properties.Resources.comida2;
            this.imgFood5.Location = new System.Drawing.Point(100, 59);
            this.imgFood5.Name = "imgFood5";
            this.imgFood5.Size = new System.Drawing.Size(35, 35);
            this.imgFood5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood5.TabIndex = 15;
            this.imgFood5.TabStop = false;
            // 
            // imgFood7
            // 
            this.imgFood7.BackColor = System.Drawing.Color.Transparent;
            this.imgFood7.Image = global::TryCatchIt.Properties.Resources.comida4;
            this.imgFood7.Location = new System.Drawing.Point(18, 59);
            this.imgFood7.Name = "imgFood7";
            this.imgFood7.Size = new System.Drawing.Size(35, 35);
            this.imgFood7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood7.TabIndex = 14;
            this.imgFood7.TabStop = false;
            // 
            // imgFood8
            // 
            this.imgFood8.BackColor = System.Drawing.Color.Transparent;
            this.imgFood8.Location = new System.Drawing.Point(59, 18);
            this.imgFood8.Name = "imgFood8";
            this.imgFood8.Size = new System.Drawing.Size(35, 35);
            this.imgFood8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood8.TabIndex = 13;
            this.imgFood8.TabStop = false;
            // 
            // imgFood10
            // 
            this.imgFood10.BackColor = System.Drawing.Color.Transparent;
            this.imgFood10.Location = new System.Drawing.Point(652, 141);
            this.imgFood10.Name = "imgFood10";
            this.imgFood10.Size = new System.Drawing.Size(35, 35);
            this.imgFood10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood10.TabIndex = 12;
            this.imgFood10.TabStop = false;
            // 
            // imgFood9
            // 
            this.imgFood9.BackColor = System.Drawing.Color.Transparent;
            this.imgFood9.Location = new System.Drawing.Point(18, 18);
            this.imgFood9.Name = "imgFood9";
            this.imgFood9.Size = new System.Drawing.Size(35, 35);
            this.imgFood9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood9.TabIndex = 11;
            this.imgFood9.TabStop = false;
            // 
            // imgFood2
            // 
            this.imgFood2.BackColor = System.Drawing.Color.Transparent;
            this.imgFood2.Image = global::TryCatchIt.Properties.Resources.comida1;
            this.imgFood2.Location = new System.Drawing.Point(693, 141);
            this.imgFood2.Name = "imgFood2";
            this.imgFood2.Size = new System.Drawing.Size(35, 35);
            this.imgFood2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood2.TabIndex = 10;
            this.imgFood2.TabStop = false;
            // 
            // imgFood6
            // 
            this.imgFood6.BackColor = System.Drawing.Color.Transparent;
            this.imgFood6.Image = global::TryCatchIt.Properties.Resources.comida3;
            this.imgFood6.Location = new System.Drawing.Point(59, 59);
            this.imgFood6.Name = "imgFood6";
            this.imgFood6.Size = new System.Drawing.Size(35, 35);
            this.imgFood6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood6.TabIndex = 9;
            this.imgFood6.TabStop = false;
            // 
            // imgFood3
            // 
            this.imgFood3.BackColor = System.Drawing.Color.Transparent;
            this.imgFood3.Location = new System.Drawing.Point(15, 142);
            this.imgFood3.Name = "imgFood3";
            this.imgFood3.Size = new System.Drawing.Size(35, 35);
            this.imgFood3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood3.TabIndex = 8;
            this.imgFood3.TabStop = false;
            // 
            // imgFood1
            // 
            this.imgFood1.BackColor = System.Drawing.Color.Transparent;
            this.imgFood1.Location = new System.Drawing.Point(608, 142);
            this.imgFood1.Name = "imgFood1";
            this.imgFood1.Size = new System.Drawing.Size(35, 35);
            this.imgFood1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFood1.TabIndex = 7;
            this.imgFood1.TabStop = false;
            // 
            // imgLife3
            // 
            this.imgLife3.Image = ((System.Drawing.Image)(resources.GetObject("imgLife3.Image")));
            this.imgLife3.Location = new System.Drawing.Point(640, 700);
            this.imgLife3.Name = "imgLife3";
            this.imgLife3.Size = new System.Drawing.Size(55, 46);
            this.imgLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLife3.TabIndex = 6;
            this.imgLife3.TabStop = false;
            // 
            // imgLife2
            // 
            this.imgLife2.Image = ((System.Drawing.Image)(resources.GetObject("imgLife2.Image")));
            this.imgLife2.Location = new System.Drawing.Point(571, 700);
            this.imgLife2.Name = "imgLife2";
            this.imgLife2.Size = new System.Drawing.Size(55, 46);
            this.imgLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLife2.TabIndex = 5;
            this.imgLife2.TabStop = false;
            // 
            // imgLife1
            // 
            this.imgLife1.Image = ((System.Drawing.Image)(resources.GetObject("imgLife1.Image")));
            this.imgLife1.Location = new System.Drawing.Point(502, 700);
            this.imgLife1.Name = "imgLife1";
            this.imgLife1.Size = new System.Drawing.Size(55, 46);
            this.imgLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLife1.TabIndex = 4;
            this.imgLife1.TabStop = false;
            // 
            // imgPlayer
            // 
            this.imgPlayer.ErrorImage = null;
            this.imgPlayer.Image = global::TryCatchIt.Properties.Resources.dog1;
            this.imgPlayer.Location = new System.Drawing.Point(332, 527);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(108, 153);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 1;
            this.imgPlayer.TabStop = false;
            // 
            // BackgroundImg
            // 
            this.BackgroundImg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImg.Location = new System.Drawing.Point(2, 0);
            this.BackgroundImg.Name = "BackgroundImg";
            this.BackgroundImg.Size = new System.Drawing.Size(730, 680);
            this.BackgroundImg.TabIndex = 0;
            this.BackgroundImg.TabStop = false;
            // 
            // pbxEx1
            // 
            this.pbxEx1.BackColor = System.Drawing.Color.Transparent;
            this.pbxEx1.Image = global::TryCatchIt.Properties.Resources.comida1;
            this.pbxEx1.Location = new System.Drawing.Point(35, 310);
            this.pbxEx1.Name = "pbxEx1";
            this.pbxEx1.Size = new System.Drawing.Size(35, 35);
            this.pbxEx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEx1.TabIndex = 45;
            this.pbxEx1.TabStop = false;
            // 
            // pbxEx2
            // 
            this.pbxEx2.BackColor = System.Drawing.Color.Transparent;
            this.pbxEx2.Image = global::TryCatchIt.Properties.Resources.comida2;
            this.pbxEx2.Location = new System.Drawing.Point(134, 310);
            this.pbxEx2.Name = "pbxEx2";
            this.pbxEx2.Size = new System.Drawing.Size(35, 35);
            this.pbxEx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEx2.TabIndex = 46;
            this.pbxEx2.TabStop = false;
            // 
            // pbxEx3
            // 
            this.pbxEx3.BackColor = System.Drawing.Color.Transparent;
            this.pbxEx3.Image = global::TryCatchIt.Properties.Resources.comida3;
            this.pbxEx3.Location = new System.Drawing.Point(567, 310);
            this.pbxEx3.Name = "pbxEx3";
            this.pbxEx3.Size = new System.Drawing.Size(35, 35);
            this.pbxEx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEx3.TabIndex = 47;
            this.pbxEx3.TabStop = false;
            // 
            // pbxEx4
            // 
            this.pbxEx4.BackColor = System.Drawing.Color.Transparent;
            this.pbxEx4.Image = global::TryCatchIt.Properties.Resources.comida4;
            this.pbxEx4.Location = new System.Drawing.Point(660, 310);
            this.pbxEx4.Name = "pbxEx4";
            this.pbxEx4.Size = new System.Drawing.Size(35, 35);
            this.pbxEx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEx4.TabIndex = 48;
            this.pbxEx4.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 861);
            this.Controls.Add(this.pbxEx4);
            this.Controls.Add(this.pbxEx3);
            this.Controls.Add(this.pbxEx2);
            this.Controls.Add(this.pbxEx1);
            this.Controls.Add(this.pbxGame2);
            this.Controls.Add(this.pbxGame);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxLife);
            this.Controls.Add(this.imgFood12);
            this.Controls.Add(this.pn3);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pbxHeigthRnd);
            this.Controls.Add(this.imgFood13);
            this.Controls.Add(this.imgFood11);
            this.Controls.Add(this.imgFood4);
            this.Controls.Add(this.imgFood5);
            this.Controls.Add(this.imgFood7);
            this.Controls.Add(this.imgFood8);
            this.Controls.Add(this.imgFood10);
            this.Controls.Add(this.imgFood9);
            this.Controls.Add(this.imgFood2);
            this.Controls.Add(this.imgFood6);
            this.Controls.Add(this.imgFood3);
            this.Controls.Add(this.imgFood1);
            this.Controls.Add(this.imgLife3);
            this.Controls.Add(this.imgLife2);
            this.Controls.Add(this.imgLife1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.BackgroundImg);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Try Catch It";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeigthRnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEx4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundImg;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox imgLife1;
        private System.Windows.Forms.PictureBox imgLife2;
        private System.Windows.Forms.PictureBox imgLife3;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer foodSpawTimer;
        private System.Windows.Forms.PictureBox imgFood1;
        private System.Windows.Forms.PictureBox imgFood3;
        private System.Windows.Forms.PictureBox imgFood6;
        private System.Windows.Forms.PictureBox imgFood2;
        private System.Windows.Forms.PictureBox imgFood9;
        private System.Windows.Forms.PictureBox imgFood10;
        private System.Windows.Forms.PictureBox imgFood8;
        private System.Windows.Forms.PictureBox imgFood7;
        private System.Windows.Forms.PictureBox imgFood5;
        private System.Windows.Forms.PictureBox imgFood4;
        private System.Windows.Forms.PictureBox imgFood11;
        private System.Windows.Forms.PictureBox imgFood12;
        private System.Windows.Forms.PictureBox imgFood13;
        private System.Windows.Forms.PictureBox pbxHeigthRnd;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Timer DiffTimer;
        private System.Windows.Forms.PictureBox pbxLife;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pbxGame;
        private System.Windows.Forms.PictureBox pbxGame2;
        private System.Windows.Forms.PictureBox pbxEx1;
        private System.Windows.Forms.PictureBox pbxEx2;
        private System.Windows.Forms.PictureBox pbxEx3;
        private System.Windows.Forms.PictureBox pbxEx4;
    }
}


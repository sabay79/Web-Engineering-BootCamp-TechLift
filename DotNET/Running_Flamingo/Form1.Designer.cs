namespace Running_T_Rex
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.flyingFlamingo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.runningTrack = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.bushes = new System.Windows.Forms.PictureBox();
            this.trunk = new System.Windows.Forms.PictureBox();
            this.cactus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyingFlamingo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(15, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(76, 20);
            this.score.TabIndex = 7;
            this.score.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(83, 87);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // flyingFlamingo
            // 
            this.flyingFlamingo.BackColor = System.Drawing.Color.Transparent;
            this.flyingFlamingo.Image = ((System.Drawing.Image)(resources.GetObject("flyingFlamingo.Image")));
            this.flyingFlamingo.Location = new System.Drawing.Point(574, 165);
            this.flyingFlamingo.Name = "flyingFlamingo";
            this.flyingFlamingo.Size = new System.Drawing.Size(100, 80);
            this.flyingFlamingo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flyingFlamingo.TabIndex = 8;
            this.flyingFlamingo.TabStop = false;
            this.flyingFlamingo.Tag = "obstacle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(489, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // runningTrack
            // 
            this.runningTrack.BackColor = System.Drawing.Color.SandyBrown;
            this.runningTrack.Location = new System.Drawing.Point(-10, 404);
            this.runningTrack.Name = "runningTrack";
            this.runningTrack.Size = new System.Drawing.Size(714, 56);
            this.runningTrack.TabIndex = 0;
            this.runningTrack.TabStop = false;
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = ((System.Drawing.Image)(resources.GetObject("character.Image")));
            this.character.Location = new System.Drawing.Point(15, 316);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(60, 90);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character.TabIndex = 1;
            this.character.TabStop = false;
            // 
            // bushes
            // 
            this.bushes.BackColor = System.Drawing.Color.Transparent;
            this.bushes.Image = ((System.Drawing.Image)(resources.GetObject("bushes.Image")));
            this.bushes.Location = new System.Drawing.Point(401, 379);
            this.bushes.Name = "bushes";
            this.bushes.Size = new System.Drawing.Size(60, 25);
            this.bushes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bushes.TabIndex = 2;
            this.bushes.TabStop = false;
            this.bushes.Tag = "obstacle";
            // 
            // trunk
            // 
            this.trunk.BackColor = System.Drawing.Color.Transparent;
            this.trunk.Image = ((System.Drawing.Image)(resources.GetObject("trunk.Image")));
            this.trunk.Location = new System.Drawing.Point(467, 362);
            this.trunk.Name = "trunk";
            this.trunk.Size = new System.Drawing.Size(50, 50);
            this.trunk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trunk.TabIndex = 4;
            this.trunk.TabStop = false;
            this.trunk.Tag = "obstacle";
            // 
            // cactus
            // 
            this.cactus.BackColor = System.Drawing.Color.Transparent;
            this.cactus.Image = ((System.Drawing.Image)(resources.GetObject("cactus.Image")));
            this.cactus.Location = new System.Drawing.Point(523, 350);
            this.cactus.Name = "cactus";
            this.cactus.Size = new System.Drawing.Size(45, 55);
            this.cactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cactus.TabIndex = 5;
            this.cactus.TabStop = false;
            this.cactus.Tag = "obstacle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(690, 447);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.flyingFlamingo);
            this.Controls.Add(this.score);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.runningTrack);
            this.Controls.Add(this.character);
            this.Controls.Add(this.bushes);
            this.Controls.Add(this.cactus);
            this.Controls.Add(this.trunk);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "T Rex Runner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyingFlamingo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bushes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox runningTrack;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox bushes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox flyingFlamingo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox trunk;
        private System.Windows.Forms.PictureBox cactus;
    }
}


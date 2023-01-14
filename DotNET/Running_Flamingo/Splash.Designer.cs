namespace Running_T_Rex
{
    partial class Splash
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
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBar.Font = new System.Drawing.Font("Microsoft YaHei", 32F, System.Drawing.FontStyle.Bold);
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(39, 97);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.progressBar.ProgressWidth = 6;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar.Size = new System.Drawing.Size(175, 175);
            this.progressBar.StartAngle = 270;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar.SubscriptText = ".23";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "";
            this.progressBar.TabIndex = 0;
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBar.Value = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Running_T_Rex.Properties.Resources.runningFlamingo;
            this.pictureBox1.Location = new System.Drawing.Point(97, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Merriweather", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Running Flamingo";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Merriweather", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.progressLabel.Location = new System.Drawing.Point(113, 314);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(25, 15);
            this.progressLabel.TabIndex = 4;
            this.progressLabel.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Merriweather", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(95, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loading...";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(256, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Merriweather", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Splash";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label label3;
    }
}
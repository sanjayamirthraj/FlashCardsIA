
namespace SanjayComSciIA
{
    partial class StudyingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyingScreen));
            this.HeadingMainScreen = new System.Windows.Forms.PictureBox();
            this.lblCurrentlyStudying = new System.Windows.Forms.Label();
            this.txtCardAnswer = new System.Windows.Forms.TextBox();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingMainScreen
            // 
            this.HeadingMainScreen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HeadingMainScreen.InitialImage = ((System.Drawing.Image)(resources.GetObject("HeadingMainScreen.InitialImage")));
            this.HeadingMainScreen.Location = new System.Drawing.Point(-2, 1);
            this.HeadingMainScreen.Name = "HeadingMainScreen";
            this.HeadingMainScreen.Size = new System.Drawing.Size(516, 93);
            this.HeadingMainScreen.TabIndex = 5;
            this.HeadingMainScreen.TabStop = false;
            // 
            // lblCurrentlyStudying
            // 
            this.lblCurrentlyStudying.AutoSize = true;
            this.lblCurrentlyStudying.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCurrentlyStudying.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentlyStudying.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentlyStudying.Location = new System.Drawing.Point(139, 35);
            this.lblCurrentlyStudying.Name = "lblCurrentlyStudying";
            this.lblCurrentlyStudying.Size = new System.Drawing.Size(282, 27);
            this.lblCurrentlyStudying.TabIndex = 11;
            this.lblCurrentlyStudying.Text = "Currently Studying";
            // 
            // txtCardAnswer
            // 
            this.txtCardAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.txtCardAnswer.Location = new System.Drawing.Point(23, 158);
            this.txtCardAnswer.Multiline = true;
            this.txtCardAnswer.Name = "txtCardAnswer";
            this.txtCardAnswer.Size = new System.Drawing.Size(372, 131);
            this.txtCardAnswer.TabIndex = 13;
            // 
            // btnFlip
            // 
            this.btnFlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlip.ForeColor = System.Drawing.Color.White;
            this.btnFlip.Location = new System.Drawing.Point(178, 304);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(160, 42);
            this.btnFlip.TabIndex = 15;
            this.btnFlip.Text = "Flip";
            this.btnFlip.UseVisualStyleBackColor = false;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHard.ForeColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(376, 380);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(108, 41);
            this.btnHard.TabIndex = 16;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMedium.ForeColor = System.Drawing.Color.White;
            this.btnMedium.Location = new System.Drawing.Point(208, 380);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(108, 41);
            this.btnMedium.TabIndex = 17;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEasy.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEasy.Location = new System.Drawing.Point(37, 380);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(108, 41);
            this.btnEasy.TabIndex = 18;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(225, 115);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.Location = new System.Drawing.Point(401, 180);
            this.txtDifficulty.Multiline = true;
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.Size = new System.Drawing.Size(102, 88);
            this.txtDifficulty.TabIndex = 21;
            // 
            // StudyingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.txtCardAnswer);
            this.Controls.Add(this.lblCurrentlyStudying);
            this.Controls.Add(this.HeadingMainScreen);
            this.Name = "StudyingScreen";
            this.Text = "Studying Screen";
            this.Load += new System.EventHandler(this.StudyingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HeadingMainScreen;
        private System.Windows.Forms.Label lblCurrentlyStudying;
        private System.Windows.Forms.TextBox txtCardAnswer;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtDifficulty;
    }
}
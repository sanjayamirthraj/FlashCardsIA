
namespace SanjayComSciIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StudyButton = new System.Windows.Forms.Button();
            this.HeadingMainScreen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditStudyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // StudyButton
            // 
            this.StudyButton.Location = new System.Drawing.Point(446, 191);
            this.StudyButton.Name = "StudyButton";
            this.StudyButton.Size = new System.Drawing.Size(118, 29);
            this.StudyButton.TabIndex = 0;
            this.StudyButton.Text = "Study";
            this.StudyButton.UseVisualStyleBackColor = true;
            this.StudyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HeadingMainScreen
            // 
            this.HeadingMainScreen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HeadingMainScreen.InitialImage = ((System.Drawing.Image)(resources.GetObject("HeadingMainScreen.InitialImage")));
            this.HeadingMainScreen.Location = new System.Drawing.Point(0, -2);
            this.HeadingMainScreen.Name = "HeadingMainScreen";
            this.HeadingMainScreen.Size = new System.Drawing.Size(618, 139);
            this.HeadingMainScreen.TabIndex = 2;
            this.HeadingMainScreen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(84, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(84, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(84, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(105, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Welcome To Your Study Session";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EditStudyButton
            // 
            this.EditStudyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditStudyButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStudyButton.Location = new System.Drawing.Point(55, 415);
            this.EditStudyButton.Name = "EditStudyButton";
            this.EditStudyButton.Size = new System.Drawing.Size(509, 47);
            this.EditStudyButton.TabIndex = 8;
            this.EditStudyButton.Text = "Edit and View Cards";
            this.EditStudyButton.UseVisualStyleBackColor = false;
            this.EditStudyButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Study";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Study";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditStudyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeadingMainScreen);
            this.Controls.Add(this.StudyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudyButton;
        private System.Windows.Forms.PictureBox HeadingMainScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditStudyButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


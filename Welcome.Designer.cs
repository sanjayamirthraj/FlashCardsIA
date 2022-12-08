
namespace SanjayComSciIA
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.HeadingMainScreen = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditAndStudy = new System.Windows.Forms.Button();
            this.btnStudy = new System.Windows.Forms.Button();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.lstSubjects = new System.Windows.Forms.ListBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).BeginInit();
            this.SuspendLayout();
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
            // 
            // btnEditAndStudy
            // 
            this.btnEditAndStudy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditAndStudy.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAndStudy.Location = new System.Drawing.Point(56, 400);
            this.btnEditAndStudy.Name = "btnEditAndStudy";
            this.btnEditAndStudy.Size = new System.Drawing.Size(255, 47);
            this.btnEditAndStudy.TabIndex = 8;
            this.btnEditAndStudy.Text = "Edit and View Cards";
            this.btnEditAndStudy.UseVisualStyleBackColor = false;
            this.btnEditAndStudy.Click += new System.EventHandler(this.btnEditAndStudy_Click);
            // 
            // btnStudy
            // 
            this.btnStudy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStudy.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudy.Location = new System.Drawing.Point(40, 321);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(551, 64);
            this.btnStudy.TabIndex = 9;
            this.btnStudy.Text = "Study";
            this.btnStudy.UseVisualStyleBackColor = false;
            this.btnStudy.Click += new System.EventHandler(this.btnStudy_Click);
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCard.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCard.Location = new System.Drawing.Point(317, 400);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(250, 47);
            this.btnAddCard.TabIndex = 10;
            this.btnAddCard.Text = "Add Cards";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // lstSubjects
            // 
            this.lstSubjects.FormattingEnabled = true;
            this.lstSubjects.Location = new System.Drawing.Point(40, 181);
            this.lstSubjects.Name = "lstSubjects";
            this.lstSubjects.Size = new System.Drawing.Size(551, 134);
            this.lstSubjects.TabIndex = 11;
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.Location = new System.Drawing.Point(247, 149);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(168, 29);
            this.lblSelectSubject.TabIndex = 12;
            this.lblSelectSubject.Text = "Select Subject";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 479);
            this.Controls.Add(this.lblSelectSubject);
            this.Controls.Add(this.lstSubjects);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.btnStudy);
            this.Controls.Add(this.btnEditAndStudy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeadingMainScreen);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox HeadingMainScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditAndStudy;
        private System.Windows.Forms.Button btnStudy;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.ListBox lstSubjects;
        private System.Windows.Forms.Label lblSelectSubject;
    }
}


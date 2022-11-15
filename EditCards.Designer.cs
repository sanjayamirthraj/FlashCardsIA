
namespace SanjayComSciIA
{
    partial class EditCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCards));
            this.HeadingMainScreen = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrontofCard = new System.Windows.Forms.Label();
            this.txtEditSubject = new System.Windows.Forms.TextBox();
            this.txtEditBack = new System.Windows.Forms.TextBox();
            this.txtEditFront = new System.Windows.Forms.TextBox();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingMainScreen
            // 
            this.HeadingMainScreen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HeadingMainScreen.InitialImage = ((System.Drawing.Image)(resources.GetObject("HeadingMainScreen.InitialImage")));
            this.HeadingMainScreen.Location = new System.Drawing.Point(-1, 0);
            this.HeadingMainScreen.Name = "HeadingMainScreen";
            this.HeadingMainScreen.Size = new System.Drawing.Size(517, 93);
            this.HeadingMainScreen.TabIndex = 5;
            this.HeadingMainScreen.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(143, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Editing a Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Edit Card Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Edit Back of Card";
            // 
            // lblFrontofCard
            // 
            this.lblFrontofCard.AutoSize = true;
            this.lblFrontofCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrontofCard.Location = new System.Drawing.Point(52, 115);
            this.lblFrontofCard.Name = "lblFrontofCard";
            this.lblFrontofCard.Size = new System.Drawing.Size(164, 25);
            this.lblFrontofCard.TabIndex = 24;
            this.lblFrontofCard.Text = "Edit Front of Card";
            // 
            // txtEditSubject
            // 
            this.txtEditSubject.Location = new System.Drawing.Point(57, 316);
            this.txtEditSubject.Name = "txtEditSubject";
            this.txtEditSubject.Size = new System.Drawing.Size(408, 20);
            this.txtEditSubject.TabIndex = 23;
            // 
            // txtEditBack
            // 
            this.txtEditBack.Location = new System.Drawing.Point(57, 235);
            this.txtEditBack.Name = "txtEditBack";
            this.txtEditBack.Size = new System.Drawing.Size(408, 20);
            this.txtEditBack.TabIndex = 22;
            // 
            // txtEditFront
            // 
            this.txtEditFront.Location = new System.Drawing.Point(57, 143);
            this.txtEditFront.Name = "txtEditFront";
            this.txtEditFront.Size = new System.Drawing.Size(408, 20);
            this.txtEditFront.TabIndex = 21;
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Location = new System.Drawing.Point(57, 377);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(408, 38);
            this.btnConfirmEdit.TabIndex = 27;
            this.btnConfirmEdit.Text = "Edit Card";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            this.btnConfirmEdit.Click += new System.EventHandler(this.btnConfirmEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EditCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirmEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFrontofCard);
            this.Controls.Add(this.txtEditSubject);
            this.Controls.Add(this.txtEditBack);
            this.Controls.Add(this.txtEditFront);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeadingMainScreen);
            this.Name = "EditCards";
            this.Text = "Edit Cards";
            this.Load += new System.EventHandler(this.EditCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HeadingMainScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFrontofCard;
        private System.Windows.Forms.TextBox txtEditSubject;
        private System.Windows.Forms.TextBox txtEditBack;
        private System.Windows.Forms.TextBox txtEditFront;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.Button btnExit;
    }
}
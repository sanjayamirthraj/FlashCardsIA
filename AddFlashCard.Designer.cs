
namespace SanjayComSciIA
{
    partial class AddFlashCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlashCard));
            this.HeadingMainScreen = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtEnterFront = new System.Windows.Forms.TextBox();
            this.txtEnterBack = new System.Windows.Forms.TextBox();
            this.txtEnterSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingMainScreen
            // 
            this.HeadingMainScreen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HeadingMainScreen.InitialImage = ((System.Drawing.Image)(resources.GetObject("HeadingMainScreen.InitialImage")));
            this.HeadingMainScreen.Location = new System.Drawing.Point(-1, 0);
            this.HeadingMainScreen.Name = "HeadingMainScreen";
            this.HeadingMainScreen.Size = new System.Drawing.Size(516, 93);
            this.HeadingMainScreen.TabIndex = 4;
            this.HeadingMainScreen.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(158, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adding a Card";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtEnterFront
            // 
            this.txtEnterFront.Location = new System.Drawing.Point(42, 144);
            this.txtEnterFront.Name = "txtEnterFront";
            this.txtEnterFront.Size = new System.Drawing.Size(408, 20);
            this.txtEnterFront.TabIndex = 15;
            // 
            // txtEnterBack
            // 
            this.txtEnterBack.Location = new System.Drawing.Point(42, 236);
            this.txtEnterBack.Name = "txtEnterBack";
            this.txtEnterBack.Size = new System.Drawing.Size(408, 20);
            this.txtEnterBack.TabIndex = 16;
            // 
            // txtEnterSubject
            // 
            this.txtEnterSubject.Location = new System.Drawing.Point(42, 317);
            this.txtEnterSubject.Name = "txtEnterSubject";
            this.txtEnterSubject.Size = new System.Drawing.Size(408, 20);
            this.txtEnterSubject.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Front of Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter Back of Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter Card Subject";
            // 
            // btnConfirmCard
            // 
            this.btnConfirmCard.Location = new System.Drawing.Point(42, 378);
            this.btnConfirmCard.Name = "btnConfirmCard";
            this.btnConfirmCard.Size = new System.Drawing.Size(408, 38);
            this.btnConfirmCard.TabIndex = 21;
            this.btnConfirmCard.Text = "Create Card";
            this.btnConfirmCard.UseVisualStyleBackColor = true;
            this.btnConfirmCard.Click += new System.EventHandler(this.btnConfirmCard_Click);
            // 
            // AddFlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnConfirmCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnterSubject);
            this.Controls.Add(this.txtEnterBack);
            this.Controls.Add(this.txtEnterFront);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeadingMainScreen);
            this.Name = "AddFlashCard";
            this.Text = "Add Flash Card";
            this.Load += new System.EventHandler(this.AddFlashCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HeadingMainScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEnterFront;
        private System.Windows.Forms.TextBox txtEnterBack;
        private System.Windows.Forms.TextBox txtEnterSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmCard;
    }
}

namespace SanjayComSciIA
{
    partial class ViewFlashCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFlashCards));
            this.HeadingMainScreen = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteCard = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnConfirmSearch = new System.Windows.Forms.Button();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnEditCard = new System.Windows.Forms.Button();
            this.lstFlashCards = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingMainScreen
            // 
            this.HeadingMainScreen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HeadingMainScreen.InitialImage = ((System.Drawing.Image)(resources.GetObject("HeadingMainScreen.InitialImage")));
            this.HeadingMainScreen.Location = new System.Drawing.Point(0, -1);
            this.HeadingMainScreen.Name = "HeadingMainScreen";
            this.HeadingMainScreen.Size = new System.Drawing.Size(629, 93);
            this.HeadingMainScreen.TabIndex = 3;
            this.HeadingMainScreen.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(189, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Viewing all Cards";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.Location = new System.Drawing.Point(502, 194);
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.Size = new System.Drawing.Size(97, 61);
            this.btnDeleteCard.TabIndex = 25;
            this.btnDeleteCard.Text = "Delete";
            this.btnDeleteCard.UseVisualStyleBackColor = true;
            this.btnDeleteCard.Click += new System.EventHandler(this.btnDeleteCard_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(46, 312);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(454, 20);
            this.txtSearchBar.TabIndex = 26;
            // 
            // btnConfirmSearch
            // 
            this.btnConfirmSearch.Location = new System.Drawing.Point(506, 307);
            this.btnConfirmSearch.Name = "btnConfirmSearch";
            this.btnConfirmSearch.Size = new System.Drawing.Size(78, 29);
            this.btnConfirmSearch.TabIndex = 27;
            this.btnConfirmSearch.Text = "Search";
            this.btnConfirmSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(77, 389);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(491, 30);
            this.btnAddCard.TabIndex = 28;
            this.btnAddCard.Text = "Add Card";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // btnEditCard
            // 
            this.btnEditCard.Location = new System.Drawing.Point(502, 120);
            this.btnEditCard.Name = "btnEditCard";
            this.btnEditCard.Size = new System.Drawing.Size(97, 68);
            this.btnEditCard.TabIndex = 24;
            this.btnEditCard.Text = "Edit";
            this.btnEditCard.UseVisualStyleBackColor = true;
            this.btnEditCard.Click += new System.EventHandler(this.btnEditCard_Click);
            // 
            // lstFlashCards
            // 
            this.lstFlashCards.FormattingEnabled = true;
            this.lstFlashCards.Location = new System.Drawing.Point(46, 120);
            this.lstFlashCards.Name = "lstFlashCards";
            this.lstFlashCards.Size = new System.Drawing.Size(450, 134);
            this.lstFlashCards.TabIndex = 29;
            // 
            // ViewFlashCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 464);
            this.Controls.Add(this.lstFlashCards);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.btnConfirmSearch);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnDeleteCard);
            this.Controls.Add(this.btnEditCard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeadingMainScreen);
            this.Name = "ViewFlashCards";
            this.Text = "View Flash Cards";
            this.Load += new System.EventHandler(this.ViewFlashCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeadingMainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HeadingMainScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteCard;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnConfirmSearch;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnEditCard;
        private System.Windows.Forms.ListBox lstFlashCards;
    }
}
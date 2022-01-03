namespace CardFlips
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardFaceButton = new System.Windows.Forms.Button();
            this.cardBackButton = new System.Windows.Forms.Button();
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardBackPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFaceButton
            // 
            this.cardFaceButton.Location = new System.Drawing.Point(87, 465);
            this.cardFaceButton.Name = "cardFaceButton";
            this.cardFaceButton.Size = new System.Drawing.Size(150, 99);
            this.cardFaceButton.TabIndex = 0;
            this.cardFaceButton.Text = "Show the Card Face";
            this.cardFaceButton.UseVisualStyleBackColor = true;
            this.cardFaceButton.Click += new System.EventHandler(this.cardFaceButton_Click);
            // 
            // cardBackButton
            // 
            this.cardBackButton.Location = new System.Drawing.Point(433, 465);
            this.cardBackButton.Name = "cardBackButton";
            this.cardBackButton.Size = new System.Drawing.Size(157, 99);
            this.cardBackButton.TabIndex = 1;
            this.cardBackButton.Text = "Show the Card Back";
            this.cardBackButton.UseVisualStyleBackColor = true;
            this.cardBackButton.Click += new System.EventHandler(this.cardBackButton_Click);
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cardFacePictureBox.Image")));
            this.cardFacePictureBox.Location = new System.Drawing.Point(62, 83);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(243, 350);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFacePictureBox.TabIndex = 2;
            this.cardFacePictureBox.TabStop = false;
            this.cardFacePictureBox.Visible = false;
            // 
            // cardBackPicture
            // 
            this.cardBackPicture.Image = ((System.Drawing.Image)(resources.GetObject("cardBackPicture.Image")));
            this.cardBackPicture.Location = new System.Drawing.Point(378, 83);
            this.cardBackPicture.Name = "cardBackPicture";
            this.cardBackPicture.Size = new System.Drawing.Size(257, 350);
            this.cardBackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBackPicture.TabIndex = 3;
            this.cardBackPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardBackPicture);
            this.Controls.Add(this.cardFacePictureBox);
            this.Controls.Add(this.cardBackButton);
            this.Controls.Add(this.cardFaceButton);
            this.Name = "Form1";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button cardFaceButton;
        private Button cardBackButton;
        private PictureBox cardFacePictureBox;
        private PictureBox cardBackPicture;
        private Button button1;
    }
}
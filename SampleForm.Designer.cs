namespace Toast_Sample
{
    partial class SampleForm
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
            this.SendToastButtonByText = new System.Windows.Forms.Button();
            this.SendToastButtonByImage = new System.Windows.Forms.Button();
            this.SendToastButtonByLogo = new System.Windows.Forms.Button();
            this.SendToastButtonByButton = new System.Windows.Forms.Button();
            this.SendToastButtonByHeroImage = new System.Windows.Forms.Button();
            this.SendToastButtonByTextBox = new System.Windows.Forms.Button();
            this.SendToastButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendToastButtonByText
            // 
            this.SendToastButtonByText.Location = new System.Drawing.Point(30, 30);
            this.SendToastButtonByText.Margin = new System.Windows.Forms.Padding(4);
            this.SendToastButtonByText.Name = "SendToastButtonByText";
            this.SendToastButtonByText.Size = new System.Drawing.Size(511, 90);
            this.SendToastButtonByText.TabIndex = 0;
            this.SendToastButtonByText.Text = "Send Toast By Text";
            this.SendToastButtonByText.UseVisualStyleBackColor = true;
            this.SendToastButtonByText.Click += new System.EventHandler(this.SendToastButtonByText_Click);
            // 
            // SendToastButtonByImage
            // 
            this.SendToastButtonByImage.Location = new System.Drawing.Point(30, 128);
            this.SendToastButtonByImage.Margin = new System.Windows.Forms.Padding(4);
            this.SendToastButtonByImage.Name = "SendToastButtonByImage";
            this.SendToastButtonByImage.Size = new System.Drawing.Size(511, 90);
            this.SendToastButtonByImage.TabIndex = 1;
            this.SendToastButtonByImage.Text = "Send Toast By Image";
            this.SendToastButtonByImage.UseVisualStyleBackColor = true;
            this.SendToastButtonByImage.Click += new System.EventHandler(this.SendToastButtonByImage_Click);
            // 
            // SendToastButtonByLogo
            // 
            this.SendToastButtonByLogo.Location = new System.Drawing.Point(30, 226);
            this.SendToastButtonByLogo.Margin = new System.Windows.Forms.Padding(4);
            this.SendToastButtonByLogo.Name = "SendToastButtonByLogo";
            this.SendToastButtonByLogo.Size = new System.Drawing.Size(511, 90);
            this.SendToastButtonByLogo.TabIndex = 2;
            this.SendToastButtonByLogo.Text = "Send Toast By Logo";
            this.SendToastButtonByLogo.UseVisualStyleBackColor = true;
            this.SendToastButtonByLogo.Click += new System.EventHandler(this.SendToastButtonByLogo_Click);
            // 
            // SendToastButtonByButton
            // 
            this.SendToastButtonByButton.Location = new System.Drawing.Point(30, 323);
            this.SendToastButtonByButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendToastButtonByButton.Name = "SendToastButtonByButton";
            this.SendToastButtonByButton.Size = new System.Drawing.Size(511, 90);
            this.SendToastButtonByButton.TabIndex = 3;
            this.SendToastButtonByButton.Text = "Send Toast By Button";
            this.SendToastButtonByButton.UseVisualStyleBackColor = true;
            this.SendToastButtonByButton.Click += new System.EventHandler(this.SendToastButtonByButton_Click);
            // 
            // SendToastButtonByHeroImage
            // 
            this.SendToastButtonByHeroImage.Location = new System.Drawing.Point(30, 421);
            this.SendToastButtonByHeroImage.Margin = new System.Windows.Forms.Padding(4);
            this.SendToastButtonByHeroImage.Name = "SendToastButtonByHeroImage";
            this.SendToastButtonByHeroImage.Size = new System.Drawing.Size(511, 90);
            this.SendToastButtonByHeroImage.TabIndex = 4;
            this.SendToastButtonByHeroImage.Text = "Send Toast By HeroImage";
            this.SendToastButtonByHeroImage.UseVisualStyleBackColor = true;
            this.SendToastButtonByHeroImage.Click += new System.EventHandler(this.SendToastButtonByHeroImage_Click);
            // 
            // SendToastButtonByTextBox
            // 
            this.SendToastButtonByTextBox.Location = new System.Drawing.Point(30, 519);
            this.SendToastButtonByTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SendToastButtonByTextBox.Name = "SendToastButtonByTextBox";
            this.SendToastButtonByTextBox.Size = new System.Drawing.Size(511, 90);
            this.SendToastButtonByTextBox.TabIndex = 5;
            this.SendToastButtonByTextBox.Text = "Send Toast By Text Box";
            this.SendToastButtonByTextBox.UseVisualStyleBackColor = true;
            this.SendToastButtonByTextBox.Click += new System.EventHandler(this.SendToastButtonByTextBox_Click);
            // 
            // SendToastButton
            // 
            this.SendToastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SendToastButton.Location = new System.Drawing.Point(30, 645);
            this.SendToastButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendToastButton.Name = "SendToastButton";
            this.SendToastButton.Size = new System.Drawing.Size(511, 90);
            this.SendToastButton.TabIndex = 6;
            this.SendToastButton.Text = "Send Toast Message";
            this.SendToastButton.UseVisualStyleBackColor = false;
            this.SendToastButton.Click += new System.EventHandler(this.SendToastButton_Click);
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 753);
            this.Controls.Add(this.SendToastButton);
            this.Controls.Add(this.SendToastButtonByTextBox);
            this.Controls.Add(this.SendToastButtonByHeroImage);
            this.Controls.Add(this.SendToastButtonByButton);
            this.Controls.Add(this.SendToastButtonByLogo);
            this.Controls.Add(this.SendToastButtonByImage);
            this.Controls.Add(this.SendToastButtonByText);
            this.Font = new System.Drawing.Font("IRANSans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button SendToastButtonByText;
        private Button SendToastButtonByImage;
        private Button SendToastButtonByLogo;
        private Button SendToastButtonByButton;
        private Button SendToastButtonByHeroImage;
        private Button SendToastButtonByTextBox;
        private Button SendToastButton;
    }
}
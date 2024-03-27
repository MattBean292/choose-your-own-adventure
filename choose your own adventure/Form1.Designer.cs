namespace choose_your_own_adventure
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
            this.chooseButton1 = new System.Windows.Forms.Button();
            this.chooseButton2 = new System.Windows.Forms.Button();
            this.readerLabel = new System.Windows.Forms.Label();
            this.choose1Label = new System.Windows.Forms.Label();
            this.choose2Label = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseButton1
            // 
            this.chooseButton1.Location = new System.Drawing.Point(283, 296);
            this.chooseButton1.Name = "chooseButton1";
            this.chooseButton1.Size = new System.Drawing.Size(75, 23);
            this.chooseButton1.TabIndex = 0;
            this.chooseButton1.Text = "button1";
            this.chooseButton1.UseVisualStyleBackColor = true;
            this.chooseButton1.Click += new System.EventHandler(this.chooseButton1_Click);
            // 
            // chooseButton2
            // 
            this.chooseButton2.Location = new System.Drawing.Point(449, 292);
            this.chooseButton2.Name = "chooseButton2";
            this.chooseButton2.Size = new System.Drawing.Size(75, 23);
            this.chooseButton2.TabIndex = 1;
            this.chooseButton2.Text = "button2";
            this.chooseButton2.UseVisualStyleBackColor = true;
            this.chooseButton2.Click += new System.EventHandler(this.chooseButton2_Click);
            // 
            // readerLabel
            // 
            this.readerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.readerLabel.Location = new System.Drawing.Point(175, 68);
            this.readerLabel.Name = "readerLabel";
            this.readerLabel.Size = new System.Drawing.Size(145, 65);
            this.readerLabel.TabIndex = 2;
            // 
            // choose1Label
            // 
            this.choose1Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.choose1Label.Location = new System.Drawing.Point(280, 262);
            this.choose1Label.Name = "choose1Label";
            this.choose1Label.Size = new System.Drawing.Size(78, 27);
            this.choose1Label.TabIndex = 3;
            // 
            // choose2Label
            // 
            this.choose2Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.choose2Label.Location = new System.Drawing.Point(446, 258);
            this.choose2Label.Name = "choose2Label";
            this.choose2Label.Size = new System.Drawing.Size(78, 31);
            this.choose2Label.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(607, 292);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::choose_your_own_adventure.Properties.Resources.Town;
            this.pictureBox.InitialImage = global::choose_your_own_adventure.Properties.Resources.Town;
            this.pictureBox.Location = new System.Drawing.Point(492, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(263, 231);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.choose2Label);
            this.Controls.Add(this.choose1Label);
            this.Controls.Add(this.readerLabel);
            this.Controls.Add(this.chooseButton2);
            this.Controls.Add(this.chooseButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseButton1;
        private System.Windows.Forms.Button chooseButton2;
        private System.Windows.Forms.Label readerLabel;
        private System.Windows.Forms.Label choose1Label;
        private System.Windows.Forms.Label choose2Label;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}


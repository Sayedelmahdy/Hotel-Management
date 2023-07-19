namespace Hotel_Manager
{
    partial class FoodMenu
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
            foodPanel = new System.Windows.Forms.Panel();
            dinnerQTY = new System.Windows.Forms.TextBox();
            lunchQTY = new System.Windows.Forms.TextBox();
            breakfastQTY = new System.Windows.Forms.TextBox();
            dinnerPicture = new System.Windows.Forms.PictureBox();
            lunchPicture = new System.Windows.Forms.PictureBox();
            breakfastPicture = new System.Windows.Forms.PictureBox();
            dinnerCheckBox = new System.Windows.Forms.CheckBox();
            lunchCheckBox = new System.Windows.Forms.CheckBox();
            breakfastCheckBox = new System.Windows.Forms.CheckBox();
            metroLabel1 = new System.Windows.Forms.Label();
            needPanel = new System.Windows.Forms.Panel();
            surpriseCheckBox = new System.Windows.Forms.CheckBox();
            towelsCheckBox = new System.Windows.Forms.CheckBox();
            cleaningCheckBox = new System.Windows.Forms.CheckBox();
            metroLabel2 = new System.Windows.Forms.Label();
            nextButton = new System.Windows.Forms.Button();
            foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).BeginInit();
            needPanel.SuspendLayout();
            SuspendLayout();
            // 
            // foodPanel
            // 
            foodPanel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            foodPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            foodPanel.Controls.Add(dinnerQTY);
            foodPanel.Controls.Add(lunchQTY);
            foodPanel.Controls.Add(breakfastQTY);
            foodPanel.Controls.Add(dinnerPicture);
            foodPanel.Controls.Add(lunchPicture);
            foodPanel.Controls.Add(breakfastPicture);
            foodPanel.Controls.Add(dinnerCheckBox);
            foodPanel.Controls.Add(lunchCheckBox);
            foodPanel.Controls.Add(breakfastCheckBox);
            foodPanel.Controls.Add(metroLabel1);
            foodPanel.Location = new System.Drawing.Point(16, 73);
            foodPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new System.Drawing.Size(387, 423);
            foodPanel.TabIndex = 5;
            // 
            // dinnerQTY
            // 
            dinnerQTY.BackColor = System.Drawing.Color.White;
            dinnerQTY.Enabled = false;
            dinnerQTY.Location = new System.Drawing.Point(16, 377);
            dinnerQTY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dinnerQTY.Name = "dinnerQTY";
            dinnerQTY.Size = new System.Drawing.Size(150, 23);
            dinnerQTY.TabIndex = 40;
            // 
            // lunchQTY
            // 
            lunchQTY.BackColor = System.Drawing.Color.White;
            lunchQTY.Enabled = false;
            lunchQTY.Location = new System.Drawing.Point(201, 209);
            lunchQTY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lunchQTY.Name = "lunchQTY";
            lunchQTY.Size = new System.Drawing.Size(167, 23);
            lunchQTY.TabIndex = 39;
            // 
            // breakfastQTY
            // 
            breakfastQTY.BackColor = System.Drawing.Color.White;
            breakfastQTY.Enabled = false;
            breakfastQTY.Location = new System.Drawing.Point(16, 209);
            breakfastQTY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            breakfastQTY.Name = "breakfastQTY";
            breakfastQTY.Size = new System.Drawing.Size(150, 23);
            breakfastQTY.TabIndex = 38;
            // 
            // dinnerPicture
            // 
            dinnerPicture.Location = new System.Drawing.Point(16, 261);
            dinnerPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dinnerPicture.Name = "dinnerPicture";
            dinnerPicture.Size = new System.Drawing.Size(150, 87);
            dinnerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            dinnerPicture.TabIndex = 8;
            dinnerPicture.TabStop = false;
            // 
            // lunchPicture
            // 
            lunchPicture.Location = new System.Drawing.Point(201, 63);
            lunchPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lunchPicture.Name = "lunchPicture";
            lunchPicture.Size = new System.Drawing.Size(168, 106);
            lunchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            lunchPicture.TabIndex = 7;
            lunchPicture.TabStop = false;
            // 
            // breakfastPicture
            // 
            breakfastPicture.Location = new System.Drawing.Point(16, 63);
            breakfastPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            breakfastPicture.Name = "breakfastPicture";
            breakfastPicture.Size = new System.Drawing.Size(150, 106);
            breakfastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            breakfastPicture.TabIndex = 6;
            breakfastPicture.TabStop = false;
            // 
            // dinnerCheckBox
            // 
            dinnerCheckBox.AutoSize = true;
            dinnerCheckBox.BackColor = System.Drawing.Color.Transparent;
            dinnerCheckBox.Location = new System.Drawing.Point(16, 354);
            dinnerCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dinnerCheckBox.Name = "dinnerCheckBox";
            dinnerCheckBox.Size = new System.Drawing.Size(96, 19);
            dinnerCheckBox.TabIndex = 5;
            dinnerCheckBox.Text = "Dinner   ($15)";
            dinnerCheckBox.UseVisualStyleBackColor = false;
            dinnerCheckBox.CheckedChanged += dinnerCheckBox_CheckedChanged;
            // 
            // lunchCheckBox
            // 
            lunchCheckBox.AutoSize = true;
            lunchCheckBox.BackColor = System.Drawing.Color.Transparent;
            lunchCheckBox.Location = new System.Drawing.Point(201, 180);
            lunchCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lunchCheckBox.Name = "lunchCheckBox";
            lunchCheckBox.Size = new System.Drawing.Size(94, 19);
            lunchCheckBox.TabIndex = 4;
            lunchCheckBox.Text = "Lunch   ($15)";
            lunchCheckBox.UseVisualStyleBackColor = false;
            lunchCheckBox.CheckedChanged += lunchCheckBox_CheckedChanged;
            // 
            // breakfastCheckBox
            // 
            breakfastCheckBox.AutoSize = true;
            breakfastCheckBox.BackColor = System.Drawing.Color.Transparent;
            breakfastCheckBox.Location = new System.Drawing.Point(16, 180);
            breakfastCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            breakfastCheckBox.Name = "breakfastCheckBox";
            breakfastCheckBox.Size = new System.Drawing.Size(105, 19);
            breakfastCheckBox.TabIndex = 3;
            breakfastCheckBox.Text = "Break Fast  ($7)";
            breakfastCheckBox.UseVisualStyleBackColor = false;
            breakfastCheckBox.CheckedChanged += breakfastCheckBox_CheckedChanged;
            // 
            // metroLabel1
            // 
            metroLabel1.BackColor = System.Drawing.Color.Transparent;
            metroLabel1.Location = new System.Drawing.Point(4, 12);
            metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new System.Drawing.Size(202, 32);
            metroLabel1.TabIndex = 2;
            metroLabel1.Text = "Food Selection";
            // 
            // needPanel
            // 
            needPanel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            needPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            needPanel.Controls.Add(surpriseCheckBox);
            needPanel.Controls.Add(towelsCheckBox);
            needPanel.Controls.Add(cleaningCheckBox);
            needPanel.Controls.Add(metroLabel2);
            needPanel.Location = new System.Drawing.Point(414, 73);
            needPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            needPanel.Name = "needPanel";
            needPanel.Size = new System.Drawing.Size(191, 376);
            needPanel.TabIndex = 6;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.AutoSize = true;
            surpriseCheckBox.BackColor = System.Drawing.Color.Transparent;
            surpriseCheckBox.Location = new System.Drawing.Point(21, 148);
            surpriseCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new System.Drawing.Size(116, 19);
            surpriseCheckBox.TabIndex = 44;
            surpriseCheckBox.Text = "Sweetest surprise";
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // towelsCheckBox
            // 
            towelsCheckBox.AutoSize = true;
            towelsCheckBox.BackColor = System.Drawing.Color.Transparent;
            towelsCheckBox.Location = new System.Drawing.Point(21, 105);
            towelsCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            towelsCheckBox.Name = "towelsCheckBox";
            towelsCheckBox.Size = new System.Drawing.Size(61, 19);
            towelsCheckBox.TabIndex = 42;
            towelsCheckBox.Text = "Towels";
            towelsCheckBox.UseVisualStyleBackColor = false;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.AutoSize = true;
            cleaningCheckBox.BackColor = System.Drawing.Color.Transparent;
            cleaningCheckBox.Location = new System.Drawing.Point(21, 63);
            cleaningCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new System.Drawing.Size(73, 19);
            cleaningCheckBox.TabIndex = 41;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // metroLabel2
            // 
            metroLabel2.BackColor = System.Drawing.Color.Transparent;
            metroLabel2.Location = new System.Drawing.Point(4, 12);
            metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new System.Drawing.Size(141, 32);
            metroLabel2.TabIndex = 41;
            metroLabel2.Text = "Special needs";
            // 
            // nextButton
            // 
            nextButton.Location = new System.Drawing.Point(414, 457);
            nextButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nextButton.Name = "nextButton";
            nextButton.Size = new System.Drawing.Size(191, 39);
            nextButton.TabIndex = 45;
            nextButton.Text = "Next";
            nextButton.Click += nextButton_Click;
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(623, 510);
            Controls.Add(nextButton);
            Controls.Add(needPanel);
            Controls.Add(foodPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FoodMenu";
            ShowInTaskbar = false;
            Text = "Food and Menu";
            Load += FoodMenu_Load;
            foodPanel.ResumeLayout(false);
            foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).EndInit();
            needPanel.ResumeLayout(false);
            needPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel foodPanel;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.PictureBox dinnerPicture;
        private System.Windows.Forms.PictureBox lunchPicture;
        private System.Windows.Forms.PictureBox breakfastPicture;
        public System.Windows.Forms.TextBox breakfastQTY;
        public System.Windows.Forms.TextBox dinnerQTY;
        public System.Windows.Forms.TextBox lunchQTY;
        private System.Windows.Forms.Label metroLabel2;
        public System.Windows.Forms.CheckBox dinnerCheckBox;
        public System.Windows.Forms.CheckBox lunchCheckBox;
        public System.Windows.Forms.CheckBox breakfastCheckBox;
        public System.Windows.Forms.CheckBox surpriseCheckBox;
        public System.Windows.Forms.CheckBox towelsCheckBox;
        public System.Windows.Forms.CheckBox cleaningCheckBox;
        public System.Windows.Forms.Panel needPanel;
        public System.Windows.Forms.Button nextButton;
    }
}

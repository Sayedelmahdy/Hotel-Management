namespace Hotel_Manager
{
    partial class Kitchen
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
            metroTabControl1 = new System.Windows.Forms.TabControl();
            TodoTabPage = new System.Windows.Forms.TabPage();
            onTheLineLabel = new System.Windows.Forms.Label();
            updateButton = new System.Windows.Forms.Button();
            roomNLabel = new System.Windows.Forms.Label();
            floorNLabel = new System.Windows.Forms.Label();
            roomTypeLabel = new System.Windows.Forms.Label();
            Todo = new System.Windows.Forms.GroupBox();
            dinnerQTLabel = new System.Windows.Forms.Label();
            lunchQTLabel = new System.Windows.Forms.Label();
            breakfastQTLabel = new System.Windows.Forms.Label();
            breakfastTextBox = new System.Windows.Forms.TextBox();
            foodSelectionButton = new System.Windows.Forms.Button();
            supplyCheckBox = new System.Windows.Forms.CheckBox();
            lunchTextBox = new System.Windows.Forms.TextBox();
            towelCheckBox = new System.Windows.Forms.CheckBox();
            dinnerTextBox = new System.Windows.Forms.TextBox();
            cleaningCheckBox = new System.Windows.Forms.CheckBox();
            surpriseCheckBox = new System.Windows.Forms.CheckBox();
            floorNTextBox = new System.Windows.Forms.TextBox();
            roomNTextBox = new System.Windows.Forms.TextBox();
            roomTypeTextBox = new System.Windows.Forms.TextBox();
            phoneNTextBox = new System.Windows.Forms.TextBox();
            queueListBox = new System.Windows.Forms.ListBox();
            nameLabel = new System.Windows.Forms.Label();
            phoneNLabel = new System.Windows.Forms.Label();
            firstNameTextBox = new System.Windows.Forms.TextBox();
            lastNameTextBox = new System.Windows.Forms.TextBox();
            overviewTabPage = new System.Windows.Forms.TabPage();
            overviewDataGridView = new System.Windows.Forms.DataGridView();
            LogOut = new System.Windows.Forms.Button();
            metroTabControl1.SuspendLayout();
            TodoTabPage.SuspendLayout();
            Todo.SuspendLayout();
            overviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overviewDataGridView).BeginInit();
            SuspendLayout();
            // 
            // metroTabControl1
            // 
            metroTabControl1.Controls.Add(TodoTabPage);
            metroTabControl1.Controls.Add(overviewTabPage);
            metroTabControl1.Location = new System.Drawing.Point(13, 73);
            metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            metroTabControl1.Name = "metroTabControl1";
            metroTabControl1.SelectedIndex = 1;
            metroTabControl1.Size = new System.Drawing.Size(1147, 554);
            metroTabControl1.TabIndex = 0;
            // 
            // TodoTabPage
            // 
            TodoTabPage.Controls.Add(onTheLineLabel);
            TodoTabPage.Controls.Add(updateButton);
            TodoTabPage.Controls.Add(roomNLabel);
            TodoTabPage.Controls.Add(floorNLabel);
            TodoTabPage.Controls.Add(roomTypeLabel);
            TodoTabPage.Controls.Add(Todo);
            TodoTabPage.Controls.Add(floorNTextBox);
            TodoTabPage.Controls.Add(roomNTextBox);
            TodoTabPage.Controls.Add(roomTypeTextBox);
            TodoTabPage.Controls.Add(phoneNTextBox);
            TodoTabPage.Controls.Add(queueListBox);
            TodoTabPage.Controls.Add(nameLabel);
            TodoTabPage.Controls.Add(phoneNLabel);
            TodoTabPage.Controls.Add(firstNameTextBox);
            TodoTabPage.Controls.Add(lastNameTextBox);
            TodoTabPage.Location = new System.Drawing.Point(4, 24);
            TodoTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TodoTabPage.Name = "TodoTabPage";
            TodoTabPage.Size = new System.Drawing.Size(1139, 526);
            TodoTabPage.TabIndex = 0;
            TodoTabPage.Text = "TODO*";
            // 
            // onTheLineLabel
            // 
            onTheLineLabel.AutoSize = true;
            onTheLineLabel.BackColor = System.Drawing.Color.Transparent;
            onTheLineLabel.Location = new System.Drawing.Point(825, 35);
            onTheLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            onTheLineLabel.Name = "onTheLineLabel";
            onTheLineLabel.Size = new System.Drawing.Size(65, 15);
            onTheLineLabel.TabIndex = 61;
            onTheLineLabel.Text = "On the line";
            // 
            // updateButton
            // 
            updateButton.Location = new System.Drawing.Point(825, 442);
            updateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(261, 36);
            updateButton.TabIndex = 60;
            updateButton.Text = "Update changes";
            updateButton.Click += updateButton_Click;
            // 
            // roomNLabel
            // 
            roomNLabel.AutoSize = true;
            roomNLabel.BackColor = System.Drawing.Color.Transparent;
            roomNLabel.Location = new System.Drawing.Point(34, 294);
            roomNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomNLabel.Name = "roomNLabel";
            roomNLabel.Size = new System.Drawing.Size(49, 15);
            roomNLabel.TabIndex = 58;
            roomNLabel.Text = "Room #";
            // 
            // floorNLabel
            // 
            floorNLabel.AutoSize = true;
            floorNLabel.BackColor = System.Drawing.Color.Transparent;
            floorNLabel.Location = new System.Drawing.Point(223, 223);
            floorNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            floorNLabel.Name = "floorNLabel";
            floorNLabel.Size = new System.Drawing.Size(44, 15);
            floorNLabel.TabIndex = 57;
            floorNLabel.Text = "Floor #";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.BackColor = System.Drawing.Color.Transparent;
            roomTypeLabel.Location = new System.Drawing.Point(34, 223);
            roomTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new System.Drawing.Size(65, 15);
            roomTypeLabel.TabIndex = 56;
            roomTypeLabel.Text = "Room type";
            // 
            // Todo
            // 
            Todo.BackColor = System.Drawing.Color.Transparent;
            Todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Todo.Controls.Add(dinnerQTLabel);
            Todo.Controls.Add(lunchQTLabel);
            Todo.Controls.Add(breakfastQTLabel);
            Todo.Controls.Add(breakfastTextBox);
            Todo.Controls.Add(foodSelectionButton);
            Todo.Controls.Add(supplyCheckBox);
            Todo.Controls.Add(lunchTextBox);
            Todo.Controls.Add(towelCheckBox);
            Todo.Controls.Add(dinnerTextBox);
            Todo.Controls.Add(cleaningCheckBox);
            Todo.Controls.Add(surpriseCheckBox);
            Todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Todo.Location = new System.Drawing.Point(411, 52);
            Todo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Todo.Name = "Todo";
            Todo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Todo.Size = new System.Drawing.Size(407, 373);
            Todo.TabIndex = 55;
            Todo.TabStop = false;
            Todo.Text = "Todo";
            // 
            // dinnerQTLabel
            // 
            dinnerQTLabel.AutoSize = true;
            dinnerQTLabel.BackColor = System.Drawing.Color.Transparent;
            dinnerQTLabel.Location = new System.Drawing.Point(20, 100);
            dinnerQTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dinnerQTLabel.Name = "dinnerQTLabel";
            dinnerQTLabel.Size = new System.Drawing.Size(74, 15);
            dinnerQTLabel.TabIndex = 63;
            dinnerQTLabel.Text = "Dinner [QTY]";
            // 
            // lunchQTLabel
            // 
            lunchQTLabel.AutoSize = true;
            lunchQTLabel.BackColor = System.Drawing.Color.Transparent;
            lunchQTLabel.Location = new System.Drawing.Point(209, 28);
            lunchQTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lunchQTLabel.Name = "lunchQTLabel";
            lunchQTLabel.Size = new System.Drawing.Size(72, 15);
            lunchQTLabel.TabIndex = 62;
            lunchQTLabel.Text = "Lunch [QTY]";
            // 
            // breakfastQTLabel
            // 
            breakfastQTLabel.AutoSize = true;
            breakfastQTLabel.BackColor = System.Drawing.Color.Transparent;
            breakfastQTLabel.Location = new System.Drawing.Point(20, 28);
            breakfastQTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            breakfastQTLabel.Name = "breakfastQTLabel";
            breakfastQTLabel.Size = new System.Drawing.Size(87, 15);
            breakfastQTLabel.TabIndex = 61;
            breakfastQTLabel.Text = "Breakfast [QTY]";
            // 
            // breakfastTextBox
            // 
            breakfastTextBox.BackColor = System.Drawing.Color.White;
            breakfastTextBox.Enabled = false;
            breakfastTextBox.Location = new System.Drawing.Point(20, 53);
            breakfastTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            breakfastTextBox.Name = "breakfastTextBox";
            breakfastTextBox.Size = new System.Drawing.Size(180, 23);
            breakfastTextBox.TabIndex = 47;
            // 
            // foodSelectionButton
            // 
            foodSelectionButton.Location = new System.Drawing.Point(20, 318);
            foodSelectionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            foodSelectionButton.Name = "foodSelectionButton";
            foodSelectionButton.Size = new System.Drawing.Size(370, 36);
            foodSelectionButton.TabIndex = 59;
            foodSelectionButton.Text = "Change food selection?";
            foodSelectionButton.Click += foodSelectionButton_Click;
            // 
            // supplyCheckBox
            // 
            supplyCheckBox.AutoSize = true;
            supplyCheckBox.BackColor = System.Drawing.Color.Transparent;
            supplyCheckBox.Location = new System.Drawing.Point(147, 275);
            supplyCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            supplyCheckBox.Name = "supplyCheckBox";
            supplyCheckBox.Size = new System.Drawing.Size(136, 19);
            supplyCheckBox.TabIndex = 42;
            supplyCheckBox.Text = "Food/Supply status ?";
            supplyCheckBox.UseVisualStyleBackColor = false;
            supplyCheckBox.CheckedChanged += supplyCheckBox_CheckedChanged;
            // 
            // lunchTextBox
            // 
            lunchTextBox.BackColor = System.Drawing.Color.White;
            lunchTextBox.Enabled = false;
            lunchTextBox.Location = new System.Drawing.Point(209, 53);
            lunchTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lunchTextBox.Name = "lunchTextBox";
            lunchTextBox.Size = new System.Drawing.Size(180, 23);
            lunchTextBox.TabIndex = 48;
            // 
            // towelCheckBox
            // 
            towelCheckBox.BackColor = System.Drawing.Color.Transparent;
            towelCheckBox.Enabled = false;
            towelCheckBox.Location = new System.Drawing.Point(158, 196);
            towelCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            towelCheckBox.Name = "towelCheckBox";
            towelCheckBox.Size = new System.Drawing.Size(90, 33);
            towelCheckBox.TabIndex = 52;
            towelCheckBox.Text = "Towels";
            towelCheckBox.UseVisualStyleBackColor = false;
            // 
            // dinnerTextBox
            // 
            dinnerTextBox.BackColor = System.Drawing.Color.White;
            dinnerTextBox.Enabled = false;
            dinnerTextBox.Location = new System.Drawing.Point(20, 126);
            dinnerTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dinnerTextBox.Name = "dinnerTextBox";
            dinnerTextBox.Size = new System.Drawing.Size(369, 23);
            dinnerTextBox.TabIndex = 49;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.BackColor = System.Drawing.Color.Transparent;
            cleaningCheckBox.Enabled = false;
            cleaningCheckBox.Location = new System.Drawing.Point(26, 196);
            cleaningCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new System.Drawing.Size(90, 33);
            cleaningCheckBox.TabIndex = 51;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.BackColor = System.Drawing.Color.Transparent;
            surpriseCheckBox.Enabled = false;
            surpriseCheckBox.Location = new System.Drawing.Point(254, 197);
            surpriseCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new System.Drawing.Size(141, 32);
            surpriseCheckBox.TabIndex = 50;
            surpriseCheckBox.Text = "Sweetest Surprise";
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // floorNTextBox
            // 
            floorNTextBox.BackColor = System.Drawing.Color.White;
            floorNTextBox.Enabled = false;
            floorNTextBox.Location = new System.Drawing.Point(222, 248);
            floorNTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            floorNTextBox.Name = "floorNTextBox";
            floorNTextBox.Size = new System.Drawing.Size(180, 23);
            floorNTextBox.TabIndex = 46;
            // 
            // roomNTextBox
            // 
            roomNTextBox.BackColor = System.Drawing.Color.White;
            roomNTextBox.Enabled = false;
            roomNTextBox.Location = new System.Drawing.Point(36, 320);
            roomNTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            roomNTextBox.Name = "roomNTextBox";
            roomNTextBox.Size = new System.Drawing.Size(368, 23);
            roomNTextBox.TabIndex = 45;
            // 
            // roomTypeTextBox
            // 
            roomTypeTextBox.BackColor = System.Drawing.Color.White;
            roomTypeTextBox.Enabled = false;
            roomTypeTextBox.Location = new System.Drawing.Point(34, 248);
            roomTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            roomTypeTextBox.Name = "roomTypeTextBox";
            roomTypeTextBox.Size = new System.Drawing.Size(180, 23);
            roomTypeTextBox.TabIndex = 44;
            // 
            // phoneNTextBox
            // 
            phoneNTextBox.BackColor = System.Drawing.Color.White;
            phoneNTextBox.Enabled = false;
            phoneNTextBox.Location = new System.Drawing.Point(36, 178);
            phoneNTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            phoneNTextBox.Name = "phoneNTextBox";
            phoneNTextBox.Size = new System.Drawing.Size(368, 23);
            phoneNTextBox.TabIndex = 43;
            // 
            // queueListBox
            // 
            queueListBox.FormattingEnabled = true;
            queueListBox.ItemHeight = 15;
            queueListBox.Location = new System.Drawing.Point(825, 60);
            queueListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            queueListBox.Name = "queueListBox";
            queueListBox.Size = new System.Drawing.Size(261, 364);
            queueListBox.TabIndex = 40;
            queueListBox.SelectedIndexChanged += queueListBox_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Location = new System.Drawing.Point(34, 80);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 15);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name";
            // 
            // phoneNLabel
            // 
            phoneNLabel.AutoSize = true;
            phoneNLabel.BackColor = System.Drawing.Color.Transparent;
            phoneNLabel.Location = new System.Drawing.Point(35, 152);
            phoneNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneNLabel.Name = "phoneNLabel";
            phoneNLabel.Size = new System.Drawing.Size(86, 15);
            phoneNLabel.TabIndex = 30;
            phoneNLabel.Text = "Phone number";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = System.Drawing.Color.White;
            firstNameTextBox.Enabled = false;
            firstNameTextBox.Location = new System.Drawing.Point(35, 105);
            firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new System.Drawing.Size(180, 23);
            firstNameTextBox.TabIndex = 21;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = System.Drawing.Color.White;
            lastNameTextBox.Enabled = false;
            lastNameTextBox.Location = new System.Drawing.Point(223, 105);
            lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new System.Drawing.Size(180, 23);
            lastNameTextBox.TabIndex = 22;
            // 
            // overviewTabPage
            // 
            overviewTabPage.Controls.Add(overviewDataGridView);
            overviewTabPage.Location = new System.Drawing.Point(4, 24);
            overviewTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            overviewTabPage.Name = "overviewTabPage";
            overviewTabPage.Size = new System.Drawing.Size(1139, 526);
            overviewTabPage.TabIndex = 1;
            overviewTabPage.Text = "Overview";
            // 
            // overviewDataGridView
            // 
            overviewDataGridView.AllowUserToAddRows = false;
            overviewDataGridView.AllowUserToDeleteRows = false;
            overviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            overviewDataGridView.Location = new System.Drawing.Point(0, 23);
            overviewDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            overviewDataGridView.Name = "overviewDataGridView";
            overviewDataGridView.ReadOnly = true;
            overviewDataGridView.Size = new System.Drawing.Size(1138, 395);
            overviewDataGridView.TabIndex = 2;
            // 
            // LogOut
            // 
            LogOut.BackColor = System.Drawing.Color.Red;
            LogOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LogOut.Location = new System.Drawing.Point(991, 12);
            LogOut.Name = "LogOut";
            LogOut.Size = new System.Drawing.Size(162, 60);
            LogOut.TabIndex = 2;
            LogOut.Text = "Log out";
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // Kitchen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1167, 635);
            Controls.Add(LogOut);
            Controls.Add(metroTabControl1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Kitchen";
            Text = "Room Service";
            FormClosing += kitchen_FormClosing;
            Load += kitchen_Load;
            metroTabControl1.ResumeLayout(false);
            TodoTabPage.ResumeLayout(false);
            TodoTabPage.PerformLayout();
            Todo.ResumeLayout(false);
            Todo.PerformLayout();
            overviewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)overviewDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl metroTabControl1;
        private System.Windows.Forms.TabPage TodoTabPage;
        private System.Windows.Forms.TabPage overviewTabPage;
        private System.Windows.Forms.DataGridView overviewDataGridView;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneNLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ListBox queueListBox;
        private System.Windows.Forms.TextBox phoneNTextBox;
        private System.Windows.Forms.CheckBox supplyCheckBox;
        private System.Windows.Forms.TextBox floorNTextBox;
        private System.Windows.Forms.TextBox roomNTextBox;
        private System.Windows.Forms.TextBox roomTypeTextBox;
        private System.Windows.Forms.CheckBox towelCheckBox;
        private System.Windows.Forms.CheckBox cleaningCheckBox;
        private System.Windows.Forms.CheckBox surpriseCheckBox;
        private System.Windows.Forms.TextBox dinnerTextBox;
        private System.Windows.Forms.TextBox lunchTextBox;
        private System.Windows.Forms.TextBox breakfastTextBox;
        private System.Windows.Forms.GroupBox Todo;
        private System.Windows.Forms.Label roomNLabel;
        private System.Windows.Forms.Label floorNLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Button foodSelectionButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label dinnerQTLabel;
        private System.Windows.Forms.Label lunchQTLabel;
        private System.Windows.Forms.Label breakfastQTLabel;
        private System.Windows.Forms.Label onTheLineLabel;
        private System.Windows.Forms.Button LogOut;
    }
}

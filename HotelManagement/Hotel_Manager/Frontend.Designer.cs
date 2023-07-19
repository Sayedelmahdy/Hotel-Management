namespace Hotel_Manager
{
    partial class Frontend
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
            resPanel = new System.Windows.Forms.TabControl();
            reservationPage = new System.Windows.Forms.TabPage();
            rightMPanel = new System.Windows.Forms.Panel();
            resEditButton = new System.Windows.Forms.ComboBox();
            newButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            editButton = new System.Windows.Forms.Button();
            updateButton = new System.Windows.Forms.Button();
            middlePanel = new System.Windows.Forms.Panel();
            smsCheckBox = new System.Windows.Forms.CheckBox();
            foodSupplyCheckBox = new System.Windows.Forms.CheckBox();
            checkinCheckBox = new System.Windows.Forms.CheckBox();
            foodMenuButton = new System.Windows.Forms.Button();
            qtGuestComboBox = new System.Windows.Forms.ComboBox();
            finalizeButton = new System.Windows.Forms.Button();
            metroLabel12 = new System.Windows.Forms.Label();
            submitButton = new System.Windows.Forms.Button();
            depDatePicker = new System.Windows.Forms.DateTimePicker();
            roomNComboBox = new System.Windows.Forms.ComboBox();
            floorComboBox = new System.Windows.Forms.ComboBox();
            entryDatePicker = new System.Windows.Forms.DateTimePicker();
            entryLabel = new System.Windows.Forms.Label();
            roomTypeComboBox = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            choiceLabel = new System.Windows.Forms.Label();
            leftMPanel = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            emailTextBox = new System.Windows.Forms.TextBox();
            yearTextBox = new System.Windows.Forms.TextBox();
            monthComboBox = new System.Windows.Forms.ComboBox();
            genderComboBox = new System.Windows.Forms.ComboBox();
            birthdayLabel = new System.Windows.Forms.Label();
            dayComboBox = new System.Windows.Forms.ComboBox();
            phoneNumberLabel = new System.Windows.Forms.Label();
            firstNameTextBox = new System.Windows.Forms.TextBox();
            genderLabel = new System.Windows.Forms.Label();
            zipComboBox = new System.Windows.Forms.TextBox();
            phoneNumberTextBox = new System.Windows.Forms.TextBox();
            stateComboBox = new System.Windows.Forms.ComboBox();
            lastNameTextBox = new System.Windows.Forms.TextBox();
            cityTextBox = new System.Windows.Forms.TextBox();
            metroLabel6 = new System.Windows.Forms.Label();
            aptTextBox = new System.Windows.Forms.TextBox();
            addLabel = new System.Windows.Forms.TextBox();
            searchPage = new System.Windows.Forms.TabPage();
            SearchError = new System.Windows.Forms.Label();
            searchDataGridView = new System.Windows.Forms.DataGridView();
            searchButton = new System.Windows.Forms.Button();
            searchTextBox = new System.Windows.Forms.TextBox();
            metroTabPage2 = new System.Windows.Forms.TabPage();
            resTotalDataGridView = new System.Windows.Forms.DataGridView();
            roomPage = new System.Windows.Forms.TabPage();
            metroLabel13 = new System.Windows.Forms.Label();
            metroLabel11 = new System.Windows.Forms.Label();
            reservedLabel = new System.Windows.Forms.Label();
            roomReservedListBox = new System.Windows.Forms.ListBox();
            roomOccupiedListBox = new System.Windows.Forms.ListBox();
            occupiedLabel = new System.Windows.Forms.Label();
            LogOut = new System.Windows.Forms.Button();
            resPanel.SuspendLayout();
            reservationPage.SuspendLayout();
            rightMPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            leftMPanel.SuspendLayout();
            searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).BeginInit();
            roomPage.SuspendLayout();
            SuspendLayout();
            // 
            // resPanel
            // 
            resPanel.Controls.Add(reservationPage);
            resPanel.Controls.Add(searchPage);
            resPanel.Controls.Add(metroTabPage2);
            resPanel.Controls.Add(roomPage);
            resPanel.Location = new System.Drawing.Point(10, 68);
            resPanel.Margin = new System.Windows.Forms.Padding(4);
            resPanel.Name = "resPanel";
            resPanel.SelectedIndex = 0;
            resPanel.Size = new System.Drawing.Size(1148, 556);
            resPanel.TabIndex = 0;
            // 
            // reservationPage
            // 
            reservationPage.Controls.Add(rightMPanel);
            reservationPage.Controls.Add(middlePanel);
            reservationPage.Controls.Add(leftMPanel);
            reservationPage.Location = new System.Drawing.Point(4, 24);
            reservationPage.Margin = new System.Windows.Forms.Padding(4);
            reservationPage.Name = "reservationPage";
            reservationPage.Size = new System.Drawing.Size(1140, 528);
            reservationPage.TabIndex = 0;
            reservationPage.Text = "Reservation";
            // 
            // rightMPanel
            // 
            rightMPanel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            rightMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rightMPanel.Controls.Add(resEditButton);
            rightMPanel.Controls.Add(newButton);
            rightMPanel.Controls.Add(deleteButton);
            rightMPanel.Controls.Add(editButton);
            rightMPanel.Controls.Add(updateButton);
            rightMPanel.Location = new System.Drawing.Point(826, 16);
            rightMPanel.Margin = new System.Windows.Forms.Padding(4);
            rightMPanel.Name = "rightMPanel";
            rightMPanel.Size = new System.Drawing.Size(309, 486);
            rightMPanel.TabIndex = 34;
            // 
            // resEditButton
            // 
            resEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resEditButton.ForeColor = System.Drawing.Color.Green;
            resEditButton.FormattingEnabled = true;
            resEditButton.ItemHeight = 15;
            resEditButton.Items.AddRange(new object[] { "[ID]    [NAME]    [PHONE NUMBER]" });
            resEditButton.Location = new System.Drawing.Point(11, 35);
            resEditButton.Margin = new System.Windows.Forms.Padding(4);
            resEditButton.Name = "resEditButton";
            resEditButton.Size = new System.Drawing.Size(294, 23);
            resEditButton.TabIndex = 20;
            resEditButton.Visible = false;
            resEditButton.SelectedIndexChanged += resEditButton_SelectedIndexChanged;
            // 
            // newButton
            // 
            newButton.Location = new System.Drawing.Point(11, 433);
            newButton.Margin = new System.Windows.Forms.Padding(4);
            newButton.Name = "newButton";
            newButton.Size = new System.Drawing.Size(286, 37);
            newButton.TabIndex = 22;
            newButton.Text = "New reservation";
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(11, 332);
            deleteButton.Margin = new System.Windows.Forms.Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(286, 39);
            deleteButton.TabIndex = 23;
            deleteButton.Text = "Delete";
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new System.Drawing.Point(11, 386);
            editButton.Margin = new System.Windows.Forms.Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new System.Drawing.Size(286, 37);
            editButton.TabIndex = 18;
            editButton.Text = "Edit existing Reservation";
            editButton.Click += editButton_Click;
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Location = new System.Drawing.Point(11, 283);
            updateButton.Margin = new System.Windows.Forms.Padding(4);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(286, 39);
            updateButton.TabIndex = 19;
            updateButton.Text = "Update";
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // middlePanel
            // 
            middlePanel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            middlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            middlePanel.Controls.Add(smsCheckBox);
            middlePanel.Controls.Add(foodSupplyCheckBox);
            middlePanel.Controls.Add(checkinCheckBox);
            middlePanel.Controls.Add(foodMenuButton);
            middlePanel.Controls.Add(qtGuestComboBox);
            middlePanel.Controls.Add(finalizeButton);
            middlePanel.Controls.Add(metroLabel12);
            middlePanel.Controls.Add(submitButton);
            middlePanel.Controls.Add(depDatePicker);
            middlePanel.Controls.Add(roomNComboBox);
            middlePanel.Controls.Add(floorComboBox);
            middlePanel.Controls.Add(entryDatePicker);
            middlePanel.Controls.Add(entryLabel);
            middlePanel.Controls.Add(roomTypeComboBox);
            middlePanel.Controls.Add(label8);
            middlePanel.Controls.Add(label7);
            middlePanel.Controls.Add(label6);
            middlePanel.Controls.Add(choiceLabel);
            middlePanel.Location = new System.Drawing.Point(414, 16);
            middlePanel.Margin = new System.Windows.Forms.Padding(4);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new System.Drawing.Size(402, 486);
            middlePanel.TabIndex = 16;
            // 
            // smsCheckBox
            // 
            smsCheckBox.AutoSize = true;
            smsCheckBox.BackColor = System.Drawing.Color.Transparent;
            smsCheckBox.Location = new System.Drawing.Point(122, 336);
            smsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            smsCheckBox.Name = "smsCheckBox";
            smsCheckBox.Size = new System.Drawing.Size(81, 19);
            smsCheckBox.TabIndex = 35;
            smsCheckBox.Text = "Send sms?";
            smsCheckBox.UseVisualStyleBackColor = false;
            // 
            // foodSupplyCheckBox
            // 
            foodSupplyCheckBox.AutoSize = true;
            foodSupplyCheckBox.BackColor = System.Drawing.Color.Transparent;
            foodSupplyCheckBox.Location = new System.Drawing.Point(227, 335);
            foodSupplyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            foodSupplyCheckBox.Size = new System.Drawing.Size(136, 19);
            foodSupplyCheckBox.TabIndex = 34;
            foodSupplyCheckBox.Text = "Food/Supply status ?";
            foodSupplyCheckBox.UseVisualStyleBackColor = false;
            foodSupplyCheckBox.CheckedChanged += foodSupplyCheckBox_CheckedChanged;
            // 
            // checkinCheckBox
            // 
            checkinCheckBox.AutoSize = true;
            checkinCheckBox.BackColor = System.Drawing.Color.Transparent;
            checkinCheckBox.Location = new System.Drawing.Point(18, 336);
            checkinCheckBox.Margin = new System.Windows.Forms.Padding(4);
            checkinCheckBox.Name = "checkinCheckBox";
            checkinCheckBox.Size = new System.Drawing.Size(80, 19);
            checkinCheckBox.TabIndex = 33;
            checkinCheckBox.Text = "Check in ?";
            checkinCheckBox.UseVisualStyleBackColor = false;
            checkinCheckBox.CheckedChanged += checkinCheckBox_CheckedChanged;
            // 
            // foodMenuButton
            // 
            foodMenuButton.Location = new System.Drawing.Point(18, 280);
            foodMenuButton.Margin = new System.Windows.Forms.Padding(4);
            foodMenuButton.Name = "foodMenuButton";
            foodMenuButton.Size = new System.Drawing.Size(367, 39);
            foodMenuButton.TabIndex = 23;
            foodMenuButton.Text = "Food and menu";
            foodMenuButton.Click += foodMenuButton_Click;
            // 
            // qtGuestComboBox
            // 
            qtGuestComboBox.FormattingEnabled = true;
            qtGuestComboBox.ItemHeight = 15;
            qtGuestComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            qtGuestComboBox.Location = new System.Drawing.Point(18, 35);
            qtGuestComboBox.Margin = new System.Windows.Forms.Padding(4);
            qtGuestComboBox.Name = "qtGuestComboBox";
            qtGuestComboBox.Size = new System.Drawing.Size(176, 23);
            qtGuestComboBox.TabIndex = 25;
            // 
            // finalizeButton
            // 
            finalizeButton.Location = new System.Drawing.Point(18, 389);
            finalizeButton.Margin = new System.Windows.Forms.Padding(4);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new System.Drawing.Size(367, 36);
            finalizeButton.TabIndex = 22;
            finalizeButton.Text = "Finalize bill";
            finalizeButton.Click += finalizeButton_Click;
            // 
            // metroLabel12
            // 
            metroLabel12.AutoSize = true;
            metroLabel12.BackColor = System.Drawing.Color.Transparent;
            metroLabel12.Location = new System.Drawing.Point(18, 195);
            metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new System.Drawing.Size(93, 15);
            metroLabel12.TabIndex = 32;
            metroLabel12.Text = "Deperture [date]";
            // 
            // submitButton
            // 
            submitButton.Location = new System.Drawing.Point(18, 429);
            submitButton.Margin = new System.Windows.Forms.Padding(4);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(367, 41);
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.Visible = false;
            submitButton.Click += submitButton_Click;
            // 
            // depDatePicker
            // 
            depDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            depDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            depDatePicker.Location = new System.Drawing.Point(18, 220);
            depDatePicker.Margin = new System.Windows.Forms.Padding(4);
            depDatePicker.MaxDate = new System.DateTime(2025, 4, 27, 23, 59, 0, 0);
            depDatePicker.MinDate = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            depDatePicker.Name = "depDatePicker";
            depDatePicker.Size = new System.Drawing.Size(368, 26);
            depDatePicker.TabIndex = 31;
            depDatePicker.Value = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // roomNComboBox
            // 
            roomNComboBox.FormattingEnabled = true;
            roomNComboBox.ItemHeight = 15;
            roomNComboBox.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" });
            roomNComboBox.Location = new System.Drawing.Point(202, 96);
            roomNComboBox.Margin = new System.Windows.Forms.Padding(4);
            roomNComboBox.Name = "roomNComboBox";
            roomNComboBox.Size = new System.Drawing.Size(185, 23);
            roomNComboBox.TabIndex = 24;
            // 
            // floorComboBox
            // 
            floorComboBox.FormattingEnabled = true;
            floorComboBox.ItemHeight = 15;
            floorComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            floorComboBox.Location = new System.Drawing.Point(18, 96);
            floorComboBox.Margin = new System.Windows.Forms.Padding(4);
            floorComboBox.Name = "floorComboBox";
            floorComboBox.Size = new System.Drawing.Size(176, 23);
            floorComboBox.TabIndex = 23;
            // 
            // entryDatePicker
            // 
            entryDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            entryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            entryDatePicker.Location = new System.Drawing.Point(18, 161);
            entryDatePicker.Margin = new System.Windows.Forms.Padding(4);
            entryDatePicker.MaxDate = new System.DateTime(2025, 4, 27, 23, 59, 0, 0);
            entryDatePicker.MinDate = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new System.Drawing.Size(365, 26);
            entryDatePicker.TabIndex = 26;
            entryDatePicker.Value = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.BackColor = System.Drawing.Color.Transparent;
            entryLabel.Location = new System.Drawing.Point(18, 136);
            entryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new System.Drawing.Size(68, 15);
            entryLabel.TabIndex = 30;
            entryLabel.Text = "Entry [date]";
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.ItemHeight = 15;
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Twin", "Duplex", "Suite" });
            roomTypeComboBox.Location = new System.Drawing.Point(202, 34);
            roomTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new System.Drawing.Size(185, 23);
            roomTypeComboBox.TabIndex = 22;
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Location = new System.Drawing.Point(18, 74);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 15);
            label8.TabIndex = 21;
            label8.Text = "Floor Number";
            label8.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Location = new System.Drawing.Point(202, 77);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 15);
            label7.TabIndex = 21;
            label7.Text = "Room Number";
            label7.Click += label6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Location = new System.Drawing.Point(202, 9);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(66, 15);
            label6.TabIndex = 21;
            label6.Text = "Room Type";
            label6.Click += label6_Click;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = System.Drawing.Color.Transparent;
            choiceLabel.Location = new System.Drawing.Point(18, 9);
            choiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new System.Drawing.Size(86, 15);
            choiceLabel.TabIndex = 21;
            choiceLabel.Text = "guest numbers";
            // 
            // leftMPanel
            // 
            leftMPanel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            leftMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            leftMPanel.Controls.Add(label5);
            leftMPanel.Controls.Add(label4);
            leftMPanel.Controls.Add(label3);
            leftMPanel.Controls.Add(label2);
            leftMPanel.Controls.Add(label1);
            leftMPanel.Controls.Add(emailLabel);
            leftMPanel.Controls.Add(nameLabel);
            leftMPanel.Controls.Add(emailTextBox);
            leftMPanel.Controls.Add(yearTextBox);
            leftMPanel.Controls.Add(monthComboBox);
            leftMPanel.Controls.Add(genderComboBox);
            leftMPanel.Controls.Add(birthdayLabel);
            leftMPanel.Controls.Add(dayComboBox);
            leftMPanel.Controls.Add(phoneNumberLabel);
            leftMPanel.Controls.Add(firstNameTextBox);
            leftMPanel.Controls.Add(genderLabel);
            leftMPanel.Controls.Add(zipComboBox);
            leftMPanel.Controls.Add(phoneNumberTextBox);
            leftMPanel.Controls.Add(stateComboBox);
            leftMPanel.Controls.Add(lastNameTextBox);
            leftMPanel.Controls.Add(cityTextBox);
            leftMPanel.Controls.Add(metroLabel6);
            leftMPanel.Controls.Add(aptTextBox);
            leftMPanel.Controls.Add(addLabel);
            leftMPanel.Location = new System.Drawing.Point(4, 17);
            leftMPanel.Margin = new System.Windows.Forms.Padding(4);
            leftMPanel.Name = "leftMPanel";
            leftMPanel.Size = new System.Drawing.Size(402, 486);
            leftMPanel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(201, 415);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 15);
            label5.TabIndex = 21;
            label5.Text = "Zip Code";
            label5.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 417);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 15);
            label4.TabIndex = 21;
            label4.Text = "State";
            label4.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(206, 369);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 15);
            label3.TabIndex = 21;
            label3.Text = "City";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 367);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 15);
            label2.TabIndex = 21;
            label2.Text = "Apartmenet ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 316);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 15);
            label1.TabIndex = 21;
            label1.Text = "Street Address";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Location = new System.Drawing.Point(18, 260);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(111, 15);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Your e-mail address";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Location = new System.Drawing.Point(17, 8);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = System.Drawing.Color.White;
            emailTextBox.Location = new System.Drawing.Point(18, 285);
            emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(369, 23);
            emailTextBox.TabIndex = 14;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = System.Drawing.Color.White;
            yearTextBox.Location = new System.Drawing.Point(269, 97);
            yearTextBox.Margin = new System.Windows.Forms.Padding(4);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new System.Drawing.Size(119, 23);
            yearTextBox.TabIndex = 9;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.ItemHeight = 15;
            monthComboBox.Items.AddRange(new object[] { "January ", "February ", "March ", "April ", "May ", "June ", "July ", "August ", "September ", "October ", "November ", "December" });
            monthComboBox.Location = new System.Drawing.Point(18, 97);
            monthComboBox.Margin = new System.Windows.Forms.Padding(4);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new System.Drawing.Size(140, 23);
            monthComboBox.TabIndex = 6;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.ItemHeight = 15;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new System.Drawing.Point(18, 161);
            genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new System.Drawing.Size(367, 23);
            genderComboBox.TabIndex = 11;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            birthdayLabel.Location = new System.Drawing.Point(14, 73);
            birthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(51, 15);
            birthdayLabel.TabIndex = 5;
            birthdayLabel.Text = "Birthday";
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.ItemHeight = 15;
            dayComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayComboBox.Location = new System.Drawing.Point(164, 97);
            dayComboBox.Margin = new System.Windows.Forms.Padding(4);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new System.Drawing.Size(96, 23);
            dayComboBox.TabIndex = 8;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            phoneNumberLabel.Location = new System.Drawing.Point(17, 197);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(86, 15);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone number";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = System.Drawing.Color.White;
            firstNameTextBox.Location = new System.Drawing.Point(18, 31);
            firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new System.Drawing.Size(182, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.Transparent;
            genderLabel.Location = new System.Drawing.Point(15, 136);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 15);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender";
            // 
            // zipComboBox
            // 
            zipComboBox.BackColor = System.Drawing.Color.White;
            zipComboBox.Location = new System.Drawing.Point(200, 436);
            zipComboBox.Margin = new System.Windows.Forms.Padding(4);
            zipComboBox.Name = "zipComboBox";
            zipComboBox.Size = new System.Drawing.Size(186, 23);
            zipComboBox.TabIndex = 20;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = System.Drawing.Color.White;
            phoneNumberTextBox.Location = new System.Drawing.Point(17, 223);
            phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new System.Drawing.Size(369, 23);
            phoneNumberTextBox.TabIndex = 13;
            phoneNumberTextBox.Leave += phoneNumberTextBox_Leave;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.ItemHeight = 15;
            stateComboBox.Items.AddRange(new object[] { "Alabama ", "Alaska ", "Arizona ", "Arkansas ", "California ", "Colorado ", "Connecticut ", "Delaware ", "Florida ", "Georgia ", "Hawaii ", "Idaho ", "Illinois Indiana ", "Iowa ", "Kansas ", "Kentucky ", "Louisiana ", "Maine ", "Maryland ", "Massachusetts ", "Michigan ", "Minnesota ", "Mississippi ", "Missouri ", "Montana Nebraska ", "Nevada ", "New Hampshire ", "New Jersey ", "New Mexico ", "New York ", "North Carolina ", "North Dakota ", "Ohio ", "Oklahoma ", "Oregon ", "Pennsylvania Rhode Island ", "South Carolina ", "South Dakota ", "Tennessee ", "Texas ", "Utah ", "Vermont ", "Virginia ", "Washington ", "West Virginia ", "Wisconsin ", "Wyoming" });
            stateComboBox.Location = new System.Drawing.Point(18, 436);
            stateComboBox.Margin = new System.Windows.Forms.Padding(4);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new System.Drawing.Size(175, 23);
            stateComboBox.TabIndex = 19;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = System.Drawing.Color.White;
            lastNameTextBox.Location = new System.Drawing.Point(206, 31);
            lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new System.Drawing.Size(182, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            cityTextBox.BackColor = System.Drawing.Color.White;
            cityTextBox.Location = new System.Drawing.Point(200, 388);
            cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new System.Drawing.Size(186, 23);
            cityTextBox.TabIndex = 18;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.BackColor = System.Drawing.Color.Transparent;
            metroLabel6.Location = new System.Drawing.Point(17, 285);
            metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new System.Drawing.Size(74, 15);
            metroLabel6.TabIndex = 16;
            metroLabel6.Text = "Your address";
            // 
            // aptTextBox
            // 
            aptTextBox.BackColor = System.Drawing.Color.White;
            aptTextBox.Location = new System.Drawing.Point(17, 386);
            aptTextBox.Margin = new System.Windows.Forms.Padding(4);
            aptTextBox.Name = "aptTextBox";
            aptTextBox.Size = new System.Drawing.Size(176, 23);
            aptTextBox.TabIndex = 17;
            // 
            // addLabel
            // 
            addLabel.BackColor = System.Drawing.Color.White;
            addLabel.Location = new System.Drawing.Point(15, 335);
            addLabel.Margin = new System.Windows.Forms.Padding(4);
            addLabel.Name = "addLabel";
            addLabel.Size = new System.Drawing.Size(369, 23);
            addLabel.TabIndex = 15;
            addLabel.TextChanged += addLabel_TextChanged;
            // 
            // searchPage
            // 
            searchPage.AutoScroll = true;
            searchPage.Controls.Add(SearchError);
            searchPage.Controls.Add(searchDataGridView);
            searchPage.Controls.Add(searchButton);
            searchPage.Controls.Add(searchTextBox);
            searchPage.Location = new System.Drawing.Point(4, 24);
            searchPage.Margin = new System.Windows.Forms.Padding(4);
            searchPage.Name = "searchPage";
            searchPage.Size = new System.Drawing.Size(1140, 528);
            searchPage.TabIndex = 4;
            searchPage.Text = "Universal Search";
            // 
            // SearchError
            // 
            SearchError.AutoSize = true;
            SearchError.Location = new System.Drawing.Point(315, 43);
            SearchError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SearchError.Name = "SearchError";
            SearchError.Size = new System.Drawing.Size(209, 75);
            SearchError.TabIndex = 19;
            SearchError.Text = "I ran out of entries :( SORRY DUDE.\r\n\r\nYou know, we can make another deal. \r\n\r\nI sure will find something.\r\n";
            SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            searchDataGridView.AllowUserToAddRows = false;
            searchDataGridView.AllowUserToDeleteRows = false;
            searchDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new System.Drawing.Point(80, 66);
            searchDataGridView.Margin = new System.Windows.Forms.Padding(4);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.Size = new System.Drawing.Size(940, 458);
            searchDataGridView.TabIndex = 18;
            searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            searchButton.BackColor = System.Drawing.Color.Transparent;
            searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            searchButton.Location = new System.Drawing.Point(1028, 206);
            searchButton.Margin = new System.Windows.Forms.Padding(4);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(75, 44);
            searchButton.TabIndex = 17;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = System.Drawing.Color.White;
            searchTextBox.Location = new System.Drawing.Point(88, 227);
            searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new System.Drawing.Size(833, 23);
            searchTextBox.TabIndex = 15;
            // 
            // metroTabPage2
            // 
            metroTabPage2.AutoScroll = true;
            metroTabPage2.Controls.Add(resTotalDataGridView);
            metroTabPage2.Location = new System.Drawing.Point(4, 24);
            metroTabPage2.Margin = new System.Windows.Forms.Padding(4);
            metroTabPage2.Name = "metroTabPage2";
            metroTabPage2.Size = new System.Drawing.Size(1140, 528);
            metroTabPage2.TabIndex = 3;
            metroTabPage2.Text = "Reservation Adv. view";
            // 
            // resTotalDataGridView
            // 
            resTotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resTotalDataGridView.Location = new System.Drawing.Point(0, 4);
            resTotalDataGridView.Margin = new System.Windows.Forms.Padding(4);
            resTotalDataGridView.Name = "resTotalDataGridView";
            resTotalDataGridView.Size = new System.Drawing.Size(1138, 501);
            resTotalDataGridView.TabIndex = 2;
            // 
            // roomPage
            // 
            roomPage.Controls.Add(metroLabel13);
            roomPage.Controls.Add(metroLabel11);
            roomPage.Controls.Add(reservedLabel);
            roomPage.Controls.Add(roomReservedListBox);
            roomPage.Controls.Add(roomOccupiedListBox);
            roomPage.Controls.Add(occupiedLabel);
            roomPage.Location = new System.Drawing.Point(4, 24);
            roomPage.Margin = new System.Windows.Forms.Padding(4);
            roomPage.Name = "roomPage";
            roomPage.Size = new System.Drawing.Size(1140, 528);
            roomPage.TabIndex = 2;
            roomPage.Text = "Room availibility";
            // 
            // metroLabel13
            // 
            metroLabel13.AutoSize = true;
            metroLabel13.BackColor = System.Drawing.Color.Transparent;
            metroLabel13.Location = new System.Drawing.Point(536, 32);
            metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel13.Name = "metroLabel13";
            metroLabel13.Size = new System.Drawing.Size(391, 15);
            metroLabel13.TabIndex = 10;
            metroLabel13.Text = "Room#| Type  |  ID#   |       Name      |      Phone #      |     Entry       |    Depart";
            // 
            // metroLabel11
            // 
            metroLabel11.AutoSize = true;
            metroLabel11.BackColor = System.Drawing.Color.Transparent;
            metroLabel11.Location = new System.Drawing.Point(-4, 32);
            metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel11.Name = "metroLabel11";
            metroLabel11.Size = new System.Drawing.Size(257, 15);
            metroLabel11.TabIndex = 9;
            metroLabel11.Text = "Room#| Type  |  ID#   |       Name      |      Phone #";
            // 
            // reservedLabel
            // 
            reservedLabel.AutoSize = true;
            reservedLabel.BackColor = System.Drawing.Color.Transparent;
            reservedLabel.Location = new System.Drawing.Point(536, 5);
            reservedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            reservedLabel.Name = "reservedLabel";
            reservedLabel.Size = new System.Drawing.Size(54, 15);
            reservedLabel.TabIndex = 8;
            reservedLabel.Text = "Reserved";
            // 
            // roomReservedListBox
            // 
            roomReservedListBox.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            roomReservedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            roomReservedListBox.FormattingEnabled = true;
            roomReservedListBox.HorizontalScrollbar = true;
            roomReservedListBox.IntegralHeight = false;
            roomReservedListBox.ItemHeight = 15;
            roomReservedListBox.Location = new System.Drawing.Point(536, 58);
            roomReservedListBox.Margin = new System.Windows.Forms.Padding(4);
            roomReservedListBox.Name = "roomReservedListBox";
            roomReservedListBox.Size = new System.Drawing.Size(602, 446);
            roomReservedListBox.TabIndex = 7;
            // 
            // roomOccupiedListBox
            // 
            roomOccupiedListBox.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            roomOccupiedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            roomOccupiedListBox.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            roomOccupiedListBox.FormattingEnabled = true;
            roomOccupiedListBox.HorizontalScrollbar = true;
            roomOccupiedListBox.IntegralHeight = false;
            roomOccupiedListBox.Location = new System.Drawing.Point(0, 58);
            roomOccupiedListBox.Margin = new System.Windows.Forms.Padding(4);
            roomOccupiedListBox.Name = "roomOccupiedListBox";
            roomOccupiedListBox.Size = new System.Drawing.Size(529, 446);
            roomOccupiedListBox.TabIndex = 6;
            // 
            // occupiedLabel
            // 
            occupiedLabel.AutoSize = true;
            occupiedLabel.BackColor = System.Drawing.Color.Transparent;
            occupiedLabel.Location = new System.Drawing.Point(-4, 5);
            occupiedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            occupiedLabel.Name = "occupiedLabel";
            occupiedLabel.Size = new System.Drawing.Size(58, 15);
            occupiedLabel.TabIndex = 5;
            occupiedLabel.Text = "Occupied";
            // 
            // LogOut
            // 
            LogOut.BackColor = System.Drawing.Color.Red;
            LogOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LogOut.Location = new System.Drawing.Point(987, 12);
            LogOut.Name = "LogOut";
            LogOut.Size = new System.Drawing.Size(162, 60);
            LogOut.TabIndex = 1;
            LogOut.Text = "Log out";
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // Frontend
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1165, 629);
            Controls.Add(LogOut);
            Controls.Add(resPanel);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Frontend";
            Padding = new System.Windows.Forms.Padding(24, 69, 24, 23);
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Frontend";
            FormClosing += frontend_FormClosing;
            Load += MainTab_Load;
            resPanel.ResumeLayout(false);
            reservationPage.ResumeLayout(false);
            rightMPanel.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            middlePanel.PerformLayout();
            leftMPanel.ResumeLayout(false);
            leftMPanel.PerformLayout();
            searchPage.ResumeLayout(false);
            searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).EndInit();
            roomPage.ResumeLayout(false);
            roomPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion



        private System.Windows.Forms.TabControl resPanel;
        private System.Windows.Forms.TabPage reservationPage;
        private System.Windows.Forms.Panel leftMPanel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.TextBox zipComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox aptTextBox;
        private System.Windows.Forms.Label metroLabel6;
        private System.Windows.Forms.TextBox addLabel;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.ComboBox roomNComboBox;
        private System.Windows.Forms.ComboBox floorComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button finalizeButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private System.Windows.Forms.Label metroLabel12;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Button foodMenuButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckBox checkinCheckBox;
        private System.Windows.Forms.ComboBox resEditButton;
        private System.Windows.Forms.Panel rightMPanel;

        private System.Windows.Forms.TabPage roomPage;
        private System.Windows.Forms.TabPage metroTabPage2;

        private System.Windows.Forms.DataGridView resTotalDataGridView;
        private System.Windows.Forms.CheckBox foodSupplyCheckBox;
        private System.Windows.Forms.ListBox roomOccupiedListBox;
        private System.Windows.Forms.Label occupiedLabel;
        private System.Windows.Forms.Label reservedLabel;
        private System.Windows.Forms.ListBox roomReservedListBox;
        private System.Windows.Forms.TabPage searchPage;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox qtGuestComboBox;
        private System.Windows.Forms.Label metroLabel13;
        private System.Windows.Forms.Label metroLabel11;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label SearchError;
        private System.Windows.Forms.CheckBox smsCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LogOut;
    }
}

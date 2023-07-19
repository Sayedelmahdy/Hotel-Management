using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Hotel_Manager.Entities.FrontEnd;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net.Mail;
using System.Diagnostics;
using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Running;
using System.IO;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using System.Windows.Forms;

namespace Hotel_Manager
{

    public partial class Frontend : Form
    {
        string AccountSid = "ACcb86dacb791bef978628a2e16b1f7a24";
        string AuthToken = "3f344a07336d2e0ac5e467f72a1e650d";
        string RecvPhoneNumber = "";
        FRONTEND_RESERVATION ContextFRONTEND_RESERVATION;
       
        public Frontend(FRONTEND_RESERVATION context)
        {
           
            this.ContextFRONTEND_RESERVATION = context;
            InitializeComponent();
            CenterToScreen();
            entryDatePicker.MinDate = DateTime.Today;
            depDatePicker.MinDate = DateTime.Today.AddDays(1);

            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();

            this.roomOccupiedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomOccupiedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomOccupiedListBox_DrawItem);
            this.roomReservedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomReservedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomReservedListBox_DrawItem);
        }



        private void roomOccupiedListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.roomOccupiedListBox.IntegralHeight = false;
            this.roomOccupiedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomOccupiedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }
        private void roomReservedListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.roomReservedListBox.IntegralHeight = false;
            this.roomReservedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomReservedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }


        private string getval;

        public string Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public Int32 primartyID = 0;
        public Boolean taskFinder = false;
        public Boolean editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private float finalizedTotalAmount = 0.0f;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string cleaning; private string towel;
        private string surprise;

        private void MainTab_Load(object sender, EventArgs e)
        {
            foodSupplyCheckBox.Enabled = false;



        }

        public void foodMenuButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.breakfastCheckBox.Checked = true;
                    food_menu.breakfastQTY.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    food_menu.lunchCheckBox.Checked = true;

                    food_menu.lunchQTY.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    food_menu.dinnerCheckBox.Checked = true;
                    food_menu.dinnerQTY.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    food_menu.cleaningCheckBox.Checked = true;
                }
                if (towel == "1")
                {
                    food_menu.towelsCheckBox.Checked = true;
                }
                if (surprise == "1")
                {
                    food_menu.surpriseCheckBox.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "1" : "0";
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? "1" : "0";

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "1" : "0";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roomTypeComboBox.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                floorComboBox.SelectedItem = "1";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                floorComboBox.SelectedItem = "2";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                floorComboBox.SelectedItem = "3";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                floorComboBox.SelectedItem = "4";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                floorComboBox.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            bool temp = int.TryParse(qtGuestComboBox.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = qtGuestComboBox.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            editClicked = true;
            entryDatePicker.MinDate = new DateTime(2014, 4, 1);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Format = DateTimePickerFormat.Custom;

            depDatePicker.MinDate = new DateTime(2014, 4, 1);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Format = DateTimePickerFormat.Custom;

            submitButton.Visible = false;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            resEditButton.Visible = true;

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
        }


        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
            {
                foodSupplyCheckBox.Checked = true;
            }
            updateButton.Enabled = true;

            FinalizePayment finalizebil = new FinalizePayment();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            if (taskFinder)
            {
                finalizebil.paymentComboBox.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizebil.phoneNComboBox.Text = FCnumber;
                finalizebil.monthComboBox.SelectedItem = FcardExpOne;
                finalizebil.yearComboBox.SelectedItem = FcardExpTwo;
                finalizebil.cvcComboBox.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = (float)finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;

            if (!editClicked)
            {
                submitButton.Visible = true;
            }
        }

        private void SendSMS(int secondUserID)
        {
        }
        private bool checktypes(Form form)
        {
            List<TextBox> txtboxs = new() { firstNameTextBox, lastNameTextBox, yearTextBox, phoneNumberTextBox, emailTextBox, zipComboBox, cityTextBox, aptTextBox };
            List<ComboBox> comboBoxes = new List<ComboBox> { monthComboBox, dayComboBox, genderComboBox, stateComboBox, roomTypeComboBox, roomNComboBox, floorComboBox, qtGuestComboBox };
            List<DateTimePicker> dateTimePickers = new List<DateTimePicker> { entryDatePicker, depDatePicker };

            foreach (TextBox tt in txtboxs)
            {
                if (tt.Text.IsNullOrEmpty())
                {
                    Debug.WriteLine(tt.Name + " " + form);
                    return false;
                }
            }
            foreach (ComboBox tt in comboBoxes)
            {

                if (tt.Name == "searchTextBox") continue;
                if (tt.Text.IsNullOrEmpty())
                {
                    Debug.WriteLine(tt.Name + " " + form);
                    return false;
                }
            }
            foreach (DateTimePicker tt in dateTimePickers)
            {

                if (tt.Name == "searchTextBox") continue;
                if (tt.Text.IsNullOrEmpty())
                {
                    Debug.WriteLine(tt.Name + " " + form);
                    return false;
                }
            }

            return true;

        }
        public static bool mm;
        public static void Checkfiz(string a, string b, string c, string d, string e)
        {
            if (a.IsNullOrEmpty() || b.IsNullOrEmpty() || c.IsNullOrEmpty() || d.IsNullOrEmpty() || e.IsNullOrEmpty())
            {
                mm = false;
            }
            mm = true;
        }
        private bool CheckAll()
        {

            return checktypes(this) && mm;

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!CheckAll())
            {
                MessageBox.Show("Some Fields Are Empty!!!");
                return;
            }
            birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;
            reservation reservation = new()
            {
                birth_day = birthday,
                first_name = firstNameTextBox.Text,
                last_name = lastNameTextBox.Text,
                gender = genderComboBox.SelectedItem.ToString(),
                phone_number = phoneNumberTextBox.Text,
                email_address = emailTextBox.Text,
                number_guest = qtGuestComboBox.SelectedIndex + 1,
                street_address = addLabel.Text,
                apt_suite = aptTextBox.Text,
                city = cityTextBox.Text,
                state = stateComboBox.SelectedItem.ToString(),
                zip_code = zipComboBox.Text,
                room_type = roomTypeComboBox.SelectedItem.ToString(),
                room_floor = floorComboBox.SelectedItem.ToString(),
                room_number = roomNComboBox.SelectedItem.ToString(),
                total_bill = finalizedTotalAmount,
                payment_type = paymentType,
                card_type = CardType,
                card_number = paymentCardNumber,
                card_exp = MM_YY_Of_Card,
                card_cvc = CVC_Of_Card,
                arrival_time = entryDatePicker.Value,
                leaving_time = depDatePicker.Value,
                check_in = checkin == 1,
                break_fast = breakfast,
                lunch = lunch,
                dinner = dinner,
                supply_status = foodStatus == 1,
                cleaning = Convert.ToInt32(cleaning) == 1,
                towel = Convert.ToInt32(towel) == 1,
                s_surprise = Convert.ToInt32(surprise) == 1,
                food_bill = foodBill

            };

            Int32 getIDBack = 0;
            ContextFRONTEND_RESERVATION.reservation.Add(reservation);
            ContextFRONTEND_RESERVATION.SaveChanges();
            try
            {
                getIDBack = reservation.Id;
                string userID = Convert.ToString(getIDBack);
                SendSMS(getIDBack);
                MessageBox.Show(this, "Entry successfully inserted into database. " + "\n\n" +
                    "Provide this unique ID to the customer." + "\n\n" +
                "USER UNIQUE ID: " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }
        
        private void newButton_Click(object sender, EventArgs e)
        {
            submitButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            resEditButton.Visible = false;
            reset_frontend();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control == roomTypeComboBox)
                {
                    continue;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren)
                {
                    ClearAllComboBox(control);
                }
            }
        }
        private void reset_frontend()
        {
            try
            {

                resEditButton.Items.Clear();
                checkinCheckBox.Checked = false;
                foodSupplyCheckBox.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (primartyID > 1000)
            {
                reservation msms = ContextFRONTEND_RESERVATION.reservation.Find(primartyID);


                try
                {
                    ContextFRONTEND_RESERVATION.reservation.Remove(msms);
                    ContextFRONTEND_RESERVATION.SaveChanges();

                    MessageBox.Show(this, "Reservation For the UNIQUE USER ID of: " + "\n\n" +
                " " + primartyID + " is DELETED.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Selected ID doesn't exist." + ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }
        private void EnableUpdateButton()
        {
            FinalizePayment finalizebil = new FinalizePayment();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            finalizebil.paymentComboBox.SelectedItem = FPayment.Replace(" ", string.Empty);
            finalizebil.phoneNComboBox.Text = FCnumber;
            finalizebil.monthComboBox.SelectedItem = FcardExpOne;
            finalizebil.yearComboBox.SelectedItem = FcardExpTwo;
            finalizebil.cvcComboBox.Text = FCardCVC;
            finalizedTotalAmount = (float)finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;
        }

        private void updateButton_Click(object sender, EventArgs e)  
        {

            birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;




            try
            {
                reservation res = ContextFRONTEND_RESERVATION.reservation.Find(primartyID);
                res.first_name = firstNameTextBox.Text;
                res.last_name = lastNameTextBox.Text;
                res.birth_day = birthday;
                res.gender = genderComboBox.SelectedItem.ToString();
                res.phone_number = phoneNumberTextBox.Text;
                res.email_address = emailTextBox.Text;
                res.number_guest = int.Parse((qtGuestComboBox.SelectedIndex + 1).ToString());
                res.street_address = addLabel.Text;
                res.apt_suite = aptTextBox.Text;
                res.city = cityTextBox.Text;
                res.state = stateComboBox.SelectedItem.ToString();
                res.zip_code = zipComboBox.Text;
                res.room_type = roomTypeComboBox.SelectedItem.ToString();
                res.room_floor = floorComboBox.SelectedItem.ToString();
                res.room_number = roomNComboBox.SelectedItem.ToString();
                res.total_bill = finalizedTotalAmount;
                res.payment_type = paymentType;
                res.card_type = CardType;
                res.card_number = paymentCardNumber;
                res.card_exp = MM_YY_Of_Card;
                res.card_cvc = CVC_Of_Card;
                res.arrival_time = entryDatePicker.Value;
                res.leaving_time = depDatePicker.Value;
                res.break_fast = breakfast;
                res.check_in = checkin == 1;
                res.lunch = lunch;
                res.dinner = dinner;
                res.supply_status = foodStatus == 1;
                res.cleaning = Convert.ToInt32(cleaning) == 1;
                res.towel = Convert.ToInt32(towel) == 1;
                res.s_surprise = Convert.ToInt32(surprise) == 1;
                res.food_bill = foodBill;

                string userID = Convert.ToString(primartyID);
                ContextFRONTEND_RESERVATION.SaveChanges();

                MessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();

            reset_frontend();
            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinCheckBox.Checked)
            {
                checkinCheckBox.Text = "Checked in";
                checkin = 1;
            }
            else
            {
                checkin = 0;
                checkinCheckBox.Text = "Check in ?";
            }
        }

        public void ResEditButtonMethod()
        {
            string getQuerystring = resEditButton.Text.Substring(0, 4).Replace(" ", string.Empty);
            IEnumerable<reservation> res = ContextFRONTEND_RESERVATION.reservation.Local.Where(P => P.Id.ToString() == getQuerystring);   
            try
            {
                foreach (reservation reservation in res)
                {
                    taskFinder = true;
                    string ID = reservation.Id.ToString();
                    string first_name = reservation.first_name.ToString();
                    string last_name = reservation.last_name.ToString();
                    string birth_day = reservation.birth_day.ToString();
                    string gender = reservation.gender.ToString();
                    string phone_number = reservation.phone_number.ToString();
                    string email_address = reservation.email_address.ToString();
                    string number_guest = reservation.number_guest.ToString();
                    string street_address = reservation.street_address.ToString();
                    string apt_suite = reservation.apt_suite.ToString();
                    string city = reservation.city.ToString();
                    string state = reservation.state.ToString();
                    string zip_code = reservation.zip_code.ToString();
                    string room_type = reservation.room_type.ToString();
                    string room_floor = reservation.room_floor.ToString();
                    string room_number = reservation.room_number.ToString();
                    string payment_type = reservation.payment_type.ToString();
                    string card_number = reservation.card_number.ToString();
                    string card_exp = reservation.card_exp.ToString();
                    string card_cvc = reservation.card_cvc.ToString();
                    string _cleaning = reservation.cleaning.ToString();
                    string _towel = reservation.towel.ToString();
                    string _surprise = reservation.s_surprise.ToString();
                    string check_in = reservation.check_in.ToString();
                    string supply_status = reservation.supply_status.ToString();
                    string food_billD = reservation.food_bill.ToString();
                    string _breakfast = reservation.break_fast.ToString();
                    string _lunch = reservation.lunch.ToString();
                    string _dinner = reservation.dinner.ToString();
                    string arrival_date = Convert.ToDateTime(reservation.arrival_time).ToString("MM-dd-yyyy").Replace(" ", string.Empty);
                    string leaving_date = Convert.ToDateTime(reservation.leaving_time).ToString("MM-dd-yyyy").Replace(" ", string.Empty);

                    if (_cleaning == "True")
                    {
                        cleaning = "1";
                    }
                    else { cleaning = "0"; }

                    if (_towel == "True")
                    {
                        towel = "1";
                    }
                    else { towel = "0"; }
                    if (_surprise == "True")
                    {
                        surprise = "1";
                    }
                    else
                    {
                        surprise = "0";
                    }
                    roomNComboBox.Items.Add(room_number);
                    roomNComboBox.SelectedItem = room_number;

                    FPayment = payment_type;
                    FCnumber = card_number;
                    FCardCVC = card_cvc;
                    FcardExpOne = card_exp.Substring(0, card_exp.IndexOf('/'));
                    FcardExpTwo = card_exp.Substring(card_exp.Length - Math.Min(2, card_exp.Length));
                    entryDatePicker.Value = Convert.ToDateTime(arrival_date);
                    depDatePicker.Value = Convert.ToDateTime(leaving_date);
                    entryDatePicker.Value.ToShortDateString();
                    depDatePicker.Value.ToShortDateString();



                    double Num;
                    bool isNum = double.TryParse(_lunch, out Num);
                    if (isNum)
                    {
                        lunch = Int32.Parse(_lunch);
                    }
                    else
                    {
                        lunch = 0;
                    }
                    isNum = double.TryParse(_breakfast, out Num);
                    if (isNum)
                    {
                        breakfast = Int32.Parse(_breakfast);
                    }
                    else
                    {
                        breakfast = 0;
                    }
                    isNum = double.TryParse(_dinner, out Num);
                    if (isNum)
                    {
                        dinner = Int32.Parse(_dinner);
                    }
                    else
                    {
                        dinner = 0;
                    }



                    foodBill = Convert.ToInt32(food_billD);

                    if (supply_status == "True")
                    {
                        foodSupplyCheckBox.Checked = true;
                    }
                    else
                    {
                        foodSupplyCheckBox.Checked = false;
                    }


                    firstNameTextBox.Text = first_name;
                    lastNameTextBox.Text = last_name;
                    phoneNumberTextBox.Text = phone_number;
                    genderComboBox.SelectedItem = gender;

                    monthComboBox.SelectedItem = birth_day.Substring(0, birth_day.IndexOf('-'));
                    dayComboBox.SelectedItem = birth_day.Substring(birth_day.IndexOf('-') + 1, 2);
                    yearTextBox.Text = birth_day.Substring(birth_day.Length - Math.Min(4, birth_day.Length));

                    emailTextBox.Text = email_address;
                    qtGuestComboBox.SelectedItem = number_guest;
                    addLabel.Text = street_address;
                    aptTextBox.Text = apt_suite;
                    cityTextBox.Text = city;
                    stateComboBox.SelectedItem = state;
                    zipComboBox.Text = zip_code;
                    roomTypeComboBox.SelectedItem = room_type.Replace(" ", string.Empty);
                    floorComboBox.SelectedItem = room_floor.Replace(" ", string.Empty);
                    roomNComboBox.SelectedItem = room_number.Replace(" ", string.Empty);

                    if (check_in == "True")
                    {
                        checkinCheckBox.Checked = true;
                    }
                    else
                    {
                        checkinCheckBox.Checked = false;
                    }


                    primartyID = Convert.ToInt32(ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }
        private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)  
        {
            getChecked();
            ResEditButtonMethod();
        }

        private void ComboBoxItemsFromDataBase()
        {

            var res = ContextFRONTEND_RESERVATION.reservation.Select      
                (ep => new { ep.Id, ep.first_name, ep.last_name, ep.phone_number });


            try
            {
                foreach (var reservation in res)
                {
                    string ID = reservation.Id.ToString();
                    string first_name = reservation.first_name.ToString();
                    string last_name = reservation.last_name.ToString();
                    string phone_number = reservation.phone_number.ToString();
                    resEditButton.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadForDataGridView()
        {
            try
            {

                resTotalDataGridView.DataSource = ContextFRONTEND_RESERVATION.reservation.Local.ToList();    


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            }
        }

        private void foodSupplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (foodSupplyCheckBox.Checked)
            {
                foodSupplyCheckBox.Text = "Food/Supply: Complete";
                foodStatus = 1;
            }
            else
            {
                foodStatus = 0;
                foodSupplyCheckBox.Text = "Food/Supply status?";
            }
        }

        private void GetOccupiedRoom()
        {
            roomOccupiedListBox.Items.Clear();


            try
            {
                var res = ContextFRONTEND_RESERVATION.reservation.Local.Where(P => P.check_in == true)
                    .Select(
                    p => new
                    {
                        p.room_number,
                        p.room_type,
                        p.Id,
                        p.first_name,
                        p.last_name,
                        p.phone_number,
                        p.arrival_time,
                        p.leaving_time,

                    }
                    );    


                foreach (var r in res)
                {

                    string room_number = r.room_number.ToString();
                    string room_type = r.room_type.ToString();
                    string ID = r.Id.ToString();
                    string first_name = r.first_name.ToString();
                    string last_name = r.last_name.ToString();
                    string phone_number = r.phone_number.ToString();
                    string arrival_time = r.arrival_time.ToString();
                    string dep_time = r.leaving_time.ToString();
                    roomOccupiedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                        " " + room_type.Replace(" ", string.Empty) +
                        " " + ID.Replace(" ", string.Empty) +
                        " " + "[" + first_name.Replace(" ", string.Empty) +
                        " " + last_name.Replace(" ", string.Empty) + "]" +
                        " " + phone_number.Replace(" ", string.Empty));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ReservedRoom()
        {
            roomReservedListBox.Items.Clear();

            try
            {
                var res = ContextFRONTEND_RESERVATION.reservation.Local.Where(P => P.check_in == false)
                    .Select(
                    p => new
                    {
                        p.room_number,
                        p.room_type,
                        p.Id,
                        p.first_name,
                        p.last_name,
                        p.phone_number,
                        p.arrival_time,
                        p.leaving_time,

                    }
                    );    

                foreach (var r in res)
                {

                    string room_number = r.room_number.ToString();
                    string room_type = r.room_type.ToString();
                    string ID = r.Id.ToString();
                    string first_name = r.first_name.ToString();
                    string last_name = r.last_name.ToString();
                    string phone_number = r.phone_number.ToString();
                    string arrival_date = Convert.ToDateTime(r.arrival_time).ToString("MM-dd-yyyy");
                    string leaving_date = Convert.ToDateTime(r.leaving_time).ToString("MM-dd-yyy");
                    roomReservedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                        " " + room_type.Replace(" ", string.Empty) +
                        " " + ID.Replace(" ", string.Empty) +
                        " " + first_name.Replace(" ", string.Empty) +
                        " " + last_name.Replace(" ", string.Empty) +
                        " " + phone_number.Replace(" ", string.Empty) +
                        " " + arrival_date.Replace(" ", string.Empty) +
                        " " + leaving_date.Replace(" ", string.Empty));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void getChecked()
        {
            try
            {
                var TakenRoomList = ContextFRONTEND_RESERVATION.reservation.Local.Where(p => p.check_in == true).Select(p => p.room_number);  


                foreach (string TakenRoom in TakenRoomList)
                {
                    TakenRoom.Trim();
                }
                foreach (string roomList in TakenRoomList)
                {
                    if (roomNComboBox.Items.Contains(roomList))
                    {

                        int temp = roomNComboBox.Items.IndexOf(roomList);
                        roomNComboBox.Items.RemoveAt(temp);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            RecvPhoneNumber = "+1" + phoneNumberTextBox.Text.Replace(" ", string.Empty);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string ss = "%" + searchTextBox.Text + "%";
            IEnumerable<reservation> res = null;
            res = (from reservation in ContextFRONTEND_RESERVATION.reservation.Local
                   where reservation.Id.ToString().StartsWith(searchTextBox.Text) ||
          reservation.last_name.StartsWith(searchTextBox.Text) ||
          reservation.first_name.StartsWith(searchTextBox.Text) ||
          reservation.gender.StartsWith(searchTextBox.Text) ||
          reservation.state.StartsWith(searchTextBox.Text) ||
          reservation.city.StartsWith(searchTextBox.Text) ||
          reservation.room_number.StartsWith(searchTextBox.Text) ||
          reservation.room_type.StartsWith(searchTextBox.Text) ||
          reservation.email_address.StartsWith(searchTextBox.Text) ||
          reservation.phone_number.StartsWith(searchTextBox.Text) ||
          reservation.Id.ToString().Contains(searchTextBox.Text) ||
          reservation.last_name.Contains(searchTextBox.Text) ||
          reservation.first_name.Contains(searchTextBox.Text) ||
          reservation.gender.Contains(searchTextBox.Text) ||
          reservation.state.Contains(searchTextBox.Text) ||
          reservation.city.Contains(searchTextBox.Text) ||
          reservation.room_number.Contains(searchTextBox.Text) ||
          reservation.room_type.Contains(searchTextBox.Text) ||
          reservation.email_address.Contains(searchTextBox.Text) ||
          reservation.phone_number.Contains(searchTextBox.Text) ||
          reservation.Id.ToString().EndsWith(searchTextBox.Text) ||
          reservation.last_name.EndsWith(searchTextBox.Text) ||
          reservation.first_name.EndsWith(searchTextBox.Text) ||
          reservation.gender.EndsWith(searchTextBox.Text) ||
          reservation.state.EndsWith(searchTextBox.Text) ||
          reservation.city.EndsWith(searchTextBox.Text) ||
          reservation.room_number.EndsWith(searchTextBox.Text) ||
          reservation.room_type.EndsWith(searchTextBox.Text) ||
          reservation.email_address.EndsWith(searchTextBox.Text) ||
          reservation.phone_number.EndsWith(searchTextBox.Text)
                   select reservation);
            searchDataGridView.DataSource = res.ToList();
            if (!(res.ToList().Count <= 0))
            {
                searchButton.Location = new Point(950, 7);
                searchTextBox.Location = new Point(68, 7);
                searchDataGridView.Visible = true;

                SearchError.Visible = false;
            }
            else
            {
                searchDataGridView.Visible = false;
                SearchError.Visible = true;
                SearchError.Text = "SORRY DUDE :(" + "\n"
                    + "I ran out of gas trying to search for " + searchTextBox.Text + "\n"
                + "I sure will find it next time.";
            }
        }

        private void addLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debugger.Launch();
            var res = BenchmarkRunner.Run<Frontend>();


        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            ContextFRONTEND_RESERVATION.Dispose();
            this.Close();
            Application.Restart();
            
            
        }
    }
}

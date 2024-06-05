
namespace AireworthVets
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.motdRichTextBox = new System.Windows.Forms.RichTextBox();
            this.userDataView = new System.Windows.Forms.DataGridView();
            this.infoLabel = new System.Windows.Forms.Label();
            this.dataTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addShiftBox = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.shiftIDTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.commentsBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shiftRoleCombo = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.shiftUserCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.shiftSearchBox = new System.Windows.Forms.TextBox();
            this.allShiftsBtn = new System.Windows.Forms.Button();
            this.myShiftsBtn = new System.Windows.Forms.Button();
            this.shiftDataView = new System.Windows.Forms.DataGridView();
            this.userTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminChck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.defChck = new System.Windows.Forms.CheckBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.createUserBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.userSearchBox = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.infoGB = new System.Windows.Forms.GroupBox();
            this.motdClearBtn = new System.Windows.Forms.Button();
            this.setMsgBtn = new System.Windows.Forms.Button();
            this.checkMsgTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDataView)).BeginInit();
            this.dataTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.addShiftBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftDataView)).BeginInit();
            this.userTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.infoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // motdRichTextBox
            // 
            this.motdRichTextBox.Location = new System.Drawing.Point(249, 18);
            this.motdRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.motdRichTextBox.Name = "motdRichTextBox";
            this.motdRichTextBox.Size = new System.Drawing.Size(484, 98);
            this.motdRichTextBox.TabIndex = 2;
            this.motdRichTextBox.Text = "Message Board";
            // 
            // userDataView
            // 
            this.userDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataView.Location = new System.Drawing.Point(10, 54);
            this.userDataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userDataView.Name = "userDataView";
            this.userDataView.RowHeadersWidth = 62;
            this.userDataView.Size = new System.Drawing.Size(950, 242);
            this.userDataView.TabIndex = 9;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(9, 25);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(83, 20);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "Employee:";
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.tabPage1);
            this.dataTab.Controls.Add(this.userTab);
            this.dataTab.Location = new System.Drawing.Point(18, 168);
            this.dataTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataTab.Name = "dataTab";
            this.dataTab.SelectedIndex = 0;
            this.dataTab.Size = new System.Drawing.Size(981, 717);
            this.dataTab.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addShiftBox);
            this.tabPage1.Controls.Add(this.searchBtn);
            this.tabPage1.Controls.Add(this.shiftSearchBox);
            this.tabPage1.Controls.Add(this.allShiftsBtn);
            this.tabPage1.Controls.Add(this.myShiftsBtn);
            this.tabPage1.Controls.Add(this.shiftDataView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(973, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shifts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addShiftBox
            // 
            this.addShiftBox.Controls.Add(this.button12);
            this.addShiftBox.Controls.Add(this.shiftIDTextBox);
            this.addShiftBox.Controls.Add(this.label10);
            this.addShiftBox.Controls.Add(this.commentsBox);
            this.addShiftBox.Controls.Add(this.label6);
            this.addShiftBox.Controls.Add(this.label5);
            this.addShiftBox.Controls.Add(this.shiftRoleCombo);
            this.addShiftBox.Controls.Add(this.button8);
            this.addShiftBox.Controls.Add(this.shiftUserCombo);
            this.addShiftBox.Controls.Add(this.label4);
            this.addShiftBox.Controls.Add(this.endDate);
            this.addShiftBox.Controls.Add(this.label3);
            this.addShiftBox.Controls.Add(this.label2);
            this.addShiftBox.Controls.Add(this.startDate);
            this.addShiftBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addShiftBox.Location = new System.Drawing.Point(10, 354);
            this.addShiftBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addShiftBox.Name = "addShiftBox";
            this.addShiftBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addShiftBox.Size = new System.Drawing.Size(950, 312);
            this.addShiftBox.TabIndex = 18;
            this.addShiftBox.TabStop = false;
            this.addShiftBox.Text = "Edit shifts";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(610, 249);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(159, 40);
            this.button12.TabIndex = 26;
            this.button12.Text = "Remove shift";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // shiftIDTextBox
            // 
            this.shiftIDTextBox.Location = new System.Drawing.Point(543, 255);
            this.shiftIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shiftIDTextBox.Name = "shiftIDTextBox";
            this.shiftIDTextBox.Size = new System.Drawing.Size(56, 26);
            this.shiftIDTextBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 232);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Shift ID";
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(543, 57);
            this.commentsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(396, 61);
            this.commentsBox.TabIndex = 23;
            this.commentsBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Comments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Role";
            // 
            // shiftRoleCombo
            // 
            this.shiftRoleCombo.FormattingEnabled = true;
            this.shiftRoleCombo.Items.AddRange(new object[] {
            "SA ACA",
            "RVN",
            "LAVet",
            "SAVet",
            "LA RVN",
            "LA ACA",
            "Reception"});
            this.shiftRoleCombo.Location = new System.Drawing.Point(14, 123);
            this.shiftRoleCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shiftRoleCombo.Name = "shiftRoleCombo";
            this.shiftRoleCombo.Size = new System.Drawing.Size(518, 28);
            this.shiftRoleCombo.TabIndex = 20;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(542, 129);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(159, 40);
            this.button8.TabIndex = 19;
            this.button8.Text = "Add shift";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // shiftUserCombo
            // 
            this.shiftUserCombo.FormattingEnabled = true;
            this.shiftUserCombo.Location = new System.Drawing.Point(14, 57);
            this.shiftUserCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shiftUserCombo.Name = "shiftUserCombo";
            this.shiftUserCombo.Size = new System.Drawing.Size(518, 28);
            this.shiftUserCombo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "End Date/Time";
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(14, 255);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(518, 26);
            this.endDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Date/Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee";
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(14, 189);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(518, 26);
            this.startDate.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(225, 11);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(124, 35);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // shiftSearchBox
            // 
            this.shiftSearchBox.Location = new System.Drawing.Point(10, 12);
            this.shiftSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shiftSearchBox.Name = "shiftSearchBox";
            this.shiftSearchBox.Size = new System.Drawing.Size(205, 26);
            this.shiftSearchBox.TabIndex = 16;
            this.shiftSearchBox.Text = "Search by name";
            this.shiftSearchBox.Click += new System.EventHandler(this.shiftSearchBox_Click);
            // 
            // allShiftsBtn
            // 
            this.allShiftsBtn.BackColor = System.Drawing.Color.Transparent;
            this.allShiftsBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.allShiftsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allShiftsBtn.FlatAppearance.BorderSize = 0;
            this.allShiftsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allShiftsBtn.Location = new System.Drawing.Point(178, 305);
            this.allShiftsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allShiftsBtn.Name = "allShiftsBtn";
            this.allShiftsBtn.Size = new System.Drawing.Size(159, 40);
            this.allShiftsBtn.TabIndex = 15;
            this.allShiftsBtn.Text = "Show all";
            this.allShiftsBtn.UseVisualStyleBackColor = false;
            this.allShiftsBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // myShiftsBtn
            // 
            this.myShiftsBtn.BackColor = System.Drawing.Color.Transparent;
            this.myShiftsBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.myShiftsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myShiftsBtn.FlatAppearance.BorderSize = 0;
            this.myShiftsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myShiftsBtn.Location = new System.Drawing.Point(10, 305);
            this.myShiftsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myShiftsBtn.Name = "myShiftsBtn";
            this.myShiftsBtn.Size = new System.Drawing.Size(159, 40);
            this.myShiftsBtn.TabIndex = 14;
            this.myShiftsBtn.Text = "View my shifts";
            this.myShiftsBtn.UseVisualStyleBackColor = false;
            this.myShiftsBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // shiftDataView
            // 
            this.shiftDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftDataView.Location = new System.Drawing.Point(10, 54);
            this.shiftDataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shiftDataView.Name = "shiftDataView";
            this.shiftDataView.RowHeadersWidth = 62;
            this.shiftDataView.Size = new System.Drawing.Size(950, 242);
            this.shiftDataView.TabIndex = 13;
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.groupBox2);
            this.userTab.Controls.Add(this.groupBox1);
            this.userTab.Controls.Add(this.button7);
            this.userTab.Controls.Add(this.userSearchBox);
            this.userTab.Controls.Add(this.userDataView);
            this.userTab.Controls.Add(this.loadBtn);
            this.userTab.Location = new System.Drawing.Point(4, 29);
            this.userTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userTab.Size = new System.Drawing.Size(973, 684);
            this.userTab.TabIndex = 1;
            this.userTab.Text = "Users";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeUserBtn);
            this.groupBox2.Controls.Add(this.userIDTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(514, 355);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(446, 120);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove user";
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeUserBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.removeUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeUserBtn.FlatAppearance.BorderSize = 0;
            this.removeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserBtn.Location = new System.Drawing.Point(68, 57);
            this.removeUserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(134, 40);
            this.removeUserBtn.TabIndex = 29;
            this.removeUserBtn.Text = "Remove user";
            this.removeUserBtn.UseVisualStyleBackColor = false;
            this.removeUserBtn.Click += new System.EventHandler(this.button10_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(9, 62);
            this.userIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(48, 26);
            this.userIDTextBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Employee ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adminChck);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.defChck);
            this.groupBox1.Controls.Add(this.passTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.createUserBtn);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(10, 354);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(495, 312);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit users";
            // 
            // adminChck
            // 
            this.adminChck.AutoSize = true;
            this.adminChck.Location = new System.Drawing.Point(116, 186);
            this.adminChck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminChck.Name = "adminChck";
            this.adminChck.Size = new System.Drawing.Size(80, 24);
            this.adminChck.TabIndex = 28;
            this.adminChck.Text = "Admin";
            this.adminChck.UseVisualStyleBackColor = true;
            this.adminChck.CheckedChanged += new System.EventHandler(this.adminCheck_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "User type";
            // 
            // defChck
            // 
            this.defChck.AutoSize = true;
            this.defChck.Checked = true;
            this.defChck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defChck.Location = new System.Drawing.Point(16, 186);
            this.defChck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.defChck.Name = "defChck";
            this.defChck.Size = new System.Drawing.Size(87, 24);
            this.defChck.TabIndex = 26;
            this.defChck.Text = "Default";
            this.defChck.UseVisualStyleBackColor = true;
            this.defChck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(14, 123);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(458, 26);
            this.passTextBox.TabIndex = 25;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(14, 57);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(458, 26);
            this.nameTextBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Password";
            // 
            // createUserBtn
            // 
            this.createUserBtn.BackColor = System.Drawing.Color.Transparent;
            this.createUserBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.createUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createUserBtn.FlatAppearance.BorderSize = 0;
            this.createUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserBtn.Location = new System.Drawing.Point(9, 222);
            this.createUserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(183, 40);
            this.createUserBtn.TabIndex = 19;
            this.createUserBtn.Text = "Create user";
            this.createUserBtn.UseVisualStyleBackColor = false;
            this.createUserBtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Employee";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(225, 11);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 35);
            this.button7.TabIndex = 19;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // userSearchBox
            // 
            this.userSearchBox.Location = new System.Drawing.Point(10, 12);
            this.userSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userSearchBox.Name = "userSearchBox";
            this.userSearchBox.Size = new System.Drawing.Size(205, 26);
            this.userSearchBox.TabIndex = 18;
            this.userSearchBox.Text = "Search by name";
            this.userSearchBox.Click += new System.EventHandler(this.userSearchBox_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.loadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Location = new System.Drawing.Point(10, 305);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(159, 40);
            this.loadBtn.TabIndex = 8;
            this.loadBtn.Text = "Show all";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::AireworthVets.Properties.Resources.AVLogoicon;
            this.logoPictureBox.Location = new System.Drawing.Point(34, 18);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(192, 140);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // infoGB
            // 
            this.infoGB.Controls.Add(this.infoLabel);
            this.infoGB.Location = new System.Drawing.Point(744, 18);
            this.infoGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoGB.Name = "infoGB";
            this.infoGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoGB.Size = new System.Drawing.Size(249, 100);
            this.infoGB.TabIndex = 14;
            this.infoGB.TabStop = false;
            this.infoGB.Text = "Current user information";
            // 
            // motdClearBtn
            // 
            this.motdClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.motdClearBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.motdClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motdClearBtn.FlatAppearance.BorderSize = 0;
            this.motdClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motdClearBtn.Location = new System.Drawing.Point(414, 123);
            this.motdClearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.motdClearBtn.Name = "motdClearBtn";
            this.motdClearBtn.Size = new System.Drawing.Size(110, 35);
            this.motdClearBtn.TabIndex = 19;
            this.motdClearBtn.Text = "Clear";
            this.motdClearBtn.UseVisualStyleBackColor = false;
            this.motdClearBtn.Click += new System.EventHandler(this.motdClear_Click);
            // 
            // setMsgBtn
            // 
            this.setMsgBtn.BackColor = System.Drawing.Color.Transparent;
            this.setMsgBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.setMsgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setMsgBtn.FlatAppearance.BorderSize = 0;
            this.setMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setMsgBtn.Location = new System.Drawing.Point(249, 123);
            this.setMsgBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setMsgBtn.Name = "setMsgBtn";
            this.setMsgBtn.Size = new System.Drawing.Size(156, 35);
            this.setMsgBtn.TabIndex = 20;
            this.setMsgBtn.Text = "Set new message";
            this.setMsgBtn.UseVisualStyleBackColor = false;
            this.setMsgBtn.Click += new System.EventHandler(this.newMsgBtn_Click);
            // 
            // checkMsgTimer
            // 
            this.checkMsgTimer.Interval = 10000;
            this.checkMsgTimer.Tick += new System.EventHandler(this.checkMsgTimer_Tick);
            // 
            // refreshChk
            // 
            this.refreshChk.AutoSize = true;
            this.refreshChk.Checked = true;
            this.refreshChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refreshChk.Location = new System.Drawing.Point(534, 129);
            this.refreshChk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshChk.Name = "refreshChk";
            this.refreshChk.Size = new System.Drawing.Size(130, 24);
            this.refreshChk.TabIndex = 21;
            this.refreshChk.Text = "Auto Refresh";
            this.refreshChk.UseVisualStyleBackColor = true;
            this.refreshChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 898);
            this.Controls.Add(this.refreshChk);
            this.Controls.Add(this.setMsgBtn);
            this.Controls.Add(this.motdClearBtn);
            this.Controls.Add(this.infoGB);
            this.Controls.Add(this.dataTab);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.motdRichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "Aireworth Veterinary Practice";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataView)).EndInit();
            this.dataTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.addShiftBox.ResumeLayout(false);
            this.addShiftBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftDataView)).EndInit();
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.infoGB.ResumeLayout(false);
            this.infoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox motdRichTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.DataGridView userDataView;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TabControl dataTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button allShiftsBtn;
        private System.Windows.Forms.Button myShiftsBtn;
        public System.Windows.Forms.DataGridView shiftDataView;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.TextBox shiftSearchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox userSearchBox;
        public System.Windows.Forms.GroupBox addShiftBox;
        private System.Windows.Forms.DateTimePicker startDate;
        public System.Windows.Forms.ComboBox shiftUserCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox shiftRoleCombo;
        private System.Windows.Forms.RichTextBox commentsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createUserBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox adminChck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox defChck;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox shiftIDTextBox;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox infoGB;
        private System.Windows.Forms.Button motdClearBtn;
        private System.Windows.Forms.Button setMsgBtn;
        public System.Windows.Forms.Timer checkMsgTimer;
        private System.Windows.Forms.CheckBox refreshChk;
    }
}
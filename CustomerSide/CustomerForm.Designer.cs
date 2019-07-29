namespace ClientSide
{
    partial class CustomerForm
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
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.EnquiryTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnquiryInformationPanel = new System.Windows.Forms.Panel();
            this.CurrentConsumptionEnquiryLabel = new System.Windows.Forms.Label();
            this.MonthlyLimitEnquiryLabel = new System.Windows.Forms.Label();
            this.CarNumberEnquiryLabel = new System.Windows.Forms.Label();
            this.CardNumberEnquiryLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnquiryMessage = new System.Windows.Forms.Label();
            this.EnquiryButton = new System.Windows.Forms.Button();
            this.CardNumberEnquiry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FillEnquiryTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FillInformationPanel = new System.Windows.Forms.Panel();
            this.DateFillLabel = new System.Windows.Forms.Label();
            this.LastConsumptionFillLabel = new System.Windows.Forms.Label();
            this.CurrentConsumptionFillLabel = new System.Windows.Forms.Label();
            this.RemainingFuelFillLabel = new System.Windows.Forms.Label();
            this.MonthlyLimitFillLabel = new System.Windows.Forms.Label();
            this.CarNumberFillLabel = new System.Windows.Forms.Label();
            this.CardNumberFillLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FillMessage = new System.Windows.Forms.Label();
            this.ConsumeButton = new System.Windows.Forms.Button();
            this.ConsumptionAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CardNumberFill = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TabsControl.SuspendLayout();
            this.EnquiryTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.EnquiryInformationPanel.SuspendLayout();
            this.FillEnquiryTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.FillInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabsControl
            // 
            this.TabsControl.Controls.Add(this.EnquiryTabPage);
            this.TabsControl.Controls.Add(this.FillEnquiryTab);
            this.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsControl.ItemSize = new System.Drawing.Size(500, 25);
            this.TabsControl.Location = new System.Drawing.Point(0, 0);
            this.TabsControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(1005, 690);
            this.TabsControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabsControl.TabIndex = 0;
            this.TabsControl.SelectedIndexChanged += new System.EventHandler(this.TabsControl_SelectedIndexChanged);
            // 
            // EnquiryTabPage
            // 
            this.EnquiryTabPage.Controls.Add(this.groupBox1);
            this.EnquiryTabPage.Controls.Add(this.label1);
            this.EnquiryTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnquiryTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.EnquiryTabPage.Name = "EnquiryTabPage";
            this.EnquiryTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.EnquiryTabPage.Size = new System.Drawing.Size(997, 657);
            this.EnquiryTabPage.TabIndex = 0;
            this.EnquiryTabPage.Text = "Enquiry Interface";
            this.EnquiryTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnquiryInformationPanel);
            this.groupBox1.Controls.Add(this.EnquiryMessage);
            this.groupBox1.Controls.Add(this.EnquiryButton);
            this.groupBox1.Controls.Add(this.CardNumberEnquiry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBox1.Location = new System.Drawing.Point(87, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 528);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquiry form";
            // 
            // EnquiryInformationPanel
            // 
            this.EnquiryInformationPanel.Controls.Add(this.CurrentConsumptionEnquiryLabel);
            this.EnquiryInformationPanel.Controls.Add(this.MonthlyLimitEnquiryLabel);
            this.EnquiryInformationPanel.Controls.Add(this.CarNumberEnquiryLabel);
            this.EnquiryInformationPanel.Controls.Add(this.CardNumberEnquiryLabel);
            this.EnquiryInformationPanel.Controls.Add(this.label7);
            this.EnquiryInformationPanel.Controls.Add(this.label6);
            this.EnquiryInformationPanel.Controls.Add(this.label5);
            this.EnquiryInformationPanel.Controls.Add(this.label4);
            this.EnquiryInformationPanel.Controls.Add(this.label3);
            this.EnquiryInformationPanel.Location = new System.Drawing.Point(31, 250);
            this.EnquiryInformationPanel.Name = "EnquiryInformationPanel";
            this.EnquiryInformationPanel.Size = new System.Drawing.Size(760, 272);
            this.EnquiryInformationPanel.TabIndex = 4;
            this.EnquiryInformationPanel.Visible = false;
            // 
            // CurrentConsumptionEnquiryLabel
            // 
            this.CurrentConsumptionEnquiryLabel.AutoSize = true;
            this.CurrentConsumptionEnquiryLabel.ForeColor = System.Drawing.Color.Blue;
            this.CurrentConsumptionEnquiryLabel.Location = new System.Drawing.Point(558, 227);
            this.CurrentConsumptionEnquiryLabel.Name = "CurrentConsumptionEnquiryLabel";
            this.CurrentConsumptionEnquiryLabel.Size = new System.Drawing.Size(65, 23);
            this.CurrentConsumptionEnquiryLabel.TabIndex = 8;
            this.CurrentConsumptionEnquiryLabel.Text = "Empty";
            // 
            // MonthlyLimitEnquiryLabel
            // 
            this.MonthlyLimitEnquiryLabel.AutoSize = true;
            this.MonthlyLimitEnquiryLabel.ForeColor = System.Drawing.Color.Blue;
            this.MonthlyLimitEnquiryLabel.Location = new System.Drawing.Point(558, 172);
            this.MonthlyLimitEnquiryLabel.Name = "MonthlyLimitEnquiryLabel";
            this.MonthlyLimitEnquiryLabel.Size = new System.Drawing.Size(65, 23);
            this.MonthlyLimitEnquiryLabel.TabIndex = 7;
            this.MonthlyLimitEnquiryLabel.Text = "Empty";
            // 
            // CarNumberEnquiryLabel
            // 
            this.CarNumberEnquiryLabel.AutoSize = true;
            this.CarNumberEnquiryLabel.ForeColor = System.Drawing.Color.Blue;
            this.CarNumberEnquiryLabel.Location = new System.Drawing.Point(558, 117);
            this.CarNumberEnquiryLabel.Name = "CarNumberEnquiryLabel";
            this.CarNumberEnquiryLabel.Size = new System.Drawing.Size(65, 23);
            this.CarNumberEnquiryLabel.TabIndex = 6;
            this.CarNumberEnquiryLabel.Text = "Empty";
            // 
            // CardNumberEnquiryLabel
            // 
            this.CardNumberEnquiryLabel.AutoSize = true;
            this.CardNumberEnquiryLabel.ForeColor = System.Drawing.Color.Blue;
            this.CardNumberEnquiryLabel.Location = new System.Drawing.Point(558, 62);
            this.CardNumberEnquiryLabel.Name = "CardNumberEnquiryLabel";
            this.CardNumberEnquiryLabel.Size = new System.Drawing.Size(65, 23);
            this.CardNumberEnquiryLabel.TabIndex = 5;
            this.CardNumberEnquiryLabel.Text = "Empty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Current consumption:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Monthly limit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Car number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Card number:";
            // 
            // EnquiryMessage
            // 
            this.EnquiryMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnquiryMessage.AutoSize = true;
            this.EnquiryMessage.Font = new System.Drawing.Font("Consolas", 14F);
            this.EnquiryMessage.Location = new System.Drawing.Point(16, 196);
            this.EnquiryMessage.MaximumSize = new System.Drawing.Size(800, 0);
            this.EnquiryMessage.MinimumSize = new System.Drawing.Size(800, 0);
            this.EnquiryMessage.Name = "EnquiryMessage";
            this.EnquiryMessage.Size = new System.Drawing.Size(800, 28);
            this.EnquiryMessage.TabIndex = 3;
            this.EnquiryMessage.Text = "Hidden";
            this.EnquiryMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnquiryMessage.Visible = false;
            // 
            // EnquiryButton
            // 
            this.EnquiryButton.Location = new System.Drawing.Point(31, 134);
            this.EnquiryButton.Name = "EnquiryButton";
            this.EnquiryButton.Size = new System.Drawing.Size(760, 50);
            this.EnquiryButton.TabIndex = 2;
            this.EnquiryButton.Text = "Enquiry";
            this.EnquiryButton.UseVisualStyleBackColor = true;
            this.EnquiryButton.Click += new System.EventHandler(this.EnquiryButton_Click);
            // 
            // CardNumberEnquiry
            // 
            this.CardNumberEnquiry.Location = new System.Drawing.Point(322, 63);
            this.CardNumberEnquiry.Name = "CardNumberEnquiry";
            this.CardNumberEnquiry.Size = new System.Drawing.Size(470, 31);
            this.CardNumberEnquiry.TabIndex = 1;
            this.CardNumberEnquiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input card number here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F);
            this.label1.Location = new System.Drawing.Point(328, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enquiry interface";
            // 
            // FillEnquiryTab
            // 
            this.FillEnquiryTab.Controls.Add(this.groupBox2);
            this.FillEnquiryTab.Controls.Add(this.label8);
            this.FillEnquiryTab.Location = new System.Drawing.Point(4, 29);
            this.FillEnquiryTab.Margin = new System.Windows.Forms.Padding(4);
            this.FillEnquiryTab.Name = "FillEnquiryTab";
            this.FillEnquiryTab.Padding = new System.Windows.Forms.Padding(4);
            this.FillEnquiryTab.Size = new System.Drawing.Size(997, 657);
            this.FillEnquiryTab.TabIndex = 1;
            this.FillEnquiryTab.Text = "Fill Interface";
            this.FillEnquiryTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FillInformationPanel);
            this.groupBox2.Controls.Add(this.FillMessage);
            this.groupBox2.Controls.Add(this.ConsumeButton);
            this.groupBox2.Controls.Add(this.ConsumptionAmount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CardNumberFill);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBox2.Location = new System.Drawing.Point(87, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 528);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill form";
            // 
            // FillInformationPanel
            // 
            this.FillInformationPanel.Controls.Add(this.DateFillLabel);
            this.FillInformationPanel.Controls.Add(this.LastConsumptionFillLabel);
            this.FillInformationPanel.Controls.Add(this.CurrentConsumptionFillLabel);
            this.FillInformationPanel.Controls.Add(this.RemainingFuelFillLabel);
            this.FillInformationPanel.Controls.Add(this.MonthlyLimitFillLabel);
            this.FillInformationPanel.Controls.Add(this.CarNumberFillLabel);
            this.FillInformationPanel.Controls.Add(this.CardNumberFillLabel);
            this.FillInformationPanel.Controls.Add(this.label18);
            this.FillInformationPanel.Controls.Add(this.label17);
            this.FillInformationPanel.Controls.Add(this.label16);
            this.FillInformationPanel.Controls.Add(this.label15);
            this.FillInformationPanel.Controls.Add(this.label14);
            this.FillInformationPanel.Controls.Add(this.label13);
            this.FillInformationPanel.Controls.Add(this.label12);
            this.FillInformationPanel.Controls.Add(this.label11);
            this.FillInformationPanel.Location = new System.Drawing.Point(6, 278);
            this.FillInformationPanel.Name = "FillInformationPanel";
            this.FillInformationPanel.Size = new System.Drawing.Size(810, 244);
            this.FillInformationPanel.TabIndex = 7;
            this.FillInformationPanel.Visible = false;
            // 
            // DateFillLabel
            // 
            this.DateFillLabel.AutoSize = true;
            this.DateFillLabel.ForeColor = System.Drawing.Color.Blue;
            this.DateFillLabel.Location = new System.Drawing.Point(644, 153);
            this.DateFillLabel.Name = "DateFillLabel";
            this.DateFillLabel.Size = new System.Drawing.Size(65, 23);
            this.DateFillLabel.TabIndex = 19;
            this.DateFillLabel.Text = "Empty";
            // 
            // LastConsumptionFillLabel
            // 
            this.LastConsumptionFillLabel.AutoSize = true;
            this.LastConsumptionFillLabel.ForeColor = System.Drawing.Color.Blue;
            this.LastConsumptionFillLabel.Location = new System.Drawing.Point(644, 106);
            this.LastConsumptionFillLabel.Name = "LastConsumptionFillLabel";
            this.LastConsumptionFillLabel.Size = new System.Drawing.Size(65, 23);
            this.LastConsumptionFillLabel.TabIndex = 18;
            this.LastConsumptionFillLabel.Text = "Empty";
            // 
            // CurrentConsumptionFillLabel
            // 
            this.CurrentConsumptionFillLabel.AutoSize = true;
            this.CurrentConsumptionFillLabel.ForeColor = System.Drawing.Color.Blue;
            this.CurrentConsumptionFillLabel.Location = new System.Drawing.Point(644, 60);
            this.CurrentConsumptionFillLabel.Name = "CurrentConsumptionFillLabel";
            this.CurrentConsumptionFillLabel.Size = new System.Drawing.Size(65, 23);
            this.CurrentConsumptionFillLabel.TabIndex = 17;
            this.CurrentConsumptionFillLabel.Text = "Empty";
            // 
            // RemainingFuelFillLabel
            // 
            this.RemainingFuelFillLabel.AutoSize = true;
            this.RemainingFuelFillLabel.ForeColor = System.Drawing.Color.Blue;
            this.RemainingFuelFillLabel.Location = new System.Drawing.Point(227, 203);
            this.RemainingFuelFillLabel.Name = "RemainingFuelFillLabel";
            this.RemainingFuelFillLabel.Size = new System.Drawing.Size(65, 23);
            this.RemainingFuelFillLabel.TabIndex = 16;
            this.RemainingFuelFillLabel.Text = "Empty";
            // 
            // MonthlyLimitFillLabel
            // 
            this.MonthlyLimitFillLabel.AutoSize = true;
            this.MonthlyLimitFillLabel.ForeColor = System.Drawing.Color.Blue;
            this.MonthlyLimitFillLabel.Location = new System.Drawing.Point(227, 153);
            this.MonthlyLimitFillLabel.Name = "MonthlyLimitFillLabel";
            this.MonthlyLimitFillLabel.Size = new System.Drawing.Size(65, 23);
            this.MonthlyLimitFillLabel.TabIndex = 15;
            this.MonthlyLimitFillLabel.Text = "Empty";
            // 
            // CarNumberFillLabel
            // 
            this.CarNumberFillLabel.AutoSize = true;
            this.CarNumberFillLabel.ForeColor = System.Drawing.Color.Blue;
            this.CarNumberFillLabel.Location = new System.Drawing.Point(227, 106);
            this.CarNumberFillLabel.Name = "CarNumberFillLabel";
            this.CarNumberFillLabel.Size = new System.Drawing.Size(65, 23);
            this.CarNumberFillLabel.TabIndex = 14;
            this.CarNumberFillLabel.Text = "Empty";
            // 
            // CardNumberFillLabel
            // 
            this.CardNumberFillLabel.AutoSize = true;
            this.CardNumberFillLabel.ForeColor = System.Drawing.Color.Blue;
            this.CardNumberFillLabel.Location = new System.Drawing.Point(227, 60);
            this.CardNumberFillLabel.Name = "CardNumberFillLabel";
            this.CardNumberFillLabel.Size = new System.Drawing.Size(65, 23);
            this.CardNumberFillLabel.TabIndex = 13;
            this.CardNumberFillLabel.Text = "Empty";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(434, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 23);
            this.label18.TabIndex = 12;
            this.label18.Text = "Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(434, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 23);
            this.label17.TabIndex = 11;
            this.label17.Text = "Last consumption:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(434, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 23);
            this.label16.TabIndex = 10;
            this.label16.Text = "Consumed fuel:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 23);
            this.label15.TabIndex = 9;
            this.label15.Text = "Remaining fuel:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Monthly limit:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "Car number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Card number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Information";
            // 
            // FillMessage
            // 
            this.FillMessage.AutoSize = true;
            this.FillMessage.Font = new System.Drawing.Font("Consolas", 14F);
            this.FillMessage.Location = new System.Drawing.Point(16, 232);
            this.FillMessage.MaximumSize = new System.Drawing.Size(800, 0);
            this.FillMessage.MinimumSize = new System.Drawing.Size(800, 0);
            this.FillMessage.Name = "FillMessage";
            this.FillMessage.Size = new System.Drawing.Size(800, 28);
            this.FillMessage.TabIndex = 6;
            this.FillMessage.Text = "Hidden";
            this.FillMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FillMessage.Visible = false;
            // 
            // ConsumeButton
            // 
            this.ConsumeButton.Location = new System.Drawing.Point(35, 179);
            this.ConsumeButton.Name = "ConsumeButton";
            this.ConsumeButton.Size = new System.Drawing.Size(757, 50);
            this.ConsumeButton.TabIndex = 5;
            this.ConsumeButton.Text = "Consume fuel";
            this.ConsumeButton.UseVisualStyleBackColor = true;
            this.ConsumeButton.Click += new System.EventHandler(this.ConsumeButton_Click);
            // 
            // ConsumptionAmount
            // 
            this.ConsumptionAmount.Location = new System.Drawing.Point(322, 121);
            this.ConsumptionAmount.Name = "ConsumptionAmount";
            this.ConsumptionAmount.Size = new System.Drawing.Size(470, 31);
            this.ConsumptionAmount.TabIndex = 4;
            this.ConsumptionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Input consumption amount:";
            // 
            // CardNumberFill
            // 
            this.CardNumberFill.Location = new System.Drawing.Point(322, 65);
            this.CardNumberFill.Name = "CardNumberFill";
            this.CardNumberFill.Size = new System.Drawing.Size(470, 31);
            this.CardNumberFill.TabIndex = 2;
            this.CardNumberFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Input card number here:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 20F);
            this.label8.Location = new System.Drawing.Point(357, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 40);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fill interface";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 690);
            this.Controls.Add(this.TabsControl);
            this.Font = new System.Drawing.Font("Consolas", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1023, 737);
            this.MinimumSize = new System.Drawing.Size(1023, 737);
            this.Name = "CustomerForm";
            this.Text = "Online Smart Card System - Enquiry Interface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabsControl.ResumeLayout(false);
            this.EnquiryTabPage.ResumeLayout(false);
            this.EnquiryTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.EnquiryInformationPanel.ResumeLayout(false);
            this.EnquiryInformationPanel.PerformLayout();
            this.FillEnquiryTab.ResumeLayout(false);
            this.FillEnquiryTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.FillInformationPanel.ResumeLayout(false);
            this.FillInformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.TabPage EnquiryTabPage;
        private System.Windows.Forms.TabPage FillEnquiryTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CardNumberEnquiry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EnquiryMessage;
        private System.Windows.Forms.Button EnquiryButton;
        private System.Windows.Forms.Panel EnquiryInformationPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CurrentConsumptionEnquiryLabel;
        private System.Windows.Forms.Label MonthlyLimitEnquiryLabel;
        private System.Windows.Forms.Label CarNumberEnquiryLabel;
        private System.Windows.Forms.Label CardNumberEnquiryLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ConsumptionAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CardNumberFill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FillMessage;
        private System.Windows.Forms.Button ConsumeButton;
        private System.Windows.Forms.Panel FillInformationPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DateFillLabel;
        private System.Windows.Forms.Label LastConsumptionFillLabel;
        private System.Windows.Forms.Label CurrentConsumptionFillLabel;
        private System.Windows.Forms.Label RemainingFuelFillLabel;
        private System.Windows.Forms.Label MonthlyLimitFillLabel;
        private System.Windows.Forms.Label CarNumberFillLabel;
        private System.Windows.Forms.Label CardNumberFillLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;

    }
}


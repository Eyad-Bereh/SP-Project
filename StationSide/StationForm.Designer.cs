namespace StationSide
{
    partial class StationForm
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
            this.AddCardTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddCardMessage = new System.Windows.Forms.Label();
            this.Add_MonthlyLimitLabel = new System.Windows.Forms.Label();
            this.Add_CarNumberLabel = new System.Windows.Forms.Label();
            this.Add_CardNumberLabel = new System.Windows.Forms.Label();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.Add_MonthlyLimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_CarNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_CardNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveCardTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveCardMessage = new System.Windows.Forms.Label();
            this.Remove_CardNumberLabel = new System.Windows.Forms.Label();
            this.RemoveCardButton = new System.Windows.Forms.Button();
            this.Remove_CardNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateCardTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UpdateCardPanel = new System.Windows.Forms.Panel();
            this.UpdateCardMessage = new System.Windows.Forms.Label();
            this.UpdateCardButton = new System.Windows.Forms.Button();
            this.Update_MonthlyLimitLabel = new System.Windows.Forms.Label();
            this.Update_MonthlyLimit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Update_CarNumberLabel = new System.Windows.Forms.Label();
            this.Update_CarNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Update_CardNumberLabel = new System.Windows.Forms.Label();
            this.FetchCardButton = new System.Windows.Forms.Button();
            this.Update_CardNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Update_CurrentConsumption = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TabsControl.SuspendLayout();
            this.AddCardTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RemoveCardTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.UpdateCardTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.UpdateCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabsControl
            // 
            this.TabsControl.Controls.Add(this.AddCardTabPage);
            this.TabsControl.Controls.Add(this.RemoveCardTabPage);
            this.TabsControl.Controls.Add(this.UpdateCardTabPage);
            this.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsControl.ItemSize = new System.Drawing.Size(330, 25);
            this.TabsControl.Location = new System.Drawing.Point(0, 0);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(1005, 690);
            this.TabsControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabsControl.TabIndex = 0;
            this.TabsControl.SelectedIndexChanged += new System.EventHandler(this.TabsControl_SelectedIndexChanged);
            // 
            // AddCardTabPage
            // 
            this.AddCardTabPage.Controls.Add(this.groupBox1);
            this.AddCardTabPage.Controls.Add(this.label1);
            this.AddCardTabPage.Location = new System.Drawing.Point(4, 29);
            this.AddCardTabPage.Name = "AddCardTabPage";
            this.AddCardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddCardTabPage.Size = new System.Drawing.Size(997, 657);
            this.AddCardTabPage.TabIndex = 0;
            this.AddCardTabPage.Text = "Add Card";
            this.AddCardTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCardMessage);
            this.groupBox1.Controls.Add(this.Add_MonthlyLimitLabel);
            this.groupBox1.Controls.Add(this.Add_CarNumberLabel);
            this.groupBox1.Controls.Add(this.Add_CardNumberLabel);
            this.groupBox1.Controls.Add(this.AddCardButton);
            this.groupBox1.Controls.Add(this.Add_MonthlyLimit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Add_CarNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Add_CardNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBox1.Location = new System.Drawing.Point(31, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 513);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add card form";
            // 
            // AddCardMessage
            // 
            this.AddCardMessage.AutoSize = true;
            this.AddCardMessage.Location = new System.Drawing.Point(59, 439);
            this.AddCardMessage.MaximumSize = new System.Drawing.Size(800, 30);
            this.AddCardMessage.MinimumSize = new System.Drawing.Size(800, 30);
            this.AddCardMessage.Name = "AddCardMessage";
            this.AddCardMessage.Size = new System.Drawing.Size(800, 30);
            this.AddCardMessage.TabIndex = 10;
            this.AddCardMessage.Text = "Hidden";
            this.AddCardMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddCardMessage.Visible = false;
            // 
            // Add_MonthlyLimitLabel
            // 
            this.Add_MonthlyLimitLabel.AutoSize = true;
            this.Add_MonthlyLimitLabel.Location = new System.Drawing.Point(561, 223);
            this.Add_MonthlyLimitLabel.Name = "Add_MonthlyLimitLabel";
            this.Add_MonthlyLimitLabel.Size = new System.Drawing.Size(76, 23);
            this.Add_MonthlyLimitLabel.TabIndex = 9;
            this.Add_MonthlyLimitLabel.Text = "Hidden";
            this.Add_MonthlyLimitLabel.Visible = false;
            // 
            // Add_CarNumberLabel
            // 
            this.Add_CarNumberLabel.AutoSize = true;
            this.Add_CarNumberLabel.Location = new System.Drawing.Point(561, 143);
            this.Add_CarNumberLabel.Name = "Add_CarNumberLabel";
            this.Add_CarNumberLabel.Size = new System.Drawing.Size(76, 23);
            this.Add_CarNumberLabel.TabIndex = 8;
            this.Add_CarNumberLabel.Text = "Hidden";
            this.Add_CarNumberLabel.Visible = false;
            // 
            // Add_CardNumberLabel
            // 
            this.Add_CardNumberLabel.AutoSize = true;
            this.Add_CardNumberLabel.Location = new System.Drawing.Point(561, 63);
            this.Add_CardNumberLabel.Name = "Add_CardNumberLabel";
            this.Add_CardNumberLabel.Size = new System.Drawing.Size(76, 23);
            this.Add_CardNumberLabel.TabIndex = 7;
            this.Add_CardNumberLabel.Text = "Hidden";
            this.Add_CardNumberLabel.Visible = false;
            // 
            // AddCardButton
            // 
            this.AddCardButton.Location = new System.Drawing.Point(125, 330);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(685, 56);
            this.AddCardButton.TabIndex = 6;
            this.AddCardButton.Text = "Add Card";
            this.AddCardButton.UseVisualStyleBackColor = true;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // Add_MonthlyLimit
            // 
            this.Add_MonthlyLimit.Location = new System.Drawing.Point(248, 220);
            this.Add_MonthlyLimit.Name = "Add_MonthlyLimit";
            this.Add_MonthlyLimit.Size = new System.Drawing.Size(257, 31);
            this.Add_MonthlyLimit.TabIndex = 5;
            this.Add_MonthlyLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monthly limit:";
            // 
            // Add_CarNumber
            // 
            this.Add_CarNumber.Location = new System.Drawing.Point(248, 140);
            this.Add_CarNumber.Name = "Add_CarNumber";
            this.Add_CarNumber.Size = new System.Drawing.Size(257, 31);
            this.Add_CarNumber.TabIndex = 3;
            this.Add_CarNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Car number:";
            // 
            // Add_CardNumber
            // 
            this.Add_CardNumber.Location = new System.Drawing.Point(248, 60);
            this.Add_CardNumber.Name = "Add_CardNumber";
            this.Add_CardNumber.Size = new System.Drawing.Size(257, 31);
            this.Add_CardNumber.TabIndex = 1;
            this.Add_CardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Card number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F);
            this.label1.Location = new System.Drawing.Point(366, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add interface";
            // 
            // RemoveCardTabPage
            // 
            this.RemoveCardTabPage.Controls.Add(this.groupBox2);
            this.RemoveCardTabPage.Controls.Add(this.label2);
            this.RemoveCardTabPage.Location = new System.Drawing.Point(4, 29);
            this.RemoveCardTabPage.Name = "RemoveCardTabPage";
            this.RemoveCardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RemoveCardTabPage.Size = new System.Drawing.Size(997, 657);
            this.RemoveCardTabPage.TabIndex = 1;
            this.RemoveCardTabPage.Text = "Remove Card";
            this.RemoveCardTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveCardMessage);
            this.groupBox2.Controls.Add(this.Remove_CardNumberLabel);
            this.groupBox2.Controls.Add(this.RemoveCardButton);
            this.groupBox2.Controls.Add(this.Remove_CardNumber);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBox2.Location = new System.Drawing.Point(91, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 352);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove card form";
            // 
            // RemoveCardMessage
            // 
            this.RemoveCardMessage.AutoSize = true;
            this.RemoveCardMessage.Location = new System.Drawing.Point(6, 271);
            this.RemoveCardMessage.MaximumSize = new System.Drawing.Size(800, 30);
            this.RemoveCardMessage.MinimumSize = new System.Drawing.Size(800, 30);
            this.RemoveCardMessage.Name = "RemoveCardMessage";
            this.RemoveCardMessage.Size = new System.Drawing.Size(800, 30);
            this.RemoveCardMessage.TabIndex = 10;
            this.RemoveCardMessage.Text = "Hidden";
            this.RemoveCardMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RemoveCardMessage.Visible = false;
            // 
            // Remove_CardNumberLabel
            // 
            this.Remove_CardNumberLabel.AutoSize = true;
            this.Remove_CardNumberLabel.Location = new System.Drawing.Point(560, 63);
            this.Remove_CardNumberLabel.Name = "Remove_CardNumberLabel";
            this.Remove_CardNumberLabel.Size = new System.Drawing.Size(76, 23);
            this.Remove_CardNumberLabel.TabIndex = 7;
            this.Remove_CardNumberLabel.Text = "Hidden";
            this.Remove_CardNumberLabel.Visible = false;
            // 
            // RemoveCardButton
            // 
            this.RemoveCardButton.Location = new System.Drawing.Point(65, 161);
            this.RemoveCardButton.Name = "RemoveCardButton";
            this.RemoveCardButton.Size = new System.Drawing.Size(685, 56);
            this.RemoveCardButton.TabIndex = 6;
            this.RemoveCardButton.Text = "Remove Card";
            this.RemoveCardButton.UseVisualStyleBackColor = true;
            this.RemoveCardButton.Click += new System.EventHandler(this.RemoveCardButton_Click);
            // 
            // Remove_CardNumber
            // 
            this.Remove_CardNumber.Location = new System.Drawing.Point(282, 60);
            this.Remove_CardNumber.Name = "Remove_CardNumber";
            this.Remove_CardNumber.Size = new System.Drawing.Size(257, 31);
            this.Remove_CardNumber.TabIndex = 1;
            this.Remove_CardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Card number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20F);
            this.label2.Location = new System.Drawing.Point(338, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remove interface";
            // 
            // UpdateCardTabPage
            // 
            this.UpdateCardTabPage.Controls.Add(this.groupBox3);
            this.UpdateCardTabPage.Controls.Add(this.label3);
            this.UpdateCardTabPage.Location = new System.Drawing.Point(4, 29);
            this.UpdateCardTabPage.Name = "UpdateCardTabPage";
            this.UpdateCardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateCardTabPage.Size = new System.Drawing.Size(997, 657);
            this.UpdateCardTabPage.TabIndex = 2;
            this.UpdateCardTabPage.Text = "Update Card";
            this.UpdateCardTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UpdateCardPanel);
            this.groupBox3.Controls.Add(this.Update_CardNumberLabel);
            this.groupBox3.Controls.Add(this.FetchCardButton);
            this.groupBox3.Controls.Add(this.Update_CardNumber);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBox3.Location = new System.Drawing.Point(91, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 593);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add card form";
            // 
            // UpdateCardPanel
            // 
            this.UpdateCardPanel.Controls.Add(this.UpdateCardMessage);
            this.UpdateCardPanel.Controls.Add(this.UpdateCardButton);
            this.UpdateCardPanel.Controls.Add(this.label12);
            this.UpdateCardPanel.Controls.Add(this.Update_CurrentConsumption);
            this.UpdateCardPanel.Controls.Add(this.label11);
            this.UpdateCardPanel.Controls.Add(this.Update_MonthlyLimitLabel);
            this.UpdateCardPanel.Controls.Add(this.Update_MonthlyLimit);
            this.UpdateCardPanel.Controls.Add(this.label10);
            this.UpdateCardPanel.Controls.Add(this.Update_CarNumberLabel);
            this.UpdateCardPanel.Controls.Add(this.Update_CarNumber);
            this.UpdateCardPanel.Controls.Add(this.label9);
            this.UpdateCardPanel.Location = new System.Drawing.Point(43, 198);
            this.UpdateCardPanel.Name = "UpdateCardPanel";
            this.UpdateCardPanel.Size = new System.Drawing.Size(728, 389);
            this.UpdateCardPanel.TabIndex = 8;
            this.UpdateCardPanel.Visible = false;
            // 
            // UpdateCardMessage
            // 
            this.UpdateCardMessage.AutoSize = true;
            this.UpdateCardMessage.Location = new System.Drawing.Point(64, 340);
            this.UpdateCardMessage.MaximumSize = new System.Drawing.Size(600, 30);
            this.UpdateCardMessage.MinimumSize = new System.Drawing.Size(600, 30);
            this.UpdateCardMessage.Name = "UpdateCardMessage";
            this.UpdateCardMessage.Size = new System.Drawing.Size(600, 30);
            this.UpdateCardMessage.TabIndex = 19;
            this.UpdateCardMessage.Text = "Hidden";
            this.UpdateCardMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateCardMessage.Visible = false;
            // 
            // UpdateCardButton
            // 
            this.UpdateCardButton.Location = new System.Drawing.Point(42, 266);
            this.UpdateCardButton.Name = "UpdateCardButton";
            this.UpdateCardButton.Size = new System.Drawing.Size(644, 60);
            this.UpdateCardButton.TabIndex = 18;
            this.UpdateCardButton.Text = "Update Card";
            this.UpdateCardButton.UseVisualStyleBackColor = true;
            this.UpdateCardButton.Click += new System.EventHandler(this.UpdateCardButton_Click);
            // 
            // Update_MonthlyLimitLabel
            // 
            this.Update_MonthlyLimitLabel.AutoSize = true;
            this.Update_MonthlyLimitLabel.Location = new System.Drawing.Point(538, 116);
            this.Update_MonthlyLimitLabel.Name = "Update_MonthlyLimitLabel";
            this.Update_MonthlyLimitLabel.Size = new System.Drawing.Size(76, 23);
            this.Update_MonthlyLimitLabel.TabIndex = 13;
            this.Update_MonthlyLimitLabel.Text = "Hidden";
            this.Update_MonthlyLimitLabel.Visible = false;
            // 
            // Update_MonthlyLimit
            // 
            this.Update_MonthlyLimit.Location = new System.Drawing.Point(267, 114);
            this.Update_MonthlyLimit.Name = "Update_MonthlyLimit";
            this.Update_MonthlyLimit.Size = new System.Drawing.Size(257, 31);
            this.Update_MonthlyLimit.TabIndex = 12;
            this.Update_MonthlyLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Monthly limit:";
            // 
            // Update_CarNumberLabel
            // 
            this.Update_CarNumberLabel.AutoSize = true;
            this.Update_CarNumberLabel.Location = new System.Drawing.Point(538, 43);
            this.Update_CarNumberLabel.Name = "Update_CarNumberLabel";
            this.Update_CarNumberLabel.Size = new System.Drawing.Size(76, 23);
            this.Update_CarNumberLabel.TabIndex = 10;
            this.Update_CarNumberLabel.Text = "Hidden";
            this.Update_CarNumberLabel.Visible = false;
            // 
            // Update_CarNumber
            // 
            this.Update_CarNumber.Location = new System.Drawing.Point(265, 40);
            this.Update_CarNumber.Name = "Update_CarNumber";
            this.Update_CarNumber.Size = new System.Drawing.Size(257, 31);
            this.Update_CarNumber.TabIndex = 9;
            this.Update_CarNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Car number:";
            // 
            // Update_CardNumberLabel
            // 
            this.Update_CardNumberLabel.AutoSize = true;
            this.Update_CardNumberLabel.Location = new System.Drawing.Point(581, 63);
            this.Update_CardNumberLabel.Name = "Update_CardNumberLabel";
            this.Update_CardNumberLabel.Size = new System.Drawing.Size(76, 23);
            this.Update_CardNumberLabel.TabIndex = 7;
            this.Update_CardNumberLabel.Text = "Hidden";
            this.Update_CardNumberLabel.Visible = false;
            // 
            // FetchCardButton
            // 
            this.FetchCardButton.Location = new System.Drawing.Point(85, 117);
            this.FetchCardButton.Name = "FetchCardButton";
            this.FetchCardButton.Size = new System.Drawing.Size(644, 56);
            this.FetchCardButton.TabIndex = 6;
            this.FetchCardButton.Text = "Fetch Card";
            this.FetchCardButton.UseVisualStyleBackColor = true;
            this.FetchCardButton.Click += new System.EventHandler(this.FetchCardButton_Click);
            // 
            // Update_CardNumber
            // 
            this.Update_CardNumber.Location = new System.Drawing.Point(309, 60);
            this.Update_CardNumber.Name = "Update_CardNumber";
            this.Update_CardNumber.Size = new System.Drawing.Size(257, 31);
            this.Update_CardNumber.TabIndex = 1;
            this.Update_CardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(108, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Card number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20F);
            this.label3.Location = new System.Drawing.Point(338, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Update interface";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Current";
            // 
            // Update_CurrentConsumption
            // 
            this.Update_CurrentConsumption.Location = new System.Drawing.Point(267, 188);
            this.Update_CurrentConsumption.Name = "Update_CurrentConsumption";
            this.Update_CurrentConsumption.ReadOnly = true;
            this.Update_CurrentConsumption.Size = new System.Drawing.Size(257, 31);
            this.Update_CurrentConsumption.TabIndex = 15;
            this.Update_CurrentConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Consumption:";
            // 
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 690);
            this.Controls.Add(this.TabsControl);
            this.Font = new System.Drawing.Font("Consolas", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1023, 737);
            this.MinimumSize = new System.Drawing.Size(1023, 737);
            this.Name = "StationForm";
            this.Text = "Online Smart Card System - Add Card";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.TabsControl.ResumeLayout(false);
            this.AddCardTabPage.ResumeLayout(false);
            this.AddCardTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RemoveCardTabPage.ResumeLayout(false);
            this.RemoveCardTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.UpdateCardTabPage.ResumeLayout(false);
            this.UpdateCardTabPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.UpdateCardPanel.ResumeLayout(false);
            this.UpdateCardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.TabPage AddCardTabPage;
        private System.Windows.Forms.TabPage RemoveCardTabPage;
        private System.Windows.Forms.TabPage UpdateCardTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.TextBox Add_MonthlyLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Add_CarNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Add_CardNumber;
        private System.Windows.Forms.Label Add_MonthlyLimitLabel;
        private System.Windows.Forms.Label Add_CarNumberLabel;
        private System.Windows.Forms.Label Add_CardNumberLabel;
        private System.Windows.Forms.Label AddCardMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label RemoveCardMessage;
        private System.Windows.Forms.Label Remove_CardNumberLabel;
        private System.Windows.Forms.Button RemoveCardButton;
        private System.Windows.Forms.TextBox Remove_CardNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Update_CardNumberLabel;
        private System.Windows.Forms.Button FetchCardButton;
        private System.Windows.Forms.TextBox Update_CardNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel UpdateCardPanel;
        private System.Windows.Forms.Button UpdateCardButton;
        private System.Windows.Forms.Label Update_MonthlyLimitLabel;
        private System.Windows.Forms.TextBox Update_MonthlyLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Update_CarNumberLabel;
        private System.Windows.Forms.TextBox Update_CarNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label UpdateCardMessage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Update_CurrentConsumption;
        private System.Windows.Forms.Label label11;

    }
}


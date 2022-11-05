namespace SOLIDWORKS_PDM_Connectivity_Test_Tool
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DomainNameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.MachineNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LicenseServerDaemonTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LicenseServerPortTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LicenseServerHostTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LicenseServerCheckBox = new System.Windows.Forms.CheckBox();
            this.DataBasePortTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DataBaseHostTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataBaseCheckBox = new System.Windows.Forms.CheckBox();
            this.ArchiveServerPortTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ArchiveServerHostTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ArchiveServerCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TestButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.InfoGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 598);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.label4);
            this.InfoGroupBox.Controls.Add(this.label3);
            this.InfoGroupBox.Controls.Add(this.label2);
            this.InfoGroupBox.Controls.Add(this.DomainNameLabel);
            this.InfoGroupBox.Controls.Add(this.UserNameLabel);
            this.InfoGroupBox.Controls.Add(this.IPLabel);
            this.InfoGroupBox.Controls.Add(this.MachineNameLabel);
            this.InfoGroupBox.Controls.Add(this.label1);
            this.InfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoGroupBox.Location = new System.Drawing.Point(3, 84);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(371, 133);
            this.InfoGroupBox.TabIndex = 3;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Загальна інформація про систему";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ім\'я доменна:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ім\'я користувача:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP адреса:";
            // 
            // DomainNameLabel
            // 
            this.DomainNameLabel.AutoSize = true;
            this.DomainNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DomainNameLabel.Location = new System.Drawing.Point(154, 112);
            this.DomainNameLabel.Name = "DomainNameLabel";
            this.DomainNameLabel.Size = new System.Drawing.Size(101, 16);
            this.DomainNameLabel.TabIndex = 4;
            this.DomainNameLabel.Text = "DomainName";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(154, 81);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(81, 16);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "UserName";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPLabel.Location = new System.Drawing.Point(154, 52);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(21, 16);
            this.IPLabel.TabIndex = 2;
            this.IPLabel.Text = "IP";
            // 
            // MachineNameLabel
            // 
            this.MachineNameLabel.AutoSize = true;
            this.MachineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MachineNameLabel.Location = new System.Drawing.Point(154, 23);
            this.MachineNameLabel.Name = "MachineNameLabel";
            this.MachineNameLabel.Size = new System.Drawing.Size(106, 16);
            this.MachineNameLabel.TabIndex = 1;
            this.MachineNameLabel.Text = "MachineName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я машини:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LicenseServerDaemonTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LicenseServerPortTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LicenseServerHostTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LicenseServerCheckBox);
            this.groupBox1.Controls.Add(this.DataBasePortTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DataBaseHostTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DataBaseCheckBox);
            this.groupBox1.Controls.Add(this.ArchiveServerPortTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ArchiveServerHostTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ArchiveServerCheckBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сервер для тесту";
            // 
            // LicenseServerDaemonTextBox
            // 
            this.LicenseServerDaemonTextBox.Location = new System.Drawing.Point(174, 270);
            this.LicenseServerDaemonTextBox.Name = "LicenseServerDaemonTextBox";
            this.LicenseServerDaemonTextBox.Size = new System.Drawing.Size(180, 22);
            this.LicenseServerDaemonTextBox.TabIndex = 21;
            this.LicenseServerDaemonTextBox.Text = "25735";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Порт Daemon:";
            // 
            // LicenseServerPortTextBox
            // 
            this.LicenseServerPortTextBox.Location = new System.Drawing.Point(174, 242);
            this.LicenseServerPortTextBox.Name = "LicenseServerPortTextBox";
            this.LicenseServerPortTextBox.Size = new System.Drawing.Size(180, 22);
            this.LicenseServerPortTextBox.TabIndex = 19;
            this.LicenseServerPortTextBox.Text = "25734";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Порт:";
            // 
            // LicenseServerHostTextBox
            // 
            this.LicenseServerHostTextBox.Location = new System.Drawing.Point(174, 214);
            this.LicenseServerHostTextBox.Name = "LicenseServerHostTextBox";
            this.LicenseServerHostTextBox.Size = new System.Drawing.Size(180, 22);
            this.LicenseServerHostTextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Хост:";
            // 
            // LicenseServerCheckBox
            // 
            this.LicenseServerCheckBox.AutoSize = true;
            this.LicenseServerCheckBox.Location = new System.Drawing.Point(6, 193);
            this.LicenseServerCheckBox.Name = "LicenseServerCheckBox";
            this.LicenseServerCheckBox.Size = new System.Drawing.Size(171, 20);
            this.LicenseServerCheckBox.TabIndex = 15;
            this.LicenseServerCheckBox.Text = "Сервер ліцензування";
            this.LicenseServerCheckBox.UseVisualStyleBackColor = true;
            // 
            // DataBasePortTextBox
            // 
            this.DataBasePortTextBox.Location = new System.Drawing.Point(174, 155);
            this.DataBasePortTextBox.Name = "DataBasePortTextBox";
            this.DataBasePortTextBox.Size = new System.Drawing.Size(180, 22);
            this.DataBasePortTextBox.TabIndex = 14;
            this.DataBasePortTextBox.Text = "1433";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Порт:";
            // 
            // DataBaseHostTextBox
            // 
            this.DataBaseHostTextBox.Location = new System.Drawing.Point(174, 129);
            this.DataBaseHostTextBox.Name = "DataBaseHostTextBox";
            this.DataBaseHostTextBox.Size = new System.Drawing.Size(180, 22);
            this.DataBaseHostTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Хост:";
            // 
            // DataBaseCheckBox
            // 
            this.DataBaseCheckBox.AutoSize = true;
            this.DataBaseCheckBox.Location = new System.Drawing.Point(6, 108);
            this.DataBaseCheckBox.Name = "DataBaseCheckBox";
            this.DataBaseCheckBox.Size = new System.Drawing.Size(162, 20);
            this.DataBaseCheckBox.TabIndex = 10;
            this.DataBaseCheckBox.Text = "Сервер бази данних";
            this.DataBaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // ArchiveServerPortTextBox
            // 
            this.ArchiveServerPortTextBox.Location = new System.Drawing.Point(174, 71);
            this.ArchiveServerPortTextBox.Name = "ArchiveServerPortTextBox";
            this.ArchiveServerPortTextBox.Size = new System.Drawing.Size(180, 22);
            this.ArchiveServerPortTextBox.TabIndex = 9;
            this.ArchiveServerPortTextBox.Text = "3030";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Порт:";
            // 
            // ArchiveServerHostTextBox
            // 
            this.ArchiveServerHostTextBox.Location = new System.Drawing.Point(174, 43);
            this.ArchiveServerHostTextBox.Name = "ArchiveServerHostTextBox";
            this.ArchiveServerHostTextBox.Size = new System.Drawing.Size(180, 22);
            this.ArchiveServerHostTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Хост:";
            // 
            // ArchiveServerCheckBox
            // 
            this.ArchiveServerCheckBox.AutoSize = true;
            this.ArchiveServerCheckBox.Location = new System.Drawing.Point(6, 22);
            this.ArchiveServerCheckBox.Name = "ArchiveServerCheckBox";
            this.ArchiveServerCheckBox.Size = new System.Drawing.Size(136, 20);
            this.ArchiveServerCheckBox.TabIndex = 5;
            this.ArchiveServerCheckBox.Text = "Сервер архівації";
            this.ArchiveServerCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TestButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 64);
            this.panel1.TabIndex = 5;
            // 
            // TestButton
            // 
            this.TestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestButton.Location = new System.Drawing.Point(0, 0);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(371, 64);
            this.TestButton.TabIndex = 6;
            this.TestButton.Text = "Перевірити з\'єднання";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOLIDWORKS Connectivity Test Tool";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Label DomainNameLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label MachineNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LicenseServerDaemonTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LicenseServerPortTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LicenseServerHostTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox LicenseServerCheckBox;
        private System.Windows.Forms.TextBox DataBasePortTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DataBaseHostTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox DataBaseCheckBox;
        private System.Windows.Forms.TextBox ArchiveServerPortTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ArchiveServerHostTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ArchiveServerCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TestButton;

        #endregion

        //private GroupBox groupBox1;
        //private Label MachineNameLabel;
        //private Label label1;
        //private Label UserNameLabel;
        //private Label IPLabel;
        //private Label DomainNameLabel;

    }
}


namespace PrimaryInput
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPubHouse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbInstance = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btAddTwo = new System.Windows.Forms.Button();
            this.lbYear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbKode = new System.Windows.Forms.Label();
            this.lbAuthors = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbPubHouse = new System.Windows.Forms.Label();
            this.lbPage = new System.Windows.Forms.Label();
            this.lbInstance = new System.Windows.Forms.Label();
            this.DgvKatalog = new System.Windows.Forms.DataGridView();
            this.BtEdit = new System.Windows.Forms.Button();
            this.rbImage = new System.Windows.Forms.CheckBox();
            this.rbCD = new System.Windows.Forms.CheckBox();
            this.DgvKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvPubHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvInstance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvCD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код";
            // 
            // tbKode
            // 
            this.tbKode.Location = new System.Drawing.Point(120, 29);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(267, 26);
            this.tbKode.TabIndex = 1;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(128, 67);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 20);
            this.lbCode.TabIndex = 2;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(120, 99);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(266, 26);
            this.tbAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(126, 134);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(0, 20);
            this.lbAuthor.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 171);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(266, 26);
            this.tbName.TabIndex = 6;
            this.tbName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Назва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Місто";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(120, 218);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(266, 26);
            this.tbCity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Видавництво";
            // 
            // tbPubHouse
            // 
            this.tbPubHouse.Location = new System.Drawing.Point(120, 266);
            this.tbPubHouse.Name = "tbPubHouse";
            this.tbPubHouse.Size = new System.Drawing.Size(267, 26);
            this.tbPubHouse.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Рік вид-ва";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(120, 311);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(101, 26);
            this.tbYear.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кіл-ть стр.";
            // 
            // tbPage
            // 
            this.tbPage.Location = new System.Drawing.Point(119, 354);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(102, 26);
            this.tbPage.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 40);
            this.label8.TabIndex = 16;
            this.label8.Text = "Кіл-ть \r\nекземплярів";
            // 
            // tbInstance
            // 
            this.tbInstance.Location = new System.Drawing.Point(121, 409);
            this.tbInstance.Name = "tbInstance";
            this.tbInstance.Size = new System.Drawing.Size(100, 26);
            this.tbInstance.TabIndex = 17;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btSave.Location = new System.Drawing.Point(65, 515);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(156, 45);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "Зберегти";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(338, 515);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(156, 45);
            this.btWrite.TabIndex = 21;
            this.btWrite.Text = "Записати";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(393, 25);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(91, 34);
            this.btAdd.TabIndex = 22;
            this.btAdd.Text = "Додати";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btAddTwo
            // 
            this.btAddTwo.Location = new System.Drawing.Point(392, 95);
            this.btAddTwo.Name = "btAddTwo";
            this.btAddTwo.Size = new System.Drawing.Size(91, 35);
            this.btAddTwo.TabIndex = 23;
            this.btAddTwo.Text = "Додати";
            this.btAddTwo.UseVisualStyleBackColor = true;
            this.btAddTwo.Click += new System.EventHandler(this.btAddTwo_Click);
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.ForeColor = System.Drawing.Color.Red;
            this.lbYear.Location = new System.Drawing.Point(232, 314);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(0, 20);
            this.lbYear.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrimaryInput.Properties.Resources.Без_имени_4;
            this.pictureBox1.Location = new System.Drawing.Point(1164, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbKode
            // 
            this.lbKode.AutoSize = true;
            this.lbKode.ForeColor = System.Drawing.Color.Red;
            this.lbKode.Location = new System.Drawing.Point(380, 27);
            this.lbKode.Name = "lbKode";
            this.lbKode.Size = new System.Drawing.Size(0, 20);
            this.lbKode.TabIndex = 26;
            // 
            // lbAuthors
            // 
            this.lbAuthors.AutoSize = true;
            this.lbAuthors.ForeColor = System.Drawing.Color.Red;
            this.lbAuthors.Location = new System.Drawing.Point(66, 135);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(0, 20);
            this.lbAuthors.TabIndex = 27;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(461, 173);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 20);
            this.lbName.TabIndex = 28;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.ForeColor = System.Drawing.Color.Red;
            this.lbCity.Location = new System.Drawing.Point(287, 220);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(0, 20);
            this.lbCity.TabIndex = 29;
            // 
            // lbPubHouse
            // 
            this.lbPubHouse.AutoSize = true;
            this.lbPubHouse.ForeColor = System.Drawing.Color.Red;
            this.lbPubHouse.Location = new System.Drawing.Point(345, 268);
            this.lbPubHouse.Name = "lbPubHouse";
            this.lbPubHouse.Size = new System.Drawing.Size(0, 20);
            this.lbPubHouse.TabIndex = 30;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.ForeColor = System.Drawing.Color.Red;
            this.lbPage.Location = new System.Drawing.Point(27, 385);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(0, 20);
            this.lbPage.TabIndex = 31;
            // 
            // lbInstance
            // 
            this.lbInstance.AutoSize = true;
            this.lbInstance.ForeColor = System.Drawing.Color.Red;
            this.lbInstance.Location = new System.Drawing.Point(59, 430);
            this.lbInstance.Name = "lbInstance";
            this.lbInstance.Size = new System.Drawing.Size(0, 20);
            this.lbInstance.TabIndex = 32;
            // 
            // DgvKatalog
            // 
            this.DgvKatalog.AllowUserToAddRows = false;
            this.DgvKatalog.AllowUserToDeleteRows = false;
            this.DgvKatalog.AllowUserToOrderColumns = true;
            this.DgvKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvKode,
            this.DgvAuthor,
            this.DgvName,
            this.DgvCity,
            this.DgvPubHouse,
            this.DgvYear,
            this.DgvPage,
            this.DgvInstance,
            this.DgvImage,
            this.DgvCD});
            this.DgvKatalog.Location = new System.Drawing.Point(508, 95);
            this.DgvKatalog.Name = "DgvKatalog";
            this.DgvKatalog.ReadOnly = true;
            this.DgvKatalog.RowTemplate.Height = 28;
            this.DgvKatalog.Size = new System.Drawing.Size(899, 408);
            this.DgvKatalog.TabIndex = 33;
            // 
            // BtEdit
            // 
            this.BtEdit.Location = new System.Drawing.Point(508, 54);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(116, 33);
            this.BtEdit.TabIndex = 34;
            this.BtEdit.Text = "Редагувати";
            this.BtEdit.UseVisualStyleBackColor = true;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // rbImage
            // 
            this.rbImage.AutoSize = true;
            this.rbImage.Location = new System.Drawing.Point(47, 470);
            this.rbImage.Name = "rbImage";
            this.rbImage.Size = new System.Drawing.Size(112, 24);
            this.rbImage.TabIndex = 35;
            this.rbImage.Text = "Ілюстрації";
            this.rbImage.UseVisualStyleBackColor = true;
            // 
            // rbCD
            // 
            this.rbCD.AutoSize = true;
            this.rbCD.Location = new System.Drawing.Point(232, 470);
            this.rbCD.Name = "rbCD";
            this.rbCD.Size = new System.Drawing.Size(58, 24);
            this.rbCD.TabIndex = 36;
            this.rbCD.Text = "CD";
            this.rbCD.UseVisualStyleBackColor = true;
            // 
            // DgvKode
            // 
            this.DgvKode.HeaderText = "Код";
            this.DgvKode.Name = "DgvKode";
            this.DgvKode.ReadOnly = true;
            // 
            // DgvAuthor
            // 
            this.DgvAuthor.HeaderText = "Автор";
            this.DgvAuthor.Name = "DgvAuthor";
            this.DgvAuthor.ReadOnly = true;
            this.DgvAuthor.Width = 135;
            // 
            // DgvName
            // 
            this.DgvName.HeaderText = "Назва";
            this.DgvName.Name = "DgvName";
            this.DgvName.ReadOnly = true;
            // 
            // DgvCity
            // 
            this.DgvCity.HeaderText = "Місто";
            this.DgvCity.Name = "DgvCity";
            this.DgvCity.ReadOnly = true;
            // 
            // DgvPubHouse
            // 
            this.DgvPubHouse.HeaderText = "Видавництво";
            this.DgvPubHouse.Name = "DgvPubHouse";
            this.DgvPubHouse.ReadOnly = true;
            this.DgvPubHouse.Width = 120;
            // 
            // DgvYear
            // 
            this.DgvYear.HeaderText = "Рік вид-ва";
            this.DgvYear.Name = "DgvYear";
            this.DgvYear.ReadOnly = true;
            // 
            // DgvPage
            // 
            this.DgvPage.HeaderText = "Кіл-ть стр.";
            this.DgvPage.Name = "DgvPage";
            this.DgvPage.ReadOnly = true;
            this.DgvPage.Width = 70;
            // 
            // DgvInstance
            // 
            this.DgvInstance.HeaderText = "Кіл-ть екз.";
            this.DgvInstance.Name = "DgvInstance";
            this.DgvInstance.ReadOnly = true;
            this.DgvInstance.Width = 70;
            // 
            // DgvImage
            // 
            this.DgvImage.HeaderText = "Ілюстрації";
            this.DgvImage.Name = "DgvImage";
            this.DgvImage.ReadOnly = true;
            this.DgvImage.Width = 30;
            // 
            // DgvCD
            // 
            this.DgvCD.HeaderText = "СD";
            this.DgvCD.Name = "DgvCD";
            this.DgvCD.ReadOnly = true;
            this.DgvCD.Width = 30;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1419, 573);
            this.Controls.Add(this.rbCD);
            this.Controls.Add(this.rbImage);
            this.Controls.Add(this.BtEdit);
            this.Controls.Add(this.DgvKatalog);
            this.Controls.Add(this.lbInstance);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.lbPubHouse);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.lbKode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.btAddTwo);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbInstance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPubHouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.tbKode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "ХПКК Первинне введення даних";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPubHouse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbInstance;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btAddTwo;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbKode;
        private System.Windows.Forms.Label lbAuthors;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbPubHouse;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Label lbInstance;
        private System.Windows.Forms.DataGridView DgvKatalog;
        private System.Windows.Forms.Button BtEdit;
        private System.Windows.Forms.CheckBox rbImage;
        private System.Windows.Forms.CheckBox rbCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvPubHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvInstance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DgvImage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DgvCD;
    }
}


namespace PM._03
{
    partial class InsertPostavkaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGarantiya = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDetail = new System.Windows.Forms.ComboBox();
            this.numericUpDownKolichestvo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSumma = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPostavschik = new System.Windows.Forms.ComboBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.buttonSort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolichestvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Деталь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Сумма";
            // 
            // textBoxGarantiya
            // 
            this.textBoxGarantiya.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxGarantiya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGarantiya.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGarantiya.Location = new System.Drawing.Point(298, 202);
            this.textBoxGarantiya.Name = "textBoxGarantiya";
            this.textBoxGarantiya.Size = new System.Drawing.Size(220, 34);
            this.textBoxGarantiya.TabIndex = 2;
            this.textBoxGarantiya.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Гарантия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Поставщик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Дата поставки";
            // 
            // comboBoxDetail
            // 
            this.comboBoxDetail.BackColor = System.Drawing.Color.Moccasin;
            this.comboBoxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDetail.FormattingEnabled = true;
            this.comboBoxDetail.Items.AddRange(new object[] {
            "Тормозные колодки"});
            this.comboBoxDetail.Location = new System.Drawing.Point(298, 76);
            this.comboBoxDetail.Name = "comboBoxDetail";
            this.comboBoxDetail.Size = new System.Drawing.Size(220, 37);
            this.comboBoxDetail.TabIndex = 4;
            this.comboBoxDetail.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDownKolichestvo
            // 
            this.numericUpDownKolichestvo.BackColor = System.Drawing.Color.Moccasin;
            this.numericUpDownKolichestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownKolichestvo.Location = new System.Drawing.Point(298, 118);
            this.numericUpDownKolichestvo.Name = "numericUpDownKolichestvo";
            this.numericUpDownKolichestvo.Size = new System.Drawing.Size(220, 34);
            this.numericUpDownKolichestvo.TabIndex = 5;
            // 
            // numericUpDownSumma
            // 
            this.numericUpDownSumma.BackColor = System.Drawing.Color.Moccasin;
            this.numericUpDownSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSumma.Location = new System.Drawing.Point(298, 158);
            this.numericUpDownSumma.Name = "numericUpDownSumma";
            this.numericUpDownSumma.Size = new System.Drawing.Size(220, 34);
            this.numericUpDownSumma.TabIndex = 5;
            // 
            // comboBoxPostavschik
            // 
            this.comboBoxPostavschik.BackColor = System.Drawing.Color.Moccasin;
            this.comboBoxPostavschik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPostavschik.FormattingEnabled = true;
            this.comboBoxPostavschik.Items.AddRange(new object[] {
            "АвтоТрейд"});
            this.comboBoxPostavschik.Location = new System.Drawing.Point(298, 243);
            this.comboBoxPostavschik.Name = "comboBoxPostavschik";
            this.comboBoxPostavschik.Size = new System.Drawing.Size(220, 37);
            this.comboBoxPostavschik.TabIndex = 4;
            this.comboBoxPostavschik.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerData.Location = new System.Drawing.Point(298, 286);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(220, 34);
            this.dateTimePickerData.TabIndex = 6;
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.Orange;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.ForeColor = System.Drawing.Color.White;
            this.buttonSort.Location = new System.Drawing.Point(45, 358);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(128, 36);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Изменить";
            this.buttonSort.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(204, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(359, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Печатать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // InsertPostavkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.numericUpDownSumma);
            this.Controls.Add(this.numericUpDownKolichestvo);
            this.Controls.Add(this.comboBoxPostavschik);
            this.Controls.Add(this.comboBoxDetail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGarantiya);
            this.Name = "InsertPostavkaForm";
            this.Text = "InsertPostavkaForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolichestvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGarantiya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDetail;
        private System.Windows.Forms.NumericUpDown numericUpDownKolichestvo;
        private System.Windows.Forms.NumericUpDown numericUpDownSumma;
        private System.Windows.Forms.ComboBox comboBoxPostavschik;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
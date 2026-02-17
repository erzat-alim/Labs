namespace Alimbekov_Erzat_dkip481
{
    partial class t11
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCulc = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.textBoxX4 = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.textBoxY4 = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxB);
            this.panel1.Controls.Add(this.buttonCulc);
            this.panel1.Controls.Add(this.textBoxA);
            this.panel1.Controls.Add(this.labelTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(346, 187);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(125, 31);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Результат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Функция (y = a*x + b):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCulc
            // 
            this.buttonCulc.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonCulc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCulc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCulc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCulc.Location = new System.Drawing.Point(114, 300);
            this.buttonCulc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCulc.Name = "buttonCulc";
            this.buttonCulc.Size = new System.Drawing.Size(169, 39);
            this.buttonCulc.TabIndex = 6;
            this.buttonCulc.Text = "Вычислить";
            this.buttonCulc.UseVisualStyleBackColor = false;
            this.buttonCulc.Click += new System.EventHandler(this.buttonCulc_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(153, 185);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(132, 38);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTask
            // 
            this.labelTask.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(65, 5);
            this.labelTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(662, 102);
            this.labelTask.TabIndex = 4;
            this.labelTask.Text = "Составьте таблицу значений функции:";
            this.labelTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxY4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxY3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxY2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxY1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxX4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxX3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxX2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxX1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxX, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(478, 185);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 111);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBoxX
            // 
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxX.Location = new System.Drawing.Point(4, 4);
            this.textBoxX.Multiline = true;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(42, 48);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.Text = "x";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxX1
            // 
            this.textBoxX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxX1.Location = new System.Drawing.Point(53, 4);
            this.textBoxX1.Multiline = true;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(42, 48);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxX2
            // 
            this.textBoxX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxX2.Location = new System.Drawing.Point(102, 4);
            this.textBoxX2.Multiline = true;
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(42, 48);
            this.textBoxX2.TabIndex = 2;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxX3
            // 
            this.textBoxX3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxX3.Location = new System.Drawing.Point(151, 4);
            this.textBoxX3.Multiline = true;
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(42, 48);
            this.textBoxX3.TabIndex = 3;
            this.textBoxX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX3.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxX4
            // 
            this.textBoxX4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxX4.Location = new System.Drawing.Point(200, 4);
            this.textBoxX4.Multiline = true;
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(44, 48);
            this.textBoxX4.TabIndex = 4;
            this.textBoxX4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX4.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxY.Location = new System.Drawing.Point(4, 59);
            this.textBoxY.Multiline = true;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(42, 48);
            this.textBoxY.TabIndex = 5;
            this.textBoxY.Text = "y";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBoxY1
            // 
            this.textBoxY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxY1.Location = new System.Drawing.Point(53, 59);
            this.textBoxY1.Multiline = true;
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.ReadOnly = true;
            this.textBoxY1.Size = new System.Drawing.Size(42, 48);
            this.textBoxY1.TabIndex = 6;
            this.textBoxY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxY1.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBoxY2
            // 
            this.textBoxY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxY2.Location = new System.Drawing.Point(102, 59);
            this.textBoxY2.Multiline = true;
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.ReadOnly = true;
            this.textBoxY2.Size = new System.Drawing.Size(42, 48);
            this.textBoxY2.TabIndex = 7;
            this.textBoxY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxY3
            // 
            this.textBoxY3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxY3.Location = new System.Drawing.Point(151, 59);
            this.textBoxY3.Multiline = true;
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.ReadOnly = true;
            this.textBoxY3.Size = new System.Drawing.Size(42, 48);
            this.textBoxY3.TabIndex = 8;
            this.textBoxY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxY3.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBoxY4
            // 
            this.textBoxY4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxY4.Location = new System.Drawing.Point(200, 59);
            this.textBoxY4.Multiline = true;
            this.textBoxY4.Name = "textBoxY4";
            this.textBoxY4.ReadOnly = true;
            this.textBoxY4.Size = new System.Drawing.Size(44, 48);
            this.textBoxY4.TabIndex = 9;
            this.textBoxY4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxY4.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(152, 230);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(132, 38);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(103, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "a:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(104, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "b:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(381, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите значения x:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // t11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "t11";
            this.Text = "t11";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCulc;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxY4;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX4;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
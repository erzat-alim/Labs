namespace Alimbekov_Erzat_dkip481
{
    partial class t6
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
            this.buttonCulc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCulc
            // 
            this.buttonCulc.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonCulc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCulc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCulc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCulc.Location = new System.Drawing.Point(130, 290);
            this.buttonCulc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCulc.Name = "buttonCulc";
            this.buttonCulc.Size = new System.Drawing.Size(157, 39);
            this.buttonCulc.TabIndex = 6;
            this.buttonCulc.Text = "Вычислить";
            this.buttonCulc.UseVisualStyleBackColor = false;
            this.buttonCulc.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCulc);
            this.panel1.Controls.Add(this.textBoxNum2);
            this.panel1.Controls.Add(this.textBoxNum1);
            this.panel1.Controls.Add(this.labelTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(471, 191);
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
            this.label1.Location = new System.Drawing.Point(53, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Первое число:";
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNum1.Location = new System.Drawing.Point(229, 158);
            this.textBoxNum1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(169, 38);
            this.textBoxNum1.TabIndex = 1;
            // 
            // labelTask
            // 
            this.labelTask.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(65, 5);
            this.labelTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(662, 102);
            this.labelTask.TabIndex = 4;
            this.labelTask.Text = "Функция, возвращающая среднее арифметическое двух аргументов:";
            this.labelTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNum2.Location = new System.Drawing.Point(229, 217);
            this.textBoxNum2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(169, 38);
            this.textBoxNum2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второе число:";
            // 
            // t6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "t6";
            this.Text = "t6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCulc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNum2;
    }
}
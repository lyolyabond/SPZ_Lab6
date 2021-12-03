namespace SPZ_Lab6.View
{
    partial class MoveIn
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lastname_textBox = new System.Windows.Forms.TextBox();
            this.firstname_textBox = new System.Windows.Forms.TextBox();
            this.places_numeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.days_numeric = new System.Windows.Forms.NumericUpDown();
            this.price_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.sum_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.places_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.days_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во спальных мест:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена за сутки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(150, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.52901F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.47099F));
            this.tableLayoutPanel1.Controls.Add(this.sum_label, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.days_numeric, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.places_numeric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.number_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.price_label, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 185);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lastname_textBox
            // 
            this.lastname_textBox.Location = new System.Drawing.Point(123, 41);
            this.lastname_textBox.Name = "lastname_textBox";
            this.lastname_textBox.Size = new System.Drawing.Size(141, 26);
            this.lastname_textBox.TabIndex = 6;
            // 
            // firstname_textBox
            // 
            this.firstname_textBox.Location = new System.Drawing.Point(123, 85);
            this.firstname_textBox.Name = "firstname_textBox";
            this.firstname_textBox.Size = new System.Drawing.Size(141, 26);
            this.firstname_textBox.TabIndex = 7;
            // 
            // places_numeric
            // 
            this.places_numeric.Location = new System.Drawing.Point(194, 3);
            this.places_numeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.places_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.places_numeric.Name = "places_numeric";
            this.places_numeric.Size = new System.Drawing.Size(96, 26);
            this.places_numeric.TabIndex = 5;
            this.places_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.places_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.places_numeric.ValueChanged += new System.EventHandler(this.places_numeric_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(109, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Забронировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Кол-во дней:";
            // 
            // days_numeric
            // 
            this.days_numeric.Location = new System.Drawing.Point(194, 50);
            this.days_numeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.days_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.days_numeric.Name = "days_numeric";
            this.days_numeric.Size = new System.Drawing.Size(96, 26);
            this.days_numeric.TabIndex = 7;
            this.days_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.days_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.days_numeric.ValueChanged += new System.EventHandler(this.days_numeric_ValueChanged);
            // 
            // price_label
            // 
            this.price_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(216, 125);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(51, 20);
            this.price_label.TabIndex = 9;
            this.price_label.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Номер:";
            // 
            // number_label
            // 
            this.number_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(216, 88);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(51, 20);
            this.number_label.TabIndex = 12;
            this.number_label.Text = "label9";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 156);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 20);
            this.label.TabIndex = 13;
            this.label.Text = "Сумма:";
            // 
            // sum_label
            // 
            this.sum_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sum_label.AutoSize = true;
            this.sum_label.Location = new System.Drawing.Point(216, 156);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(51, 20);
            this.sum_label.TabIndex = 14;
            this.sum_label.Text = "label8";
            // 
            // MoveIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstname_textBox);
            this.Controls.Add(this.lastname_textBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MoveIn";
            this.Text = "MoveIn";
            this.Load += new System.EventHandler(this.MoveIn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.places_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.days_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.NumericUpDown days_numeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown places_numeric;
        private System.Windows.Forms.TextBox lastname_textBox;
        private System.Windows.Forms.TextBox firstname_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label sum_label;
        private System.Windows.Forms.Label label;
    }
}
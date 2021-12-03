namespace SPZ_Lab6
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.free_label = new System.Windows.Forms.Label();
            this.occupied_label = new System.Windows.Forms.Label();
            this.all_label = new System.Windows.Forms.Label();
            this.moveIn_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.moveOut_button = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во номеров всего:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во занятых номеров:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во свободных номеров:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.94832F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.05168F));
            this.tableLayoutPanel1.Controls.Add(this.free_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.occupied_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.all_label, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 116);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // free_label
            // 
            this.free_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.free_label.AutoSize = true;
            this.free_label.Location = new System.Drawing.Point(283, 79);
            this.free_label.Name = "free_label";
            this.free_label.Size = new System.Drawing.Size(51, 20);
            this.free_label.TabIndex = 7;
            this.free_label.Text = "label6";
            // 
            // occupied_label
            // 
            this.occupied_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.occupied_label.AutoSize = true;
            this.occupied_label.Location = new System.Drawing.Point(283, 40);
            this.occupied_label.Name = "occupied_label";
            this.occupied_label.Size = new System.Drawing.Size(51, 20);
            this.occupied_label.TabIndex = 6;
            this.occupied_label.Text = "label5";
            // 
            // all_label
            // 
            this.all_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.all_label.AutoSize = true;
            this.all_label.Location = new System.Drawing.Point(283, 0);
            this.all_label.Name = "all_label";
            this.all_label.Size = new System.Drawing.Size(51, 20);
            this.all_label.TabIndex = 5;
            this.all_label.Text = "label4";
            // 
            // moveIn_button
            // 
            this.moveIn_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moveIn_button.BackColor = System.Drawing.Color.YellowGreen;
            this.moveIn_button.Location = new System.Drawing.Point(22, 3);
            this.moveIn_button.Name = "moveIn_button";
            this.moveIn_button.Size = new System.Drawing.Size(130, 46);
            this.moveIn_button.TabIndex = 6;
            this.moveIn_button.Text = "Заселиться";
            this.moveIn_button.UseVisualStyleBackColor = false;
            this.moveIn_button.Click += new System.EventHandler(this.moveIn_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.4023F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.5977F));
            this.tableLayoutPanel2.Controls.Add(this.moveOut_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.moveIn_button, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 134);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 56);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // moveOut_button
            // 
            this.moveOut_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moveOut_button.BackColor = System.Drawing.Color.Coral;
            this.moveOut_button.Location = new System.Drawing.Point(217, 3);
            this.moveOut_button.Name = "moveOut_button";
            this.moveOut_button.Size = new System.Drawing.Size(127, 46);
            this.moveOut_button.TabIndex = 8;
            this.moveOut_button.Text = "Выселиться";
            this.moveOut_button.UseVisualStyleBackColor = false;
            this.moveOut_button.Click += new System.EventHandler(this.moveOut_button_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(426, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Обычный режим";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(426, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(145, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Сезон отпусков";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(582, 209);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lab6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label all_label;
        private System.Windows.Forms.Button moveIn_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button moveOut_button;
        public System.Windows.Forms.Label free_label;
        public System.Windows.Forms.Label occupied_label;
    }
}


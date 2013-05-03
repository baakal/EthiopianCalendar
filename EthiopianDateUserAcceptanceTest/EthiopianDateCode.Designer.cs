namespace EthiopianDateUserAcceptanceTest
{
    partial class EthiopianDateCode
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEthiopianShortDate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEthiopianLongDate = new System.Windows.Forms.TextBox();
            this.txtEthiopianDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtEthiopianDateCustom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtEthiopianShortDate
            // 
            this.txtEthiopianShortDate.Location = new System.Drawing.Point(206, 54);
            this.txtEthiopianShortDate.Name = "txtEthiopianShortDate";
            this.txtEthiopianShortDate.Size = new System.Drawing.Size(200, 20);
            this.txtEthiopianShortDate.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEthiopianLongDate
            // 
            this.txtEthiopianLongDate.Location = new System.Drawing.Point(206, 80);
            this.txtEthiopianLongDate.Name = "txtEthiopianLongDate";
            this.txtEthiopianLongDate.Size = new System.Drawing.Size(200, 20);
            this.txtEthiopianLongDate.TabIndex = 3;
            // 
            // txtEthiopianDate
            // 
            this.txtEthiopianDate.Location = new System.Drawing.Point(206, 106);
            this.txtEthiopianDate.Name = "txtEthiopianDate";
            this.txtEthiopianDate.Size = new System.Drawing.Size(200, 20);
            this.txtEthiopianDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ToEthiopianShortDateString";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ToEthiopianLongDateString";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ToEthiopianDateString default";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(65, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "dd/mm/yyyy";
            // 
            // txtEthiopianDateCustom
            // 
            this.txtEthiopianDateCustom.Location = new System.Drawing.Point(206, 136);
            this.txtEthiopianDateCustom.Name = "txtEthiopianDateCustom";
            this.txtEthiopianDateCustom.Size = new System.Drawing.Size(200, 20);
            this.txtEthiopianDateCustom.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ToEthiopianDateString";
            // 
            // EthiopianDateCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 168);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEthiopianDateCustom);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEthiopianDate);
            this.Controls.Add(this.txtEthiopianLongDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEthiopianShortDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "EthiopianDateCode";
            this.Text = "EthiopianDateCode";
            this.Load += new System.EventHandler(this.EthiopianDateCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEthiopianShortDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEthiopianLongDate;
        private System.Windows.Forms.TextBox txtEthiopianDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtEthiopianDateCustom;
        private System.Windows.Forms.Label label4;
    }
}
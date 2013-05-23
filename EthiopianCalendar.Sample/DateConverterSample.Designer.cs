namespace EthiopianCalendar.Sample
{
    partial class DateConverterSample
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.gridSample = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.ColGregorianDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EthiopianDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSample)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(76, 18);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(357, 17);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(26, 24);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(307, 24);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // gridSample
            // 
            this.gridSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSample.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGregorianDate,
            this.EthiopianDate});
            this.gridSample.Location = new System.Drawing.Point(76, 81);
            this.gridSample.Name = "gridSample";
            this.gridSample.Size = new System.Drawing.Size(587, 150);
            this.gridSample.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(76, 52);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(563, 17);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(100, 20);
            this.txtFormat.TabIndex = 6;
            this.txtFormat.Text = "MMMM dd, yyyy";
            // 
            // ColGregorianDate
            // 
            this.ColGregorianDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColGregorianDate.DataPropertyName = "GregorianDate";
            this.ColGregorianDate.HeaderText = "Gregorian Date";
            this.ColGregorianDate.Name = "ColGregorianDate";
            // 
            // EthiopianDate
            // 
            this.EthiopianDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EthiopianDate.DataPropertyName = "EthiopianDate";
            this.EthiopianDate.HeaderText = "Ethiopian Date";
            this.EthiopianDate.Name = "EthiopianDate";
            // 
            // DateConverterSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 505);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gridSample);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "DateConverterSample";
            this.Text = "DateConverterSample";
            this.Load += new System.EventHandler(this.DateConverterSample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DataGridView gridSample;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGregorianDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EthiopianDate;
    }
}
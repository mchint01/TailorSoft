namespace TailorSoft
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.lblSelectMonthAndYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblAccountsErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectMonthAndYear
            // 
            this.lblSelectMonthAndYear.AutoSize = true;
            this.lblSelectMonthAndYear.Location = new System.Drawing.Point(36, 53);
            this.lblSelectMonthAndYear.Name = "lblSelectMonthAndYear";
            this.lblSelectMonthAndYear.Size = new System.Drawing.Size(152, 17);
            this.lblSelectMonthAndYear.TabIndex = 0;
            this.lblSelectMonthAndYear.Text = "Select Year and Month";
            // 
            // cmbYear
            // 
            this.cmbYear.DisplayMember = "Text";
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(219, 53);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(136, 165);
            this.cmbYear.TabIndex = 1;
            this.cmbYear.ValueMember = "Id";
            // 
            // cmbMonths
            // 
            this.cmbMonths.DisplayMember = "Text";
            this.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Location = new System.Drawing.Point(403, 50);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(136, 165);
            this.cmbMonths.TabIndex = 2;
            this.cmbMonths.ValueMember = "Id";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(620, 53);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(138, 27);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblAccountsErrorMessage
            // 
            this.lblAccountsErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblAccountsErrorMessage.Location = new System.Drawing.Point(219, 244);
            this.lblAccountsErrorMessage.Name = "lblAccountsErrorMessage";
            this.lblAccountsErrorMessage.Size = new System.Drawing.Size(539, 116);
            this.lblAccountsErrorMessage.TabIndex = 4;
            this.lblAccountsErrorMessage.Text = "   ";
            this.lblAccountsErrorMessage.Visible = false;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 450);
            this.Controls.Add(this.lblAccountsErrorMessage);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblSelectMonthAndYear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountForm";
            this.Text = "Accounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMonthAndYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblAccountsErrorMessage;
    }
}
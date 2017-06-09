namespace TailorSoft
{
    partial class CustomerBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerBillForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblSuits = new System.Windows.Forms.Label();
            this.lblJackets = new System.Windows.Forms.Label();
            this.lblSafaries = new System.Windows.Forms.Label();
            this.lblTrousers = new System.Windows.Forms.Label();
            this.lblShirts = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.txtSuitMeasurement = new System.Windows.Forms.TextBox();
            this.txtJacketMeasurement = new System.Windows.Forms.TextBox();
            this.txtSafaryMeasurement = new System.Windows.Forms.TextBox();
            this.txtTrouserMeasurement = new System.Windows.Forms.TextBox();
            this.txtShirtMeasurement = new System.Windows.Forms.TextBox();
            this.txtOtherMeasurement = new System.Windows.Forms.TextBox();
            this.txtSuitQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtSuitRate = new System.Windows.Forms.TextBox();
            this.txtSuitAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtJacketAmount = new System.Windows.Forms.TextBox();
            this.txtJacketRate = new System.Windows.Forms.TextBox();
            this.txtJacketQty = new System.Windows.Forms.TextBox();
            this.txtSafaryAmount = new System.Windows.Forms.TextBox();
            this.txtSafaryRate = new System.Windows.Forms.TextBox();
            this.txtSafaryQty = new System.Windows.Forms.TextBox();
            this.txtTrouserAmount = new System.Windows.Forms.TextBox();
            this.txtTrouserRate = new System.Windows.Forms.TextBox();
            this.txtTrouserQty = new System.Windows.Forms.TextBox();
            this.txtShirtAmount = new System.Windows.Forms.TextBox();
            this.txtShirtRate = new System.Windows.Forms.TextBox();
            this.txtShirtQty = new System.Windows.Forms.TextBox();
            this.txtOtherAmount = new System.Windows.Forms.TextBox();
            this.txtOtherRate = new System.Windows.Forms.TextBox();
            this.txtOtherQty = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.cmbBillStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtSentToTailor = new System.Windows.Forms.DateTimePicker();
            this.lblDtSentToTailor = new System.Windows.Forms.Label();
            this.lblPreferredDeliveryDate = new System.Windows.Forms.Label();
            this.dtPreferredDeliveryDt = new System.Windows.Forms.DateTimePicker();
            this.lblReadyForDeliveryDt = new System.Windows.Forms.Label();
            this.dtReadyForDeliveryDt = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveredDt = new System.Windows.Forms.Label();
            this.dtDeliveredDt = new System.Windows.Forms.DateTimePicker();
            this.lblBillDt = new System.Windows.Forms.Label();
            this.dtBillDt = new System.Windows.Forms.DateTimePicker();
            this.lblBillFormErrorMessage = new System.Windows.Forms.Label();
            this.lblPreferredInternalDeliveryDt = new System.Windows.Forms.Label();
            this.dtPreferredInternalDeliveryDt = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1054, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(940, 569);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 28);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(287, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(20, 17);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "   ";
            // 
            // lblSuits
            // 
            this.lblSuits.AutoSize = true;
            this.lblSuits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuits.Location = new System.Drawing.Point(20, 57);
            this.lblSuits.Name = "lblSuits";
            this.lblSuits.Size = new System.Drawing.Size(48, 17);
            this.lblSuits.TabIndex = 3;
            this.lblSuits.Text = "SUITS";
            // 
            // lblJackets
            // 
            this.lblJackets.AutoSize = true;
            this.lblJackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJackets.Location = new System.Drawing.Point(20, 136);
            this.lblJackets.Name = "lblJackets";
            this.lblJackets.Size = new System.Drawing.Size(69, 17);
            this.lblJackets.TabIndex = 4;
            this.lblJackets.Text = "JACKETS";
            // 
            // lblSafaries
            // 
            this.lblSafaries.AutoSize = true;
            this.lblSafaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSafaries.Location = new System.Drawing.Point(20, 218);
            this.lblSafaries.Name = "lblSafaries";
            this.lblSafaries.Size = new System.Drawing.Size(74, 17);
            this.lblSafaries.TabIndex = 5;
            this.lblSafaries.Text = "SAFARIES";
            // 
            // lblTrousers
            // 
            this.lblTrousers.AutoSize = true;
            this.lblTrousers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrousers.Location = new System.Drawing.Point(20, 297);
            this.lblTrousers.Name = "lblTrousers";
            this.lblTrousers.Size = new System.Drawing.Size(85, 17);
            this.lblTrousers.TabIndex = 6;
            this.lblTrousers.Text = "TROUSERS";
            // 
            // lblShirts
            // 
            this.lblShirts.AutoSize = true;
            this.lblShirts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirts.Location = new System.Drawing.Point(20, 376);
            this.lblShirts.Name = "lblShirts";
            this.lblShirts.Size = new System.Drawing.Size(58, 17);
            this.lblShirts.TabIndex = 7;
            this.lblShirts.Text = "SHIRTS";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.Location = new System.Drawing.Point(20, 455);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(66, 17);
            this.lblOthers.TabIndex = 8;
            this.lblOthers.Text = "OTHERS";
            // 
            // txtSuitMeasurement
            // 
            this.txtSuitMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuitMeasurement.Location = new System.Drawing.Point(110, 57);
            this.txtSuitMeasurement.Multiline = true;
            this.txtSuitMeasurement.Name = "txtSuitMeasurement";
            this.txtSuitMeasurement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSuitMeasurement.Size = new System.Drawing.Size(541, 73);
            this.txtSuitMeasurement.TabIndex = 9;
            // 
            // txtJacketMeasurement
            // 
            this.txtJacketMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJacketMeasurement.Location = new System.Drawing.Point(110, 136);
            this.txtJacketMeasurement.Multiline = true;
            this.txtJacketMeasurement.Name = "txtJacketMeasurement";
            this.txtJacketMeasurement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJacketMeasurement.Size = new System.Drawing.Size(541, 73);
            this.txtJacketMeasurement.TabIndex = 10;
            // 
            // txtSafaryMeasurement
            // 
            this.txtSafaryMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSafaryMeasurement.Location = new System.Drawing.Point(110, 218);
            this.txtSafaryMeasurement.Multiline = true;
            this.txtSafaryMeasurement.Name = "txtSafaryMeasurement";
            this.txtSafaryMeasurement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSafaryMeasurement.Size = new System.Drawing.Size(541, 73);
            this.txtSafaryMeasurement.TabIndex = 11;
            // 
            // txtTrouserMeasurement
            // 
            this.txtTrouserMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrouserMeasurement.Location = new System.Drawing.Point(110, 297);
            this.txtTrouserMeasurement.Multiline = true;
            this.txtTrouserMeasurement.Name = "txtTrouserMeasurement";
            this.txtTrouserMeasurement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTrouserMeasurement.Size = new System.Drawing.Size(541, 73);
            this.txtTrouserMeasurement.TabIndex = 12;
            // 
            // txtShirtMeasurement
            // 
            this.txtShirtMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShirtMeasurement.Location = new System.Drawing.Point(110, 376);
            this.txtShirtMeasurement.Multiline = true;
            this.txtShirtMeasurement.Name = "txtShirtMeasurement";
            this.txtShirtMeasurement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShirtMeasurement.Size = new System.Drawing.Size(541, 73);
            this.txtShirtMeasurement.TabIndex = 13;
            // 
            // txtOtherMeasurement
            // 
            this.txtOtherMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherMeasurement.Location = new System.Drawing.Point(110, 455);
            this.txtOtherMeasurement.Multiline = true;
            this.txtOtherMeasurement.Name = "txtOtherMeasurement";
            this.txtOtherMeasurement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOtherMeasurement.Size = new System.Drawing.Size(541, 73);
            this.txtOtherMeasurement.TabIndex = 14;
            // 
            // txtSuitQty
            // 
            this.txtSuitQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuitQty.Location = new System.Drawing.Point(667, 57);
            this.txtSuitQty.Name = "txtSuitQty";
            this.txtSuitQty.Size = new System.Drawing.Size(56, 23);
            this.txtSuitQty.TabIndex = 15;
            this.txtSuitQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuitQty_KeyPress);
            this.txtSuitQty.Validated += new System.EventHandler(this.txtSuitQty_Validated);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(664, 26);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(30, 17);
            this.lblQty.TabIndex = 16;
            this.lblQty.Text = "Qty";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(741, 26);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(38, 17);
            this.lblRate.TabIndex = 17;
            this.lblRate.Text = "Rate";
            // 
            // txtSuitRate
            // 
            this.txtSuitRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuitRate.Location = new System.Drawing.Point(744, 57);
            this.txtSuitRate.Name = "txtSuitRate";
            this.txtSuitRate.Size = new System.Drawing.Size(73, 23);
            this.txtSuitRate.TabIndex = 18;
            this.txtSuitRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuitRate_KeyPress);
            this.txtSuitRate.Validated += new System.EventHandler(this.txtSuitRate_Validated);
            // 
            // txtSuitAmount
            // 
            this.txtSuitAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuitAmount.Location = new System.Drawing.Point(842, 57);
            this.txtSuitAmount.Name = "txtSuitAmount";
            this.txtSuitAmount.ReadOnly = true;
            this.txtSuitAmount.Size = new System.Drawing.Size(73, 23);
            this.txtSuitAmount.TabIndex = 19;
            this.txtSuitAmount.TextChanged += new System.EventHandler(this.txtSuitAmount_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(839, 26);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "Amount";
            // 
            // txtJacketAmount
            // 
            this.txtJacketAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJacketAmount.Location = new System.Drawing.Point(842, 133);
            this.txtJacketAmount.Name = "txtJacketAmount";
            this.txtJacketAmount.ReadOnly = true;
            this.txtJacketAmount.Size = new System.Drawing.Size(73, 23);
            this.txtJacketAmount.TabIndex = 23;
            this.txtJacketAmount.TextChanged += new System.EventHandler(this.txtJacketAmount_TextChanged);
            // 
            // txtJacketRate
            // 
            this.txtJacketRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJacketRate.Location = new System.Drawing.Point(744, 133);
            this.txtJacketRate.Name = "txtJacketRate";
            this.txtJacketRate.Size = new System.Drawing.Size(73, 23);
            this.txtJacketRate.TabIndex = 22;
            this.txtJacketRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJacketRate_KeyPress);
            this.txtJacketRate.Validated += new System.EventHandler(this.txtJacketRate_Validated);
            // 
            // txtJacketQty
            // 
            this.txtJacketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJacketQty.Location = new System.Drawing.Point(667, 133);
            this.txtJacketQty.Name = "txtJacketQty";
            this.txtJacketQty.Size = new System.Drawing.Size(56, 23);
            this.txtJacketQty.TabIndex = 21;
            this.txtJacketQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJacketQty_KeyPress);
            this.txtJacketQty.Validated += new System.EventHandler(this.txtJacketQty_Validated);
            // 
            // txtSafaryAmount
            // 
            this.txtSafaryAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSafaryAmount.Location = new System.Drawing.Point(842, 215);
            this.txtSafaryAmount.Name = "txtSafaryAmount";
            this.txtSafaryAmount.ReadOnly = true;
            this.txtSafaryAmount.Size = new System.Drawing.Size(73, 23);
            this.txtSafaryAmount.TabIndex = 26;
            this.txtSafaryAmount.TextChanged += new System.EventHandler(this.txtSafaryAmount_TextChanged);
            // 
            // txtSafaryRate
            // 
            this.txtSafaryRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSafaryRate.Location = new System.Drawing.Point(744, 215);
            this.txtSafaryRate.Name = "txtSafaryRate";
            this.txtSafaryRate.Size = new System.Drawing.Size(73, 23);
            this.txtSafaryRate.TabIndex = 25;
            this.txtSafaryRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSafaryRate_KeyPress);
            this.txtSafaryRate.Validated += new System.EventHandler(this.txtSafaryRate_Validated);
            // 
            // txtSafaryQty
            // 
            this.txtSafaryQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSafaryQty.Location = new System.Drawing.Point(667, 215);
            this.txtSafaryQty.Name = "txtSafaryQty";
            this.txtSafaryQty.Size = new System.Drawing.Size(56, 23);
            this.txtSafaryQty.TabIndex = 24;
            this.txtSafaryQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSafaryQty_KeyPress);
            this.txtSafaryQty.Validated += new System.EventHandler(this.txtSafaryQty_Validated);
            // 
            // txtTrouserAmount
            // 
            this.txtTrouserAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrouserAmount.Location = new System.Drawing.Point(842, 294);
            this.txtTrouserAmount.Name = "txtTrouserAmount";
            this.txtTrouserAmount.ReadOnly = true;
            this.txtTrouserAmount.Size = new System.Drawing.Size(73, 23);
            this.txtTrouserAmount.TabIndex = 29;
            this.txtTrouserAmount.TextChanged += new System.EventHandler(this.txtTrouserAmount_TextChanged);
            // 
            // txtTrouserRate
            // 
            this.txtTrouserRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrouserRate.Location = new System.Drawing.Point(744, 294);
            this.txtTrouserRate.Name = "txtTrouserRate";
            this.txtTrouserRate.Size = new System.Drawing.Size(73, 23);
            this.txtTrouserRate.TabIndex = 28;
            this.txtTrouserRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrouserRate_KeyPress);
            this.txtTrouserRate.Validated += new System.EventHandler(this.txtTrouserRate_Validated);
            // 
            // txtTrouserQty
            // 
            this.txtTrouserQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrouserQty.Location = new System.Drawing.Point(667, 294);
            this.txtTrouserQty.Name = "txtTrouserQty";
            this.txtTrouserQty.Size = new System.Drawing.Size(56, 23);
            this.txtTrouserQty.TabIndex = 27;
            this.txtTrouserQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrouserQty_KeyPress);
            this.txtTrouserQty.Validated += new System.EventHandler(this.txtTrouserQty_Validated);
            // 
            // txtShirtAmount
            // 
            this.txtShirtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShirtAmount.Location = new System.Drawing.Point(842, 376);
            this.txtShirtAmount.Name = "txtShirtAmount";
            this.txtShirtAmount.ReadOnly = true;
            this.txtShirtAmount.Size = new System.Drawing.Size(73, 23);
            this.txtShirtAmount.TabIndex = 32;
            this.txtShirtAmount.TextChanged += new System.EventHandler(this.txtShirtAmount_TextChanged);
            // 
            // txtShirtRate
            // 
            this.txtShirtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShirtRate.Location = new System.Drawing.Point(744, 376);
            this.txtShirtRate.Name = "txtShirtRate";
            this.txtShirtRate.Size = new System.Drawing.Size(73, 23);
            this.txtShirtRate.TabIndex = 31;
            this.txtShirtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShirtRate_KeyPress);
            this.txtShirtRate.Validated += new System.EventHandler(this.txtShirtRate_Validated);
            // 
            // txtShirtQty
            // 
            this.txtShirtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShirtQty.Location = new System.Drawing.Point(667, 376);
            this.txtShirtQty.Name = "txtShirtQty";
            this.txtShirtQty.Size = new System.Drawing.Size(56, 23);
            this.txtShirtQty.TabIndex = 30;
            this.txtShirtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShirtQty_KeyPress);
            this.txtShirtQty.Validated += new System.EventHandler(this.txtShirtQty_Validated);
            // 
            // txtOtherAmount
            // 
            this.txtOtherAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherAmount.Location = new System.Drawing.Point(842, 452);
            this.txtOtherAmount.Name = "txtOtherAmount";
            this.txtOtherAmount.ReadOnly = true;
            this.txtOtherAmount.Size = new System.Drawing.Size(73, 23);
            this.txtOtherAmount.TabIndex = 35;
            this.txtOtherAmount.TextChanged += new System.EventHandler(this.txtOtherAmount_TextChanged);
            // 
            // txtOtherRate
            // 
            this.txtOtherRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherRate.Location = new System.Drawing.Point(744, 452);
            this.txtOtherRate.Name = "txtOtherRate";
            this.txtOtherRate.Size = new System.Drawing.Size(73, 23);
            this.txtOtherRate.TabIndex = 34;
            this.txtOtherRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherRate_KeyPress);
            this.txtOtherRate.Validated += new System.EventHandler(this.txtOtherRate_Validated);
            // 
            // txtOtherQty
            // 
            this.txtOtherQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherQty.Location = new System.Drawing.Point(667, 452);
            this.txtOtherQty.Name = "txtOtherQty";
            this.txtOtherQty.Size = new System.Drawing.Size(56, 23);
            this.txtOtherQty.TabIndex = 33;
            this.txtOtherQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherQty_KeyPress);
            this.txtOtherQty.Validated += new System.EventHandler(this.txtOtherQty_Validated);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(744, 569);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(171, 23);
            this.txtTotalAmount.TabIndex = 36;
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNumber.Location = new System.Drawing.Point(23, 9);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(80, 17);
            this.lblBillNumber.TabIndex = 37;
            this.lblBillNumber.Text = "Bill Number";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNumber.Location = new System.Drawing.Point(110, 9);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(100, 23);
            this.txtBillNumber.TabIndex = 38;
            this.txtBillNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillNumber_KeyPress);
            // 
            // cmbBillStatus
            // 
            this.cmbBillStatus.DisplayMember = "Text";
            this.cmbBillStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillStatus.FormattingEnabled = true;
            this.cmbBillStatus.Location = new System.Drawing.Point(940, 57);
            this.cmbBillStatus.Name = "cmbBillStatus";
            this.cmbBillStatus.Size = new System.Drawing.Size(200, 24);
            this.cmbBillStatus.TabIndex = 39;
            this.cmbBillStatus.ValueMember = "Id";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(937, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 40;
            this.lblStatus.Text = "Status";
            // 
            // dtSentToTailor
            // 
            this.dtSentToTailor.CustomFormat = "dd/MM/yyyy";
            this.dtSentToTailor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSentToTailor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSentToTailor.Location = new System.Drawing.Point(940, 351);
            this.dtSentToTailor.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtSentToTailor.Name = "dtSentToTailor";
            this.dtSentToTailor.Size = new System.Drawing.Size(200, 23);
            this.dtSentToTailor.TabIndex = 41;
            this.dtSentToTailor.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lblDtSentToTailor
            // 
            this.lblDtSentToTailor.AutoSize = true;
            this.lblDtSentToTailor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtSentToTailor.Location = new System.Drawing.Point(937, 331);
            this.lblDtSentToTailor.Name = "lblDtSentToTailor";
            this.lblDtSentToTailor.Size = new System.Drawing.Size(121, 17);
            this.lblDtSentToTailor.TabIndex = 42;
            this.lblDtSentToTailor.Text = "Sent To Tailor On";
            // 
            // lblPreferredDeliveryDate
            // 
            this.lblPreferredDeliveryDate.AutoSize = true;
            this.lblPreferredDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferredDeliveryDate.Location = new System.Drawing.Point(937, 186);
            this.lblPreferredDeliveryDate.Name = "lblPreferredDeliveryDate";
            this.lblPreferredDeliveryDate.Size = new System.Drawing.Size(157, 17);
            this.lblPreferredDeliveryDate.TabIndex = 44;
            this.lblPreferredDeliveryDate.Text = "Preferred Delivery Date";
            // 
            // dtPreferredDeliveryDt
            // 
            this.dtPreferredDeliveryDt.CustomFormat = "dd/MM/yyyy";
            this.dtPreferredDeliveryDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPreferredDeliveryDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPreferredDeliveryDt.Location = new System.Drawing.Point(940, 206);
            this.dtPreferredDeliveryDt.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtPreferredDeliveryDt.Name = "dtPreferredDeliveryDt";
            this.dtPreferredDeliveryDt.Size = new System.Drawing.Size(200, 23);
            this.dtPreferredDeliveryDt.TabIndex = 43;
            this.dtPreferredDeliveryDt.Value = new System.DateTime(2017, 6, 7, 0, 0, 0, 0);
            // 
            // lblReadyForDeliveryDt
            // 
            this.lblReadyForDeliveryDt.AutoSize = true;
            this.lblReadyForDeliveryDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyForDeliveryDt.Location = new System.Drawing.Point(937, 413);
            this.lblReadyForDeliveryDt.Name = "lblReadyForDeliveryDt";
            this.lblReadyForDeliveryDt.Size = new System.Drawing.Size(163, 17);
            this.lblReadyForDeliveryDt.TabIndex = 46;
            this.lblReadyForDeliveryDt.Text = "Ready For Delivery Date";
            // 
            // dtReadyForDeliveryDt
            // 
            this.dtReadyForDeliveryDt.CustomFormat = "dd/MM/yyyy";
            this.dtReadyForDeliveryDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReadyForDeliveryDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReadyForDeliveryDt.Location = new System.Drawing.Point(940, 433);
            this.dtReadyForDeliveryDt.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtReadyForDeliveryDt.Name = "dtReadyForDeliveryDt";
            this.dtReadyForDeliveryDt.Size = new System.Drawing.Size(200, 23);
            this.dtReadyForDeliveryDt.TabIndex = 45;
            this.dtReadyForDeliveryDt.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lblDeliveredDt
            // 
            this.lblDeliveredDt.AutoSize = true;
            this.lblDeliveredDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveredDt.Location = new System.Drawing.Point(937, 492);
            this.lblDeliveredDt.Name = "lblDeliveredDt";
            this.lblDeliveredDt.Size = new System.Drawing.Size(102, 17);
            this.lblDeliveredDt.TabIndex = 48;
            this.lblDeliveredDt.Text = "Delivered Date";
            // 
            // dtDeliveredDt
            // 
            this.dtDeliveredDt.CustomFormat = "dd/MM/yyyy";
            this.dtDeliveredDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDeliveredDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeliveredDt.Location = new System.Drawing.Point(940, 512);
            this.dtDeliveredDt.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtDeliveredDt.Name = "dtDeliveredDt";
            this.dtDeliveredDt.Size = new System.Drawing.Size(200, 23);
            this.dtDeliveredDt.TabIndex = 47;
            this.dtDeliveredDt.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lblBillDt
            // 
            this.lblBillDt.AutoSize = true;
            this.lblBillDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDt.Location = new System.Drawing.Point(937, 113);
            this.lblBillDt.Name = "lblBillDt";
            this.lblBillDt.Size = new System.Drawing.Size(60, 17);
            this.lblBillDt.TabIndex = 50;
            this.lblBillDt.Text = "Bill Date";
            // 
            // dtBillDt
            // 
            this.dtBillDt.CustomFormat = "dd/MM/yyyy";
            this.dtBillDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBillDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBillDt.Location = new System.Drawing.Point(940, 133);
            this.dtBillDt.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtBillDt.Name = "dtBillDt";
            this.dtBillDt.Size = new System.Drawing.Size(200, 23);
            this.dtBillDt.TabIndex = 49;
            this.dtBillDt.Value = new System.DateTime(2017, 6, 8, 7, 49, 33, 0);
            // 
            // lblBillFormErrorMessage
            // 
            this.lblBillFormErrorMessage.AutoSize = true;
            this.lblBillFormErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillFormErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblBillFormErrorMessage.Location = new System.Drawing.Point(110, 39);
            this.lblBillFormErrorMessage.Name = "lblBillFormErrorMessage";
            this.lblBillFormErrorMessage.Size = new System.Drawing.Size(20, 17);
            this.lblBillFormErrorMessage.TabIndex = 51;
            this.lblBillFormErrorMessage.Text = "   ";
            // 
            // lblPreferredInternalDeliveryDt
            // 
            this.lblPreferredInternalDeliveryDt.AutoSize = true;
            this.lblPreferredInternalDeliveryDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferredInternalDeliveryDt.Location = new System.Drawing.Point(937, 257);
            this.lblPreferredInternalDeliveryDt.Name = "lblPreferredInternalDeliveryDt";
            this.lblPreferredInternalDeliveryDt.Size = new System.Drawing.Size(208, 17);
            this.lblPreferredInternalDeliveryDt.TabIndex = 53;
            this.lblPreferredInternalDeliveryDt.Text = "Preferred Internal Delivery Date";
            // 
            // dtPreferredInternalDeliveryDt
            // 
            this.dtPreferredInternalDeliveryDt.CustomFormat = "dd/MM/yyyy";
            this.dtPreferredInternalDeliveryDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPreferredInternalDeliveryDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPreferredInternalDeliveryDt.Location = new System.Drawing.Point(940, 277);
            this.dtPreferredInternalDeliveryDt.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtPreferredInternalDeliveryDt.Name = "dtPreferredInternalDeliveryDt";
            this.dtPreferredInternalDeliveryDt.Size = new System.Drawing.Size(200, 23);
            this.dtPreferredInternalDeliveryDt.TabIndex = 52;
            this.dtPreferredInternalDeliveryDt.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(110, 534);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(541, 73);
            this.txtNote.TabIndex = 54;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(20, 534);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(45, 17);
            this.lblNotes.TabIndex = 55;
            this.lblNotes.Text = "Notes";
            // 
            // CustomerBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1157, 616);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblPreferredInternalDeliveryDt);
            this.Controls.Add(this.dtPreferredInternalDeliveryDt);
            this.Controls.Add(this.lblBillFormErrorMessage);
            this.Controls.Add(this.lblBillDt);
            this.Controls.Add(this.dtBillDt);
            this.Controls.Add(this.lblDeliveredDt);
            this.Controls.Add(this.dtDeliveredDt);
            this.Controls.Add(this.lblReadyForDeliveryDt);
            this.Controls.Add(this.dtReadyForDeliveryDt);
            this.Controls.Add(this.lblPreferredDeliveryDate);
            this.Controls.Add(this.dtPreferredDeliveryDt);
            this.Controls.Add(this.lblDtSentToTailor);
            this.Controls.Add(this.dtSentToTailor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbBillStatus);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.lblBillNumber);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtOtherAmount);
            this.Controls.Add(this.txtOtherRate);
            this.Controls.Add(this.txtOtherQty);
            this.Controls.Add(this.txtShirtAmount);
            this.Controls.Add(this.txtShirtRate);
            this.Controls.Add(this.txtShirtQty);
            this.Controls.Add(this.txtTrouserAmount);
            this.Controls.Add(this.txtTrouserRate);
            this.Controls.Add(this.txtTrouserQty);
            this.Controls.Add(this.txtSafaryAmount);
            this.Controls.Add(this.txtSafaryRate);
            this.Controls.Add(this.txtSafaryQty);
            this.Controls.Add(this.txtJacketAmount);
            this.Controls.Add(this.txtJacketRate);
            this.Controls.Add(this.txtJacketQty);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtSuitAmount);
            this.Controls.Add(this.txtSuitRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtSuitQty);
            this.Controls.Add(this.txtOtherMeasurement);
            this.Controls.Add(this.txtShirtMeasurement);
            this.Controls.Add(this.txtTrouserMeasurement);
            this.Controls.Add(this.txtSafaryMeasurement);
            this.Controls.Add(this.txtJacketMeasurement);
            this.Controls.Add(this.txtSuitMeasurement);
            this.Controls.Add(this.lblOthers);
            this.Controls.Add(this.lblShirts);
            this.Controls.Add(this.lblTrousers);
            this.Controls.Add(this.lblSafaries);
            this.Controls.Add(this.lblJackets);
            this.Controls.Add(this.lblSuits);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TailorSoft - Customer Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblSuits;
        private System.Windows.Forms.Label lblJackets;
        private System.Windows.Forms.Label lblSafaries;
        private System.Windows.Forms.Label lblTrousers;
        private System.Windows.Forms.Label lblShirts;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.TextBox txtSuitMeasurement;
        private System.Windows.Forms.TextBox txtJacketMeasurement;
        private System.Windows.Forms.TextBox txtSafaryMeasurement;
        private System.Windows.Forms.TextBox txtTrouserMeasurement;
        private System.Windows.Forms.TextBox txtShirtMeasurement;
        private System.Windows.Forms.TextBox txtOtherMeasurement;
        private System.Windows.Forms.TextBox txtSuitQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtSuitRate;
        private System.Windows.Forms.TextBox txtSuitAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtJacketAmount;
        private System.Windows.Forms.TextBox txtJacketRate;
        private System.Windows.Forms.TextBox txtJacketQty;
        private System.Windows.Forms.TextBox txtSafaryAmount;
        private System.Windows.Forms.TextBox txtSafaryRate;
        private System.Windows.Forms.TextBox txtSafaryQty;
        private System.Windows.Forms.TextBox txtTrouserAmount;
        private System.Windows.Forms.TextBox txtTrouserRate;
        private System.Windows.Forms.TextBox txtTrouserQty;
        private System.Windows.Forms.TextBox txtShirtAmount;
        private System.Windows.Forms.TextBox txtShirtRate;
        private System.Windows.Forms.TextBox txtShirtQty;
        private System.Windows.Forms.TextBox txtOtherAmount;
        private System.Windows.Forms.TextBox txtOtherRate;
        private System.Windows.Forms.TextBox txtOtherQty;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.ComboBox cmbBillStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtSentToTailor;
        private System.Windows.Forms.Label lblDtSentToTailor;
        private System.Windows.Forms.Label lblPreferredDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtPreferredDeliveryDt;
        private System.Windows.Forms.Label lblReadyForDeliveryDt;
        private System.Windows.Forms.DateTimePicker dtReadyForDeliveryDt;
        private System.Windows.Forms.Label lblDeliveredDt;
        private System.Windows.Forms.DateTimePicker dtDeliveredDt;
        private System.Windows.Forms.Label lblBillDt;
        private System.Windows.Forms.DateTimePicker dtBillDt;
        private System.Windows.Forms.Label lblBillFormErrorMessage;
        private System.Windows.Forms.Label lblPreferredInternalDeliveryDt;
        private System.Windows.Forms.DateTimePicker dtPreferredInternalDeliveryDt;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNotes;
    }
}
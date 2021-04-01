
namespace In_class_Assignment2
{
    partial class Lab2
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
            this.radioClothing = new System.Windows.Forms.RadioButton();
            this.radioEquipmentAccessories = new System.Windows.Forms.RadioButton();
            this.radioJuiceBar = new System.Windows.Forms.RadioButton();
            this.radioMembership = new System.Windows.Forms.RadioButton();
            this.radioPersonalTraining = new System.Windows.Forms.RadioButton();
            this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMemberId = new System.Windows.Forms.Label();
            this.richTextBoxWelcom = new System.Windows.Forms.RichTextBox();
            this.textBoxPromotion = new System.Windows.Forms.TextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.checkBoxImageVisible = new System.Windows.Forms.CheckBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSignature = new System.Windows.Forms.Label();
            this.maskedTextBoxMemberId = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // radioClothing
            // 
            this.radioClothing.AutoSize = true;
            this.radioClothing.Location = new System.Drawing.Point(21, 47);
            this.radioClothing.Name = "radioClothing";
            this.radioClothing.Size = new System.Drawing.Size(104, 29);
            this.radioClothing.TabIndex = 1;
            this.radioClothing.TabStop = true;
            this.radioClothing.Text = "Clothing";
            this.radioClothing.UseVisualStyleBackColor = true;
            // 
            // radioEquipmentAccessories
            // 
            this.radioEquipmentAccessories.AutoSize = true;
            this.radioEquipmentAccessories.Location = new System.Drawing.Point(21, 82);
            this.radioEquipmentAccessories.Name = "radioEquipmentAccessories";
            this.radioEquipmentAccessories.Size = new System.Drawing.Size(231, 29);
            this.radioEquipmentAccessories.TabIndex = 2;
            this.radioEquipmentAccessories.TabStop = true;
            this.radioEquipmentAccessories.Text = "Equipment / Accessories";
            this.radioEquipmentAccessories.UseVisualStyleBackColor = true;
            // 
            // radioJuiceBar
            // 
            this.radioJuiceBar.AutoSize = true;
            this.radioJuiceBar.Location = new System.Drawing.Point(21, 117);
            this.radioJuiceBar.Name = "radioJuiceBar";
            this.radioJuiceBar.Size = new System.Drawing.Size(104, 29);
            this.radioJuiceBar.TabIndex = 3;
            this.radioJuiceBar.TabStop = true;
            this.radioJuiceBar.Text = "Juice Bar";
            this.radioJuiceBar.UseVisualStyleBackColor = true;
            // 
            // radioMembership
            // 
            this.radioMembership.AutoSize = true;
            this.radioMembership.Location = new System.Drawing.Point(21, 152);
            this.radioMembership.Name = "radioMembership";
            this.radioMembership.Size = new System.Drawing.Size(137, 29);
            this.radioMembership.TabIndex = 4;
            this.radioMembership.TabStop = true;
            this.radioMembership.Text = "Membership";
            this.radioMembership.UseVisualStyleBackColor = true;
            // 
            // radioPersonalTraining
            // 
            this.radioPersonalTraining.AutoSize = true;
            this.radioPersonalTraining.Location = new System.Drawing.Point(21, 187);
            this.radioPersonalTraining.Name = "radioPersonalTraining";
            this.radioPersonalTraining.Size = new System.Drawing.Size(169, 29);
            this.radioPersonalTraining.TabIndex = 5;
            this.radioPersonalTraining.TabStop = true;
            this.radioPersonalTraining.Text = "Personal Training";
            this.radioPersonalTraining.UseVisualStyleBackColor = true;
            // 
            // groupBoxDepartment
            // 
            this.groupBoxDepartment.Controls.Add(this.radioPersonalTraining);
            this.groupBoxDepartment.Controls.Add(this.radioMembership);
            this.groupBoxDepartment.Controls.Add(this.radioClothing);
            this.groupBoxDepartment.Controls.Add(this.radioJuiceBar);
            this.groupBoxDepartment.Controls.Add(this.radioEquipmentAccessories);
            this.groupBoxDepartment.Enabled = false;
            this.groupBoxDepartment.Location = new System.Drawing.Point(38, 95);
            this.groupBoxDepartment.Name = "groupBoxDepartment";
            this.groupBoxDepartment.Size = new System.Drawing.Size(266, 253);
            this.groupBoxDepartment.TabIndex = 6;
            this.groupBoxDepartment.TabStop = false;
            this.groupBoxDepartment.Text = "Department";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(353, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 25);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(489, 95);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(271, 31);
            this.textBoxName.TabIndex = 8;
            // 
            // labelMemberId
            // 
            this.labelMemberId.AutoSize = true;
            this.labelMemberId.Location = new System.Drawing.Point(353, 147);
            this.labelMemberId.Name = "labelMemberId";
            this.labelMemberId.Size = new System.Drawing.Size(102, 25);
            this.labelMemberId.TabIndex = 9;
            this.labelMemberId.Text = "Member ID";
            // 
            // richTextBoxWelcom
            // 
            this.richTextBoxWelcom.Location = new System.Drawing.Point(353, 204);
            this.richTextBoxWelcom.Name = "richTextBoxWelcom";
            this.richTextBoxWelcom.Size = new System.Drawing.Size(407, 99);
            this.richTextBoxWelcom.TabIndex = 11;
            this.richTextBoxWelcom.Text = "";
            this.richTextBoxWelcom.Visible = false;
            // 
            // textBoxPromotion
            // 
            this.textBoxPromotion.Location = new System.Drawing.Point(353, 317);
            this.textBoxPromotion.Name = "textBoxPromotion";
            this.textBoxPromotion.Size = new System.Drawing.Size(407, 31);
            this.textBoxPromotion.TabIndex = 12;
            this.textBoxPromotion.Visible = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(38, 377);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(266, 212);
            this.pictureBoxImage.TabIndex = 13;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Visible = false;
            // 
            // checkBoxImageVisible
            // 
            this.checkBoxImageVisible.AutoSize = true;
            this.checkBoxImageVisible.Location = new System.Drawing.Point(38, 606);
            this.checkBoxImageVisible.Name = "checkBoxImageVisible";
            this.checkBoxImageVisible.Size = new System.Drawing.Size(144, 29);
            this.checkBoxImageVisible.TabIndex = 14;
            this.checkBoxImageVisible.Text = "Image Visible";
            this.checkBoxImageVisible.UseVisualStyleBackColor = true;
            this.checkBoxImageVisible.Visible = false;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(637, 403);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(112, 34);
            this.buttonSignIn.TabIndex = 15;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Location = new System.Drawing.Point(637, 443);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(112, 34);
            this.buttonPrint.TabIndex = 16;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(637, 527);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Location = new System.Drawing.Point(637, 487);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 34);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelSignature
            // 
            this.labelSignature.AutoSize = true;
            this.labelSignature.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSignature.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSignature.Location = new System.Drawing.Point(659, 616);
            this.labelSignature.Name = "labelSignature";
            this.labelSignature.Size = new System.Drawing.Size(151, 23);
            this.labelSignature.TabIndex = 19;
            this.labelSignature.Text = "Yuriko Uchida";
            // 
            // maskedTextBoxMemberId
            // 
            this.maskedTextBoxMemberId.Location = new System.Drawing.Point(489, 144);
            this.maskedTextBoxMemberId.Mask = "00000";
            this.maskedTextBoxMemberId.Name = "maskedTextBoxMemberId";
            this.maskedTextBoxMemberId.Size = new System.Drawing.Size(150, 31);
            this.maskedTextBoxMemberId.TabIndex = 20;
            this.maskedTextBoxMemberId.ValidatingType = typeof(int);
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 648);
            this.Controls.Add(this.maskedTextBoxMemberId);
            this.Controls.Add(this.labelSignature);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.checkBoxImageVisible);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.textBoxPromotion);
            this.Controls.Add(this.richTextBoxWelcom);
            this.Controls.Add(this.labelMemberId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDepartment);
            this.Name = "Lab2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In Form";
            this.groupBoxDepartment.ResumeLayout(false);
            this.groupBoxDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioClothing;
        private System.Windows.Forms.RadioButton radioEquipmentAccessories;
        private System.Windows.Forms.RadioButton radioJuiceBar;
        private System.Windows.Forms.RadioButton radioMembership;
        private System.Windows.Forms.RadioButton radioPersonalTraining;
        private System.Windows.Forms.GroupBox groupBoxDepartment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.RichTextBox richTextBoxWelcom;
        private System.Windows.Forms.TextBox textBoxPromotion;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.CheckBox checkBoxImageVisible;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelSignature;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMemberId;
    }
}
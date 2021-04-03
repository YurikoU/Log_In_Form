
namespace Lab2_Winter2021
{
    partial class Lab2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioClothing = new System.Windows.Forms.RadioButton();
            this.radioEquipment = new System.Windows.Forms.RadioButton();
            this.radioJuiceBar = new System.Windows.Forms.RadioButton();
            this.radioMembership = new System.Windows.Forms.RadioButton();
            this.radioPersonalTraining = new System.Windows.Forms.RadioButton();
            this.groupDepartment = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMemberId = new System.Windows.Forms.Label();
            this.maskedTextBoxMemberId = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxWelcome = new System.Windows.Forms.RichTextBox();
            this.textBoxPromotion = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSigniture = new System.Windows.Forms.Label();
            this.pictureBoxDepartment = new System.Windows.Forms.PictureBox();
            this.checkBoxImageVisible = new System.Windows.Forms.CheckBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.groupDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // radioClothing
            // 
            this.radioClothing.AutoSize = true;
            this.radioClothing.Location = new System.Drawing.Point(22, 46);
            this.radioClothing.Name = "radioClothing";
            this.radioClothing.Size = new System.Drawing.Size(104, 29);
            this.radioClothing.TabIndex = 1;
            this.radioClothing.TabStop = true;
            this.radioClothing.Text = "Clothing";
            this.radioClothing.UseVisualStyleBackColor = true;
            // 
            // radioEquipment
            // 
            this.radioEquipment.AutoSize = true;
            this.radioEquipment.Location = new System.Drawing.Point(22, 81);
            this.radioEquipment.Name = "radioEquipment";
            this.radioEquipment.Size = new System.Drawing.Size(231, 29);
            this.radioEquipment.TabIndex = 2;
            this.radioEquipment.TabStop = true;
            this.radioEquipment.Text = "Equipment / Accessories";
            this.radioEquipment.UseVisualStyleBackColor = true;
            // 
            // radioJuiceBar
            // 
            this.radioJuiceBar.AutoSize = true;
            this.radioJuiceBar.Location = new System.Drawing.Point(22, 116);
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
            this.radioMembership.Location = new System.Drawing.Point(22, 151);
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
            this.radioPersonalTraining.Location = new System.Drawing.Point(22, 186);
            this.radioPersonalTraining.Name = "radioPersonalTraining";
            this.radioPersonalTraining.Size = new System.Drawing.Size(169, 29);
            this.radioPersonalTraining.TabIndex = 5;
            this.radioPersonalTraining.TabStop = true;
            this.radioPersonalTraining.Text = "Personal Training";
            this.radioPersonalTraining.UseVisualStyleBackColor = true;
            // 
            // groupDepartment
            // 
            this.groupDepartment.Controls.Add(this.radioJuiceBar);
            this.groupDepartment.Controls.Add(this.radioPersonalTraining);
            this.groupDepartment.Controls.Add(this.radioClothing);
            this.groupDepartment.Controls.Add(this.radioMembership);
            this.groupDepartment.Controls.Add(this.radioEquipment);
            this.groupDepartment.Enabled = false;
            this.groupDepartment.Location = new System.Drawing.Point(47, 106);
            this.groupDepartment.Name = "groupDepartment";
            this.groupDepartment.Size = new System.Drawing.Size(282, 243);
            this.groupDepartment.TabIndex = 6;
            this.groupDepartment.TabStop = false;
            this.groupDepartment.Text = "Department";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(389, 138);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 25);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(511, 135);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(235, 31);
            this.textBoxName.TabIndex = 9;
            // 
            // labelMemberId
            // 
            this.labelMemberId.AutoSize = true;
            this.labelMemberId.Location = new System.Drawing.Point(389, 180);
            this.labelMemberId.Name = "labelMemberId";
            this.labelMemberId.Size = new System.Drawing.Size(102, 25);
            this.labelMemberId.TabIndex = 10;
            this.labelMemberId.Text = "Member ID";
            // 
            // maskedTextBoxMemberId
            // 
            this.maskedTextBoxMemberId.Location = new System.Drawing.Point(511, 177);
            this.maskedTextBoxMemberId.Mask = "0000";
            this.maskedTextBoxMemberId.Name = "maskedTextBoxMemberId";
            this.maskedTextBoxMemberId.Size = new System.Drawing.Size(150, 31);
            this.maskedTextBoxMemberId.TabIndex = 11;
            this.maskedTextBoxMemberId.ValidatingType = typeof(int);
            // 
            // richTextBoxWelcome
            // 
            this.richTextBoxWelcome.Location = new System.Drawing.Point(389, 239);
            this.richTextBoxWelcome.Name = "richTextBoxWelcome";
            this.richTextBoxWelcome.Size = new System.Drawing.Size(357, 69);
            this.richTextBoxWelcome.TabIndex = 12;
            this.richTextBoxWelcome.Text = "";
            this.richTextBoxWelcome.Visible = false;
            // 
            // textBoxPromotion
            // 
            this.textBoxPromotion.Location = new System.Drawing.Point(389, 318);
            this.textBoxPromotion.Name = "textBoxPromotion";
            this.textBoxPromotion.Size = new System.Drawing.Size(357, 31);
            this.textBoxPromotion.TabIndex = 13;
            this.textBoxPromotion.Visible = false;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(637, 428);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(112, 34);
            this.buttonSignIn.TabIndex = 14;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Location = new System.Drawing.Point(637, 468);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(112, 34);
            this.buttonPrint.TabIndex = 15;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(637, 508);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 34);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(637, 548);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSigniture
            // 
            this.labelSigniture.AutoSize = true;
            this.labelSigniture.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSigniture.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelSigniture.Location = new System.Drawing.Point(637, 620);
            this.labelSigniture.Name = "labelSigniture";
            this.labelSigniture.Size = new System.Drawing.Size(151, 23);
            this.labelSigniture.TabIndex = 18;
            this.labelSigniture.Text = "Yuriko Uchida";
            // 
            // pictureBoxDepartment
            // 
            this.pictureBoxDepartment.Location = new System.Drawing.Point(47, 355);
            this.pictureBoxDepartment.Name = "pictureBoxDepartment";
            this.pictureBoxDepartment.Size = new System.Drawing.Size(282, 238);
            this.pictureBoxDepartment.TabIndex = 19;
            this.pictureBoxDepartment.TabStop = false;
            this.pictureBoxDepartment.Visible = false;
            // 
            // checkBoxImageVisible
            // 
            this.checkBoxImageVisible.AutoSize = true;
            this.checkBoxImageVisible.Enabled = false;
            this.checkBoxImageVisible.Location = new System.Drawing.Point(47, 599);
            this.checkBoxImageVisible.Name = "checkBoxImageVisible";
            this.checkBoxImageVisible.Size = new System.Drawing.Size(144, 29);
            this.checkBoxImageVisible.TabIndex = 20;
            this.checkBoxImageVisible.Text = "Image Visible";
            this.checkBoxImageVisible.UseVisualStyleBackColor = true;
            this.checkBoxImageVisible.CheckedChanged += new System.EventHandler(this.checkBoxImageVisible_CheckedChanged);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.checkBoxImageVisible);
            this.Controls.Add(this.pictureBoxDepartment);
            this.Controls.Add(this.labelSigniture);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPromotion);
            this.Controls.Add(this.richTextBoxWelcome);
            this.Controls.Add(this.maskedTextBoxMemberId);
            this.Controls.Add(this.labelMemberId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupDepartment);
            this.Controls.Add(this.label1);
            this.Name = "Lab2";
            this.Text = "Sign In Form";
            this.groupDepartment.ResumeLayout(false);
            this.groupDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioClothing;
        private System.Windows.Forms.RadioButton radioEquipment;
        private System.Windows.Forms.RadioButton radioJuiceBar;
        private System.Windows.Forms.RadioButton radioMembership;
        private System.Windows.Forms.RadioButton radioPersonalTraining;
        private System.Windows.Forms.GroupBox groupDepartment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMemberId;
        private System.Windows.Forms.RichTextBox richTextBoxWelcome;
        private System.Windows.Forms.TextBox textBoxPromotion;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSigniture;
        private System.Windows.Forms.PictureBox pictureBoxDepartment;
        private System.Windows.Forms.CheckBox checkBoxImageVisible;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}


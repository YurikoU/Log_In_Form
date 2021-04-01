/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due Date: April 7, 2021
Lab 2
*/



using In_class_Assignment2.Properties;
using System;
using System.Windows.Forms;

namespace In_class_Assignment2
{
    public partial class Lab2 : Form
    {
        String name;
        String id;

        public Lab2()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            maskedTextBoxMemberId.Text = "";
        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            id = maskedTextBoxMemberId.Text;

            if (name != null && id.Length == 5)
            {
                //Name and ID forms will be invisible
                labelName.Visible = false;
                textBoxName.Visible = false;
                labelMemberId.Visible = false;
                maskedTextBoxMemberId.Visible = false;

                //Button availability will be switched
                buttonSignIn.Enabled = false;
                buttonPrint.Enabled = true;
                buttonClear.Enabled = false;

                //Following properties will enable
                richTextBoxWelcom.Visible = true;
                textBoxPromotion.Visible = true;
                groupBoxDepartment.Enabled = true;
                pictureBoxImage.Visible = true;
                checkBoxImageVisible.Visible = true;

                richTextBoxWelcom.Text = "Welcome " + name + "!\nYour member ID: " + id;
            }
        }


        private void radioClothing_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "All items are 10% OFF now!";
　          pictureBoxImage.Image = Resources.clothing;
        }

        private void radioEquipmentAccessories_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Weight training tools, yoga mat, balance balls, etc";
            pictureBoxImage.Image = Resources.accessories;
        }

        private void radioJuiceBar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Fresh fruit juice at Juice Bar";
            pictureBoxImage.Image = Resources.Juice_bar;
        }

        private void radioMembership_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "You are welcome to join our membership";
          　pictureBoxImage.Image = Resources.membership;
        }

        private void radioPersonalTraining_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Everyday available from 8 AM to 9 PM";
            pictureBoxImage.Image = Resources.personal_training;
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {   
            //Exit the application
            this.Close();
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            buttonPrint.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            buttonPrint.Print();
        }

        private void checkBoxImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxImage.Visible = true;
            }
            else {
                pictureBoxImage.Visible = false;
            }
        }
    }
}

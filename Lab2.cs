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
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxImage.Image = Resources.clothing;
            } 
            else {
                pictureBoxImage.Enabled = false;
            }
        }

        private void radioEquipmentAccessories_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Weight training tools, yoga mat, balance balls, etc";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxImage.Image = Resources.accessories;
            }
            else {
                pictureBoxImage.Enabled = false;
            }
        }

        private void radioJuiceBar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Fresh fruit juice at Juice Bar";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxImage.Image = Resources.Juice_bar;
            }
            else {
                pictureBoxImage.Enabled = false;
            }
        }

        private void radioMembership_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "You are welcome to join our membership";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxImage.Image = Resources.membership;
            }
            else {
                pictureBoxImage.Enabled = false;
            }
        }

        private void radioPersonalTraining_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Everyday available from 8 AM to 9 PM";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxImage.Image = Resources.personal_training;
            }
            else {
                pictureBoxImage.Enabled = false;
            }
        }





    }
}

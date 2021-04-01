/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due Date: April 7, 2021
Lab 2
*/



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

            if (name != null && id != null)
            {
                //Name and ID forms will be invisible
                labelName.Visible = false;
                textBoxName.Visible = false;
                labelMemberId.Visible = false;
                maskedTextBoxMemberId.Visible = false;

                //Button availability will be switched
                buttonSignIn.Enabled = false;
                buttonPrint.Enabled = true;
                buttonClear.Enabled = true;

                //Following properties will enable
                richTextBoxWelcom.Visible = true;
                textBoxPromotion.Visible = true;
                groupBoxDepartment.Enabled = true;
                pictureBoxImage.Visible = true;
                checkBoxImageVisible.Visible = true;

                richTextBoxWelcom.Text = "Welcome " + name + "!\nYour member ID: " + id;
            }

        }




    }
}

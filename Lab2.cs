﻿/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due Date: April 7, 2021
Lab 2
*/

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Lab2_Winter2021
{
    public partial class Lab2 : Form
    {

        public Lab2()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Delete user input
            textBoxName.Text = "";
            maskedTextBoxMemberId.Text = "";
        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String id = maskedTextBoxMemberId.Text;

            if (name != "" && id.Length == 4)
            {
                // Name and ID forms will be invisible
                labelName.Visible = false;
                textBoxName.Visible = false;
                labelMemberId.Visible = false;
                maskedTextBoxMemberId.Visible = false;
                labelAlartName.Visible = false;
                labelAlartId.Visible = false;

                // Button availability will be switched
                buttonSignIn.Enabled = false;
                buttonPrint.Enabled = true;
                buttonClear.Enabled = false;
                buttonSignOut.Enabled = true;

                // Following properties will enable
                richTextBoxWelcome.Visible = true;
                textBoxPromotion.Visible = true;
                groupDepartment.Enabled = true;
                checkBoxImageVisible.Enabled = true;
                richTextBoxWelcome.Text = "Welcome " + name + "!\nYour member ID: " + id;
            } 
            if (name == "")
            {
                labelAlartName.Visible = true;
            } 
            if (id.Length < 4)
            {
                labelAlartId.Visible = true;
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            this.Close();
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // Add PrintPageEventHandler
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            // Call printDocument and start print process
            printDocument.Print();
        }


        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create an image
            Image img = Image.FromFile("fitness_center.jpg");
            // Draw an image to screen
            e.Graphics.DrawImage(img, e.MarginBounds);
            // No next page
            e.HasMorePages = false;
            // End the print operation
            img.Dispose();
        }


        private void radioClothing_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "All items are 10% OFF now!";
            if (checkBoxImageVisible.Checked)
            {
                // A proper image will be shown only when "Image Visible" checkbox is checked
                pictureBoxDepartment.Image = Properties.Resources.clothing;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }



        private void radioEquipment_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Workout tools, yoga mat, balance balls, etc";
            if (checkBoxImageVisible.Checked)
            {
                // A proper image will be shown only when "Image Visible" checkbox is checked
                pictureBoxDepartment.Image = Properties.Resources.accessories;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }


        private void radioJuiceBar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Fresh fruit juice at Juice Bar";
            if (checkBoxImageVisible.Checked)
            {
                // A proper image will be shown only when "Image Visible" checkbox is checked
                pictureBoxDepartment.Image = Properties.Resources.juice_bar;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }

        private void radioMembership_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "You are welcome to join our membership";
            if (checkBoxImageVisible.Checked)
            {
                // A proper image will be shown only when "Image Visible" checkbox is checked
                pictureBoxDepartment.Image = Properties.Resources.membership;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }


        private void radioPersonalTraining_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Everyday available from 8 AM to 9 PM";
            if (checkBoxImageVisible.Checked)
            {
                // A proper image will be shown only when "Image Visible" checkbox is checked
                pictureBoxDepartment.Image = Properties.Resources.personal_training;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }

        private void checkBoxImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxImageVisible.Checked)
            {
                // If "Image Visible" checkbox is NOT checked, no image will be shown
                pictureBoxDepartment.Image = null;
            }
            else
            {
                // A proper image will be shown based on the selected radio button
                if (radioClothing.Checked)
                {
                    pictureBoxDepartment.Image = Properties.Resources.clothing;
                } 
                else if (radioEquipment.Checked) {
                    pictureBoxDepartment.Image = Properties.Resources.accessories;
                }
                else if (radioJuiceBar.Checked)
                {
                    pictureBoxDepartment.Image = Properties.Resources.juice_bar;
                }
                else if (radioMembership.Checked)
                {
                    pictureBoxDepartment.Image = Properties.Resources.membership;
                }
                else if (radioPersonalTraining.Checked)
                {
                    pictureBoxDepartment.Image = Properties.Resources.personal_training;
                }

            }

        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            maskedTextBoxMemberId.Text = "";

            labelName.Visible = true;
            textBoxName.Visible = true;
            labelMemberId.Visible = true;
            maskedTextBoxMemberId.Visible = true;
            labelAlartName.Visible = false;
            labelAlartId.Visible = false;
            buttonSignIn.Enabled = true;
            buttonPrint.Enabled = false;
            buttonClear.Enabled = true;
            richTextBoxWelcome.Visible = false;
            textBoxPromotion.Visible = false;
            groupDepartment.Enabled = false;
            checkBoxImageVisible.Enabled = false;
            buttonSignOut.Enabled = false;
        }
    }
}

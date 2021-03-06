﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            fieldName.Text = "Name";
            fieldName.Tag = "Name";
            fieldName.ForeColor = Color.LightGray;

            fieldSurname.Text = "Surname";
            fieldSurname.Tag = "Surname";
            fieldSurname.ForeColor = Color.LightGray;

            fieldEmail.Text = "E-mail";
            fieldEmail.Tag = "E-mail";
            fieldEmail.ForeColor = Color.LightGray;

            fieldPassword.Text = "Password";
            fieldPassword.Tag = "Password";
            fieldPassword.ForeColor = Color.LightGray;

            fieldPasswordRepeat.Text = "Repeat Password";
            fieldPasswordRepeat.Tag = "Repeat Password";
            fieldPasswordRepeat.ForeColor = Color.LightGray;

        }


        private void Field_Enter(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if (field.Text == (string)field.Tag)
            {
            field.Text = string.Empty;
            field.ForeColor = Color.Black;
            }
            if((string)field.Tag=="Password"||(string)field.Tag=="Repeat Password")
            {
                field.PasswordChar = '*';
            }
        }

        private void Field_Leave(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if (field.Text == string.Empty)
            {
                field.Text = (string)field.Tag;
                field.ForeColor = Color.LightGray;
                if ((string)field.Tag == "Password" || (string)field.Tag == "Repeat Password")
                {
                    field.PasswordChar = '\0';
                }
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                fieldPassword.PasswordChar = '\0';
                fieldPasswordRepeat.PasswordChar = '\0';
            }
            else
            {
                if (fieldPassword.Text != (string)fieldPassword.Tag)
                {
                fieldPassword.PasswordChar = '*';
                }
                if (fieldPasswordRepeat.Text != (string)fieldPasswordRepeat.Tag)
                {
                fieldPasswordRepeat.PasswordChar = '*';
                }

            }
        }
    }
    
}

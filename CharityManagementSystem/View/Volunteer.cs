﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharityManagementSystem.Model;

namespace CharityManagementSystem.View
{
    public partial class Volunteer : Form
    {
        Login login;
        public Volunteer(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully applied as a volunteer for this event.\nThank you for your support!",
                    "Application Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully applied as a volunteer for this event.\nThank you for your support!",
                    "Application Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully applied as a volunteer for this event.\nThank you for your support!",
                    "Application Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully applied as a volunteer for this event.\nThank you for your support!",
                    "Application Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm pf = new ProfileForm(login);
            pf.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Volunteer_Load(object sender, EventArgs e)
        {

        }
    }
}

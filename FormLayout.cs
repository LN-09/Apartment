﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDK_CanHo_DaoCongTri
{
    public partial class FormLayout : Form
    {
        public FormLayout()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenFormChild(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_type_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormType());
            lbl_head.Text = btn_type.Text;
        }

        private void btn_apartment_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormApartment());
            lbl_head.Text = btn_apartment.Text;
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {

        }

        private void btn_request_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl_head.Text = "HOME";
        }
    }
}
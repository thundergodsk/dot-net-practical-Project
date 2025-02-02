﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;

            }
        }
        protected void lbSt_id(object sender, EventArgs e)
        {
            ddlSt_id.Items.Add("1");
            ddlSt_id.Items.Add("2");
        }

        protected void btnQual_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnPers_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
            lblPer.Text = txtPer.Text;
            lblBoard.Text = ddlBoard.SelectedValue;
            lblPass.Text = ddlYear1.SelectedValue;
        }

        protected void btnQuald_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }


        protected void btnQual2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void lbTerms_Click(object sender, EventArgs e)
        {
            Response.Redirect("termcond.aspx");
        }
        protected void btnPrint_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
            if (cbTerms.Checked)
            {
                Response.Redirect("termcond.aspx");
            }
            else
            {
                Response.Write(rfpert.Text);
            }
        }
        protected void btnFinal_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
            lblName.Text = txtName.Text;
            lblMnum.Text = txtMnum.Text;
            lblmail.Text = txtEmail.Text;
            lblCity.Text = ddlCity.Text;
            lblStudid.Text = ddlSt_id.SelectedValue;
            lblGender.Text = rbGender.SelectedValue;
            lblClass.Text = cbHobby.SelectedValue;
            lblBoard2.Text = ddlBoard.SelectedValue;
            lblpassy.Text = ddlYear1.SelectedValue;
            lblPer2.Text = txtPer.Text;
            lbldob.Text = txtcal.Text;
        }

    }
}
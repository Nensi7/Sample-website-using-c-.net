using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac11
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phoneNo = txtPhoneNo.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate the input
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phoneNo) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                // Show an error message if any field is empty
                Response.Write("<script>alert('All fields are required.');</script>");
                return;
            }

            if (password != confirmPassword)
            {
                // Show an error message if passwords do not match
                Response.Write("<script>alert('Passwords do not match.');</script>");
                return;
            }

            // Here you can add logic to save the user details to a database
            // For demonstration, we will just show a success message
            Response.Write("<script>alert('Registration successful!');</script>");

            // Optionally, you can clear the fields after submission
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }
    }
}


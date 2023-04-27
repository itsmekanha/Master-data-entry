using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace WindowsFormsApp4
{
    public partial class MasterDataEntry : Form
    {
        Dictionary<string, string> Errors = new Dictionary<string, string>();
        public MasterDataEntry()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            String name_regex = @"^[A-Z][a-z]+\s[A-Z][a-z]+$";
            if(!RegEx.ReferenceEquals(name_regex, txtName.Text))
            {
                Errors["Name"] = "Name should have First Name and LastName, caps at the start and space in between";
            }
            else
            {
                if(Errors.ContainsKey("Name"))
                    Errors.Remove("Name");
            }

            Reloadvalidation();
           
        }

        private void Reloadvalidation()
        {
            //throw new NotImplementedException();
            txtValidationMessage.Text = "";
            string error = string.Empty;
            foreach(string key in Errors.Keys)
            {
                error += Errors[key] + "\n";
            }
            txtValidationMessage.Text = error; 
        }
         
        private void txtMb_TextChanged(object sender, EventArgs e)
        {
             
            String Mb_regex = @"^\+91[6789][0-9]{9}$";
            if (!RegEx.ReferenceEquals(Mb_regex, txtMb.Text))
            {
                Errors["Mb"] = "Mb number should start with +91 and should have 10 digits";
            }
            else
            {
                if (Errors.ContainsKey("Mb"))
                    Errors.Remove("Mb");
            }

            Reloadvalidation();
        }

        private void txtValidationMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email_regex = @"^[A-Za-z0-9]{4,15}@[a-z]{4,10}\.(com|net)$";
            if (!RegEx.ReferenceEquals(email_regex, txtEmail .Text))
            {
                Errors["Email"] = ".com and .net emails are only valid";
            }
            else
            {
                if (Errors.ContainsKey("Email"))
                    Errors.Remove("Email");
            }

            Reloadvalidation();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = RegEx.ExtractPattern(@"[A-Z][a-z]+\s", txtName.Text);
            txtValidationMessage.Text = firstname + "Registered";

            User user = new User();
            user.Name = txtName.Text;
            user.Address = txtAddress.Text;
            user.City = txtCity.Text;
            user.Email = txtEmail.Text;
            user.Mb = txtMb.Text;
            //user.SetUserID("123");

            user.Serialize("Sample.xml");
        }

        private void MasterDataEntry_Load(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Show_entered_data s2=new Show_entered_data();
            s2.Show();

        }
    }
}

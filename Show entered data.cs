using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Show_entered_data : Form
    {
        public string City;
        public DataSet ds;

        public Show_entered_data()
        {
            InitializeComponent();
            /*
            DataSet ds = new DataSet();
            ds.ReadXml("Sample.xml");

            PopulateCitiesComboBox.DataSource = ds.Tables[0];
            PopulateCitiesComboBox.DisplayMember = "City";
            PopulateCitiesComboBox.ValueMember = "City";
            */
        }

        private void PopulateCitiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            List<User> user = new List<User>();

            
            // Deserialize the data from the XML file
            if (File.Exists("Sample.xml"))
            {
                using (FileStream stream = new FileStream("Sample.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    user = (List<User>)serializer.Deserialize(stream);
                }
            }

            // Get all unique city names from the list
            List<string> cities = user.Select(User => User.City).Distinct().ToList();

            // Add the city names to the ComboBox
           // PopulateCitiesComboBox.Items.AddRange(cities.ToArray());
           
            PopulateCitiesComboBox.Items.AddRange(cities.ToArray());
           

            /*

            if (PopulateCitiesComboBox.SelectedValue != null)
            {
                string City = (string)PopulateCitiesComboBox.SelectedValue;
                DataTable dt = ds.Tables[1].Select("City = " + City.ToString()).CopyToDataTable();
                //dataGridView1.DataSource = dt;
            }*/

        }

        private void ShowDataInGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            List<User> user = new List<User>();

            // Deserialize the data from the XML file
            if (File.Exists("Sample.xml"))
            {
                using (FileStream stream = new FileStream("Sample.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    user = (List<User>)serializer.Deserialize(stream);
                }
            }

            // Filter the list based on the selected city
            List<User> filteredUser = user.Where(u => u.City == City).ToList();
        }
    }
}

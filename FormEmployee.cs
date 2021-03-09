using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace QLCF
{
    public partial class FormEmployee : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        String username;
        public FormEmployee(string _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Xin chào " + username;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAS_KELOMPOK
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string name, email, password;

			name = guna2TextBox1.Text;
			password = guna2TextBox2.Text;

			if (name == "admin" && password == "12345")
			{
				Dashboard log = new Dashboard();
				this.Hide();
				log.Show();
			}
			else
			{
				MessageBox.Show("Incorrect email or password");
			}
		}

		private void guna2TextBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

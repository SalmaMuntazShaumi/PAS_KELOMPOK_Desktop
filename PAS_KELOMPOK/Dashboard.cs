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
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			int price, items, total;
			price = int.Parse(this.guna2TextBox1.Text);
			items = int.Parse(this.guna2TextBox2.Text);
			total = price * items;
			this.guna2TextBox3.Text = total.ToString();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Cashier log = new Cashier();
			this.Hide();
			log.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			guna2TextBox1.Text = "";
			guna2TextBox2.Text = "";
			guna2TextBox3.Text = "";
		}
	}
}

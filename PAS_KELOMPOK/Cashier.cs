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
	public partial class Cashier : Form
	{
		public Cashier()
		{
			InitializeComponent();
		}

		private void guna2TextBox5_TextChanged(object sender, EventArgs e)
		{


		}
	
		private void guna2HtmlLabel4_Click(object sender, EventArgs e)
		{

		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Cashier_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			int total, cash, Return;
			total = int.Parse(this.guna2TextBox1.Text);
			cash = int.Parse(this.guna2TextBox4.Text);
			Return = cash - total;
			this.guna2TextBox5.Text = Return.ToString();
		}
	}
}

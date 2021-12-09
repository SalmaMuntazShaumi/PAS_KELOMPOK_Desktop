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
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}

		int startpoint = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			startpoint += 1;
			guna2ProgressBar1.Value = startpoint;
			if (guna2ProgressBar1.Value == 100)
			{
				guna2ProgressBar1.Value = 0;
				timer1.Stop();
				login log = new login();
				this.Hide();
				log.Show();
			}
		}

		private void SplashScreen_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}

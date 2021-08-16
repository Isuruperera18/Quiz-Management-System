using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Quiz_Management_System
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int Count = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			Count += 1;
			PB1.Value = Count;
			lblPre.Text = Count + "%";
			if (PB1.Value == 100)
			{
				PB1.Value = 0;
				timer1.Stop();
				StudentLogin u1 = new StudentLogin();
				u1.Show();
				this.Hide();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}

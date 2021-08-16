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
	public partial class StuInstructions : Form
	{
		public StuInstructions()
		{
			InitializeComponent();
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			StudentLogin s1 = new StudentLogin();
			s1.Show();
			this.Hide();
		}
	}
}

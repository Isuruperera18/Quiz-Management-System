using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Online_Quiz_Management_System
{
	public partial class Instructions : Form
	{

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn
		 (
			  int nLeftRect,
			  int nTopRect,
			  int nRightRect,
			  int nBottomRect,
			  int nWidthEllipse,
			  int nHeightEllipse

		  );

		public Instructions()
		{
			InitializeComponent();

			pnlNav.Height = btnIns.Height;
			pnlNav.Top = btnIns.Top;
			pnlNav.Left = btnIns.Left;
			btnIns.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void Instructions_Load(object sender, EventArgs e)
		{

		}

		private void btnQu_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnQu.Height;
			pnlNav.Top = btnQu.Top;
			btnQu.BackColor = Color.FromArgb(205, 92, 92);

			Questions q5 = new Questions();
			q5.Show();
			this.Hide();
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnSub.Height;
			pnlNav.Top = btnSub.Top;
			btnSub.BackColor = Color.FromArgb(205, 92, 92);

			Subjects s5 = new Subjects();
			s5.Show();
			this.Hide();
		}

		private void btnCan_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnCan.Height;
			pnlNav.Top = btnCan.Top;
			btnCan.BackColor = Color.FromArgb(205, 92, 92);

			Candidates c5 = new Candidates();
			c5.Show();
			this.Hide();
		}

		private void btnRe_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnRe.Height;
			pnlNav.Top = btnRe.Top;
			btnRe.BackColor = Color.FromArgb(205, 92, 92);

			Results r5 = new Results();
			r5.Show();
			this.Hide();
		}

		private void btnIns_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnIns.Height;
			pnlNav.Top = btnIns.Top;
			pnlNav.Left = btnIns.Left;
			btnIns.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnLog.Height;
			pnlNav.Top = btnLog.Top;
			btnLog.BackColor = Color.FromArgb(205, 92, 92);

			AdminLogin a5 = new AdminLogin();
			a5.Show();
			this.Hide();
		}

		private void btnQu_Leave(object sender, EventArgs e)
		{
			btnQu.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnSub_Leave(object sender, EventArgs e)
		{
			btnSub.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnCan_Leave(object sender, EventArgs e)
		{
			btnCan.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnRe_Leave(object sender, EventArgs e)
		{
			btnRe.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnIns_Leave(object sender, EventArgs e)
		{
			btnIns.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnLog_Leave(object sender, EventArgs e)
		{
			btnLog.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

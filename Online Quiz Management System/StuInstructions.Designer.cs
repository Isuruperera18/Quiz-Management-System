
namespace Online_Quiz_Management_System
{
	partial class StuInstructions
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuInstructions));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.btnLog = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightCoral;
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.btnLog);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(189, 600);
			this.panel1.TabIndex = 4;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
			this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox6.Location = new System.Drawing.Point(46, 25);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(82, 86);
			this.pictureBox6.TabIndex = 33;
			this.pictureBox6.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lithos Pro Regular", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 36);
			this.label1.TabIndex = 28;
			this.label1.Text = "IQuiz";
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox5.Location = new System.Drawing.Point(117, 555);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(42, 46);
			this.pictureBox5.TabIndex = 31;
			this.pictureBox5.TabStop = false;
			// 
			// btnLog
			// 
			this.btnLog.FlatAppearance.BorderSize = 0;
			this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLog.Font = new System.Drawing.Font("Lithos Pro Regular", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLog.ForeColor = System.Drawing.Color.Black;
			this.btnLog.Location = new System.Drawing.Point(0, 555);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(185, 45);
			this.btnLog.TabIndex = 25;
			this.btnLog.Text = "   Back";
			this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLog.UseVisualStyleBackColor = true;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(480, 43);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(148, 32);
			this.label10.TabIndex = 76;
			this.label10.Text = "Instructions";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(940, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 28);
			this.label9.TabIndex = 77;
			this.label9.Text = "X";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// StuInstructions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(977, 600);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StuInstructions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StuInstructions";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
	}
}
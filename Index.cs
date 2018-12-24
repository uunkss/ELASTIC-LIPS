using System;
using System.Drawing;
using System.Windows.Forms;

namespace ELASTIC_LIPS
{
	/// <summary>
	/// Description of Index.
	/// </summary>
	public partial class Index : Form
	{
		public Index()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm M = new MainForm();
			M.Show();
			this.Hide();
		}
		void PictureBox4Click(object sender, EventArgs e)
		{
			pictureBox4.BackColor = Color.Transparent;
		}
	}
}

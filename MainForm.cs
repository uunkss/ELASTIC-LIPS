using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ELASTIC_LIPS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
			Index first = new Index();
			first.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Address ad = new Address();
			ad.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			int rowIndex1 = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.Rows.RemoveAt(rowIndex1);
		}
		void Button4Click(object sender, EventArgs e)
		{
			int n = dataGridView1.Rows.Add();
			dataGridView1.Rows[n].Cells[0].Value = comboBox1.Text;
			dataGridView1.Rows[n].Cells[1].Value = "37";
		}
		void Button3Click(object sender, EventArgs e)
		{
			one o = new one();
			o.Show();
		}
		void Button7Click(object sender, EventArgs e)
		{
			two tw = new two();
			tw.Show();
		}
		void Button8Click(object sender, EventArgs e)
		{
			three th = new three();
			th.Show();
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!char.IsDigit(ch) && ch != 8 && ch !=46)
			{
				e.Handled = true;
			}
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Button6Click(object sender, EventArgs e)
		{
			label4.Text = "0";
			for (int i = 0 ; i < dataGridView1.Rows.Count; i++)
			{
				label4.Text = Convert.ToString(int.Parse(label4.Text) + int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
		}
	}
}
}

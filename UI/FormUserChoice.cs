using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_Ex02_HarelLevi_308549807_EranShmuel_205477383.UI
{
	public partial class FormUserChoice : Form
	{
		public string Question { get; set; }
		public bool Choice { get; set; }
		public FormUserChoice(string i_Question)
		{
			InitializeComponent();
			Question = i_Question;
			m_QuestionLabel.Text = i_Question;
		}
		private void buttonNo_Click(object sender, EventArgs e)
		{
			Choice = false;
			this.Dispose();
		}
		private void buttonYes_Click(object sender, EventArgs e)
		{
			Choice = true;
			this.Dispose();
		}
		private void UserChoiceForm_Load(object sender, EventArgs e)
		{

		}

		
	}
}


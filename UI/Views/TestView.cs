using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class TestView : MetroForm
	{
		#region Public Constructors

		public TestView(Image image)
		{
			InitializeComponent();
			this.pictureBox1.Image = image;
		}

		#endregion Public Constructors

		#region event handler

		void mbtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion event handler
	}
}
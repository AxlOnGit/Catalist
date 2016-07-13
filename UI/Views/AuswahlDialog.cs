using System;
using System.Drawing;
using MetroFramework;
using MetroFramework.Forms;

namespace Products.Common.Views
{
	public partial class AuswahlDialog : MetroForm
	{

		#region members

		string[] myOptionen;
		string myTitel = string.Empty;
		MetroColorStyle myStyle  = MetroColorStyle.Default;
		int selectedOption;

		#endregion

		#region public properties

		/// <summary>
		/// Gibt den Index der ausgewählten Option zurück.
		/// </summary>
		public int SelectedOption
		{
			get { return selectedOption; }
		}

		#endregion

		#region ### .ctor ###

		public AuswahlDialog(string titel, string[] optionen, MetroColorStyle style = MetroColorStyle.Red)
		{
			InitializeComponent();
			this.myOptionen = optionen;
			this.myTitel = titel;
			this.myStyle = style;
			this.Style = myStyle;

			InitializeData();
		}

		#endregion

		#region event handler

		void btn_Click(object sender, EventArgs e)
		{
			var button = sender as MetroFramework.Controls.MetroButton;
			this.selectedOption = (int)(button).Tag;
			button.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		#endregion

		#region private procedures

		void InitializeData()
		{
			int opts = myOptionen.Length;
			mlblTitel.Text = myTitel;
			this.Width = 80 + (opts * 120) + ((opts-1) * 20);
			SetPicture();

			for (int i = 0; i < opts; i++)
			{
				var btn = new MetroFramework.Controls.MetroButton();
				btn.Text = myOptionen[i];
				btn.Size = new System.Drawing.Size(120, 30);
				btn.Location = new Point(40 + (i * (btn.Width + 20)), this.Height - 100);
				btn.Style = myStyle;
				btn.Name = string.Format("btnOption{0}", i);
				btn.TabIndex = i;
				btn.UseSelectable = true;
				btn.UseStyleColors = true;
				btn.Tag = i;
				btn.Click += btn_Click;
				this.Controls.Add(btn);
			}
		}

		void SetPicture()
		{
			switch (myStyle)
			{
				case MetroColorStyle.Black:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroblue;
					break;
				case MetroColorStyle.Blue:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroblue;
					break;
				case MetroColorStyle.Brown:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroblue;
					break;
				case MetroColorStyle.Default:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroblue;
					break;
				case MetroColorStyle.Green:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metrogreen;
					break;
				case MetroColorStyle.Lime:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metrolime;
					break;
				case MetroColorStyle.Magenta:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metrored;
					break;
				case MetroColorStyle.Orange:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroorange;
					break;
				case MetroColorStyle.Pink:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metrored;
					break;
				case MetroColorStyle.Purple:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metropink;
					break;
				case MetroColorStyle.Red:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metrored;
					break;
				case MetroColorStyle.Silver:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroblue;
					break;
				case MetroColorStyle.Teal:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroblue;
					break;
				case MetroColorStyle.White:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroblue;
					break;
				case MetroColorStyle.Yellow:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroyellow;
					break;
				default:
					this.picFragezeichen.Image = global::Products.Common.Properties.Resources.frage_32_metroblue;
					break;
			}
		}


		#endregion

	}
}

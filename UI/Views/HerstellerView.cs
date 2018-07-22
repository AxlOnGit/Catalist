using MetroFramework.Forms;
using Products.Model;
using Products.Model.Entities;
using System;

namespace Products.Common.Views
{
	public partial class HerstellerView : MetroForm
	{
		#region MEMBERS

		readonly Hersteller myHersteller;
		bool saveChanges;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="HerstellerView"/> Formularklasse.
		/// </summary>
		/// <param name="hersteller">Der anzuzeigende Hersteller.</param>
		/// <remarks>
		/// Wenn keine Hersteller Instanz angegeben wird, erstellt das System einen neuen
		/// Hersteller und zeigt diesen an.
		/// </remarks>
		public HerstellerView(Hersteller hersteller = null)
		{
			InitializeComponent();
			if (hersteller == null) hersteller = ModelManager.SharedItemsService.AddHersteller();
			this.myHersteller = hersteller;
			this.InitializeData();
		}

		#endregion ### .ctor ###

		#region EVENT HANDLER

		void mbtnOk_Click(object sender, EventArgs e)
		{
			this.saveChanges = true;
			this.Close();
		}

		void mbtnCancel_Click(object sender, EventArgs e)
		{
			this.saveChanges = false;
			this.Close();
		}

		void HerstellerView_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			if (this.saveChanges) ModelManager.SharedItemsService.UpdateHersteller();
		}

		#endregion EVENT HANDLER

		#region PRIVATE PROCEDURES

		void InitializeData()
		{
			this.mtxtHerstellername.DataBindings.Add("Text", this.myHersteller, "Herstellername");
		}

		#endregion PRIVATE PROCEDURES
	}
}
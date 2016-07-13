using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Products.Common.Panel
{
	public partial class pnlSlider : MetroFramework.Controls.MetroUserControl
	{

		#region members

		readonly ContainerControl parentCtrl;
		bool myIsLoaded;

		#endregion

		#region Events

		public event EventHandler OnClosed;

		public event EventHandler OnShown;

		protected virtual void Closed(EventArgs e)
		{
			OnClosed?.Invoke(this, e);
		}

		protected virtual void Shown(EventArgs e)
		{
			OnShown?.Invoke(this, e);
		}

		#endregion

		#region public properties

		/// <summary>
		/// Legt fest, ob das Panel nach dem Ausblenden geladen bleibt.
		/// </summary>
		public bool KeepLoaded { get; private set; }

		#endregion

		#region ### .ctor ###

		public pnlSlider()
		{
			InitializeComponent();
		}

		public pnlSlider(ContainerControl parent, bool keepLoaded)
		{
			InitializeComponent();
			this.Visible = false;
			this.KeepLoaded = keepLoaded;

			parent.Controls.Add(this);
			this.parentCtrl = parent;
			this.BringToFront();
			parent.Resize += owner_Resize;

			ResizeForm();
		}

		#endregion

		void pnlSlider_Click(object sender, EventArgs e)
		{
			this.Swipe(false);
		}


		void owner_Resize(object sender, EventArgs e)
		{
			this.ResizeForm();
		}

		void ResizeForm()
		{
			this.Width = parentCtrl.Width;
			this.Height = parentCtrl.Height - 192;
			this.Location = new Point(myIsLoaded ? 0 : parentCtrl.Width, 100);
		}

		public void Swipe(bool show = true)
		{
			this.Visible = true;
			var transasition = new Transition(new TransitionType_EaseInEaseOut(5));	
			transasition.add(this, "Left", show ? 0 : this.Width);
			transasition.run();

			while (this.Left != (show ? 0 : this.Width))
			{
				Application.DoEvents();
			}

			if (!show)
			{
				this.Closed(new EventArgs());
				this.parentCtrl.Resize -= owner_Resize;
				if (!this.KeepLoaded)
				{
					this.parentCtrl.Controls.Remove(this);
					this.Dispose();
				}
			}
			else
			{
				this.myIsLoaded = true;
				this.parentCtrl.Resize += owner_Resize;
				this.ResizeForm();
				this.Shown(new EventArgs());
			}
		}

	}
}

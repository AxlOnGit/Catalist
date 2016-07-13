using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Products.Common.Controls
{
	public class axlTextbox : TextBox
	{

		#region PInvoke Helpers

		static uint ECM_FIRST = 0x1500;
		static readonly uint EM_SETCUEBANNER = ECM_FIRST + 1;

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
		static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, IntPtr wParam, String lParam);

		#endregion PInvoke Helpers

		#region Watermark

		string _watermark = string.Empty;

		/// <summary>
		/// Gets or sets the text the <see cref="TextBox"/> will display as a cue to the user.
		/// </summary>
		[Description("The text value to be displayed as a watermark.")]
		[Category("Appearance")]
		[DefaultValue("")]
		[Localizable(true)]
		public string Watermark
		{
			get { return _watermark; }
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				if (!_watermark.Equals(value, StringComparison.CurrentCulture))
				{
					_watermark = value;
					UpdateWatermark();
					OnWatermarkChanged(EventArgs.Empty);
				}
			}
		}

		/// <summary>
		/// Occurs when the <see cref="Watermark"/> property value changes.
		/// </summary>
		public event EventHandler WatermarkChanged;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnWatermarkChanged(EventArgs e)
		{
			WatermarkChanged?.Invoke(this, e);
		}

		#endregion Watermark

		#region ShowWatermarkOnFocus

		bool _showWatermarkWithFocus;

		/// <summary>
		/// Gets or sets a value indicating whether the <see cref="TextBox"/> will display the <see cref="Watermark"/>
		/// even when the control has focus.
		/// </summary>
		[Description("Indicates whether the watermark will be displayed even if the control has focus.")]
		[Category("Appearance")]
		[DefaultValue(false)]
		[Localizable(true)]
		public bool ShowWatermarkWithFocus
		{
			get { return _showWatermarkWithFocus; }
			set
			{
				if (_showWatermarkWithFocus != value)
				{
					_showWatermarkWithFocus = value;
					UpdateWatermark();
					OnShowWatermarkWithFocusChanged(EventArgs.Empty);
				}
			}
		}

		/// <summary>
		/// Occurs when the <see cref="ShowWatermarkWithFocus"/> property value changes.
		/// </summary>
		public event EventHandler ShowWatermarkWithFocusChanged;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnShowWatermarkWithFocusChanged(EventArgs e)
		{
			ShowWatermarkWithFocusChanged?.Invoke(this, e);
		}

		#endregion ShowWatermarkOnFocus

		#region Overrides

		protected override void OnHandleCreated(EventArgs e)
		{
			UpdateWatermark();
			base.OnHandleCreated(e);
		}

		#endregion Overrides

		void UpdateWatermark()
		{
			// Called if a handle isn't yet created
			if (this.IsHandleCreated)
			{
				SendMessage(new HandleRef(this, this.Handle), EM_SETCUEBANNER, (_showWatermarkWithFocus) ? new IntPtr(1) : IntPtr.Zero, _watermark);
			}
		}

	}
}


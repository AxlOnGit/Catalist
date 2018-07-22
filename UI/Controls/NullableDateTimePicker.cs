using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;

// Copyright (c) 2005 Claudio Grazioli, http://www.grazioli.ch
//
// This code is free software; you can redistribute it and/or modify it. However, this
// header must remain intact and unchanged. Additional information may be appended after
// this header. Publications based on this code must also include an appropriate reference.
//
// This code is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

namespace Products.UI.Controls
{
	/// <summary>
	/// Represents a Windows date time picker control. It enhances the .NET standard
	/// <b>DateTimePicker</b> control with the possibility to show empty values (null values).
	/// </summary>
	[ComVisible(false)]
	public class NullableDateTimePicker : MetroDateTime
	{
		#region Member variables

		bool myIsNull;  // true, when no date shall be displayed (empty DateTimePicker)
		string myNullValue;  // If _isNull = true, this value is shown in the DTP
		DateTimePickerFormat myFormat = DateTimePickerFormat.Short;  // The format of the DateTimePicker control
		string myCustomFormat;  // The custom format of the DateTimePicker control
		string myFormatAsString;  // The format of the DateTimePicker control as string

		#endregion Member variables

		#region ### .ctor ###

		/// <summary>
		/// Default Constructor
		/// </summary>
		public NullableDateTimePicker()
		{
			base.Format = DateTimePickerFormat.Custom;
			NullValue = " ";
			Format = DateTimePickerFormat.Short;
			this.DataBindings.CollectionChanged += DataBindings_CollectionChanged;
		}

		#endregion ### .ctor ###

		#region event handler

		void DataBindings_CollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Add)
			{
				this.DataBindings[this.DataBindings.Count - 1].Parse += NullableDateTimePicker_Parse;
			}
		}

		void NullableDateTimePicker_Parse(object sender, ConvertEventArgs e)
		{
			if (myIsNull) e.Value = null;
		}

		#endregion event handler

		#region Public properties

		/// <summary>
		/// Gets or sets the date/time value assigned to the control.
		/// </summary>
		/// <value>The DateTime value assigned to the control</value>
		/// <remarks>
		/// <p>
		/// If the <b>Value</b> property has not been changed in code or by the user, it is
		/// set to the current date and time ( <see cref="DateTime.Now"/>).
		/// </p>
		/// <p>If <b>Value</b> is <b>null</b>, the DateTimePicker shows <see cref="NullValue"/>.</p>
		/// </remarks>
		[Bindable(true)]
		[Browsable(false)]
		public new object Value
		{
			get
			{
				if (myIsNull)
					return null;
				return base.Value;
			}
			set
			{
				if (value == null || value == DBNull.Value)
				{
					SetToNullValue();
				}
				else
				{
					SetToDateTimeValue();
					base.Value = (DateTime)value;
				}
			}
		}

		/// <summary>
		/// Gets or sets the format of the date and time displayed in the control.
		/// </summary>
		/// <value>
		/// One of the <see cref="DateTimePickerFormat"/> values. The default is <see cref="DateTimePickerFormat.Long"/>.
		/// </value>
		[Browsable(true)]
		[DefaultValue(DateTimePickerFormat.Short), TypeConverter(typeof(Enum))]
		public new DateTimePickerFormat Format
		{
			get { return myFormat; }
			set
			{
				myFormat = value;
				if (!myIsNull)
					SetFormat();
				OnFormatChanged(EventArgs.Empty);
			}
		}

		/// <summary>
		/// Gets or sets the custom date/time format string. <value>A string that
		/// represents the custom date/time format. The default is a null reference (
		/// <b>Nothing</b> in Visual Basic).</value>
		/// </summary>
		public new string CustomFormat
		{
			get { return myCustomFormat; }
			set { myCustomFormat = value; }
		}

		/// <summary>
		/// Gets or sets the string value that is assigned to the control as null value.
		/// </summary>
		/// <value>The string value assigned to the control as null value.</value>
		/// <remarks>
		/// If the <see cref="Value"/> is <b>null</b>, <b>NullValue</b> is shown in the
		/// <b>DateTimePicker</b> control.
		/// </remarks>
		[Browsable(true)]
		[Category("Behavior")]
		[Description("Der Text, der angezeigt wird, wenn im Steuerelement ein Nullwert angezeigt wird.")]
		[DefaultValue(" ")]
		public string NullValue
		{
			get { return myNullValue; }
			set { myNullValue = value; }
		}

		#endregion Public properties

		#region Private methods/properties

		/// <summary>
		/// Stores the current format of the DateTimePicker as string.
		/// </summary>
		string FormatAsString
		{
			get { return myFormatAsString; }
			set
			{
				myFormatAsString = value;
				base.CustomFormat = value;
			}
		}

		/// <summary>
		/// Sets the format according to the current DateTimePickerFormat.
		/// </summary>
		void SetFormat()
		{
			var ci = Thread.CurrentThread.CurrentCulture;
			var dtf = ci.DateTimeFormat;
			switch (myFormat)
			{
				case DateTimePickerFormat.Long:
					FormatAsString = dtf.LongDatePattern;
					break;

				case DateTimePickerFormat.Short:
					FormatAsString = dtf.ShortDatePattern;
					break;

				case DateTimePickerFormat.Time:
					FormatAsString = dtf.ShortTimePattern;
					break;

				case DateTimePickerFormat.Custom:
					FormatAsString = this.CustomFormat;
					break;
			}
		}

		/// <summary>
		/// Sets the <b>DateTimePicker</b> to the value of the <see cref="NullValue"/> property.
		/// </summary>
		void SetToNullValue()
		{
			myIsNull = true;
			base.CustomFormat = (string.IsNullOrEmpty(myNullValue)) ? " " : "'" + myNullValue + "'";
		}

		/// <summary>
		/// Sets the <b>DateTimePicker</b> back to a non null value.
		/// </summary>
		void SetToDateTimeValue()
		{
			if (myIsNull)
			{
				SetFormat();
				myIsNull = false;
				base.OnValueChanged(new EventArgs());
			}
		}

		#endregion Private methods/properties

		#region Events

		/// <summary>
		/// This member overrides <see cref="Control.WndProc"/>.
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc(ref Message m)
		{
			if (myIsNull)
			{
				if (m.Msg == 0x4e)  // WM_NOTIFY
				{
					var nm = (NMHDR)m.GetLParam(typeof(NMHDR));
					if (nm.Code == -746 || nm.Code == -722) // DTN_CLOSEUP || DTN_?
						SetToDateTimeValue();
				}
			}
			base.WndProc(ref m);
		}

		[StructLayout(LayoutKind.Sequential)]
		struct NMHDR
		{
			public IntPtr HwndFrom;
			public IntPtr IdFrom;
			public int Code;
		}

		/// <summary>
		/// This member overrides <see cref="Control.OnKeyDown"/>.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnKeyUp(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.Value = null;
				OnValueChanged(EventArgs.Empty);
			}
			base.OnKeyUp(e);
		}

		protected override void OnValueChanged(EventArgs eventargs)
		{
			base.OnValueChanged(eventargs);
		}

		#endregion Events
	}
}
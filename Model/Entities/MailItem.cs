using System;
using DvApi32;
using Products.Common.Interfaces;

namespace Products.Model.Entities
{
	public class MailItem : ILinkedItem
	{

		#region members

		readonly MessageItem2 myBase;
		readonly string myFullName;

		#endregion

		#region public properties

		#region ILinkedItem

		public string Key
		{
			get
			{
				return this.myFullName;
			}
		}

		public string LinkTypeId
		{
			get
			{
				return "86234120-f630-4815-aaf8-1e7298187acd";
			}
		}

		public string ItemName
		{
			get
			{
				return string.Format("E-Mail: {0}", this.myBase.Subject);
			}
		}

		public string LinkTypBezeichnung
		{
			get
			{
				return "E-Mail";
			}
		}

		#endregion

		/// <summary>
		/// Gibt das Statusdatum der E-Mail zurück.
		/// </summary>
		public DateTime Datum { get { return (DateTime)David.DavidManager.DavidService.GetFieldValue(this.myBase, David.DavidFieldsEnum.CreatedAt); } }

		public string Von { get { return (string)David.DavidManager.DavidService.GetFieldValue(this.myBase, David.DavidFieldsEnum.From); } }

		public string An { get { return (string)David.DavidManager.DavidService.GetFieldValue(this.myBase, David.DavidFieldsEnum.To); } }

		public string Betreff { get { return (string)David.DavidManager.DavidService.GetFieldValue(this.myBase, David.DavidFieldsEnum.Subject); } }

		public string BodyASCII { get { return (string)David.DavidManager.DavidService.GetFieldValue(this.myBase, David.DavidFieldsEnum.Content); } }

		public string BodyHtml { get { return (string)David.DavidManager.DavidService.GetFieldValue(this.myBase, David.DavidFieldsEnum.HTML); } }

		/// <summary>
		/// Gibt den vollständigen Pfad der E-Mail auf dem David Server zurück.
		/// </summary>
		public string FullName { get { return this.myFullName; } }

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der <seealso cref="MailItem"/> Klasse.
		/// </summary>
		/// <param name="baseItem">Die zugrundeliegende <seealso cref="MessageItem2"/> Instanz.</param>
		public MailItem(MessageItem2 baseItem, string fullName)
		{
			this.myBase = baseItem;
			this.myFullName = fullName;
		}

		#endregion

	}
}

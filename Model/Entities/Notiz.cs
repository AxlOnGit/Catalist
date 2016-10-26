using System;
using System.Linq;
using Products.Common.Interfaces;
using Products.Common;
using Products.Data;
using Products.Data.Datasets;
using System.Collections.Generic;
using Products.Common.Collections;

namespace Products.Model.Entities
{
	public class Notiz : ILinkedItem
	{

		#region members

		readonly dsNotes.NoteRow myBase;
		//SortableBindingList<FileLink> myDateilinkList;

		#endregion

		#region public properties

		#region ILinkedItem

		/// <summary>
		/// Primärschlüssel der ILinkedItem Instanz.
		/// </summary>
		public string Key
		{
			get { return this.myBase.UID; }
		}

		/// <summary>
		/// Primärschlüssel des LinkTyps der ILinkedItem Instanz,.
		/// </summary>
		public string LinkTypeId
		{
			get { return ModelManager.SharedItemsService.GetLinkTypeByName("Notiz").UID; }
		}

		public string ItemName
		{
			get { return this.myBase.Subject; }
		}

		public string LinkTypBezeichnung
		{
			get { return "Notiz"; }
		}

		#endregion

		/// <summary>
		/// Primärschlüssel dieser Notiz.
		/// </summary>
		public string UID { get { return myBase.UID; } }

		/// <summary>
		/// Primärschlüssel der übergeordneten Entität.
		/// </summary>
		public string ParentItemId { get { return this.myBase.ParentItemId; } }

		/// <summary>
		/// Primärschlüssel des Typs der übergeordneten Entität.
		/// </summary>
		public string ParentItemTypeId { get { return this.myBase.ParentItemTypeId; } }

		/// <summary>
		/// Gibt die Nummer des Ansprechpartners zurück.
		/// </summary>
		public string ContactNumber
		{
			get
			{
				return this.myBase.ContactNumber;
			}
			set
			{
				this.myBase.ContactNumber = value;
			}
		}

		/// <summary>
		/// Primärschlüssel des Elements, das mit dieser Notiz verknüpft ist.
		/// </summary>
		public string LinkedItemId { get { return this.myBase.LinkedItemId; } }

		/// <summary>
		/// Primärschlüssel des Linktyps des mit dieser Notiz verknüpften ILinkedItems.
		/// </summary>
		public string LinkedItemTypeId { get { return this.myBase.LinkedItemTypeId; } }

		/// <summary>
		/// Titel der Notiz.
		/// </summary>
		public string Subject
		{
			get { return myBase.Subject; }
			set
			{
				myBase.Subject = value;
			}
		}

		/// <summary>
		/// Text der Notiz.
		/// </summary>
		public string Body
		{
			get { return myBase.Body; }
			set
			{
				myBase.Body = value;
			}
		}

		/// <summary>
		/// Der Primärschlüssel des Mitarbeiters, der für diese Notiz zuständig ist.
		/// </summary>
		public string AssignedToId
		{
			get { return myBase.AssignedTo; }
			set
			{
				myBase.AssignedTo = value;
			}
		}

		/// <summary>
		/// Gibt Datum und Uhrzeit der Delegation zurück.
		/// </summary>
		public DateTime AssignedAt
		{
			get { return this.myBase.AssignedAt; }
			set { myBase.AssignedAt = value; }
		}

		/// <summary>
		/// Primärschlüssel des Users, der die Notiz erfasst hat.
		/// </summary>
		public string CreatedById { get { return this.myBase.CreatedBy; } }

		/// <summary>
		/// Gibt das Erfassungsdatum zurück.
		/// </summary>
		public DateTime CreatedAt
		{
			get { return this.myBase.CreatedAt; }
			set { this.myBase.CreatedAt = value; }
		}

		/// <summary>
		/// Gibt True zurück, wenn diese Notiz inaktiv ist.
		/// </summary>
		public bool InactiveFlag
		{
			get
			{
				if (myBase.InactiveFlag == 1)
				{
					return true;
				}
				return false;
			}
			set
			{
				if (value == true)
				{
					myBase.InactiveFlag = 1;
				}
				else myBase.InactiveFlag = 0;
			}
		}

		/// <summary>
		/// Gibt True zurück, wenn die Notiz erledigt ist.
		/// </summary>
		public bool CompletedFlag
		{
			get
			{
				if (myBase.CompletedFlag == 1)
				{
					return true;
				}
				return false;
			}
			set
			{
				if (value == true)
				{
					myBase.CompletedFlag = 1;
				}
				else myBase.CompletedFlag = 0;
			}
		}

		/// <summary>
		/// True, wenn die Notiz Dateiverknüpfungen enthält.
		/// </summary>
		public bool HasDateilinks
		{
			get { return (this.Dateilinks != null && this.Dateilinks.Count > 0); }
		}

		/// <summary>
		/// Zusammenfassung der Metadaten (Erfassung und letzte Änderungen).
		/// </summary>
		public string MetaData
		{
			get
			{
				object[] meta = 
				{
					Environment.NewLine,						    //0
					this.AssignedTo.UserName.ToUpper(), //1
					this.AssignedAt,								    //2
					this.CreatedBy.UserName.ToUpper(),  //3
					this.CreatedAt,									    //4
					this.LinkedItemType.Bezeichnung	    //5
				};
				return string.Format
					(
						"Erfasst von '{3}' ({4:d} um {4:t}){0}Zugewiesen an '{1}' ({2:d} um {2:t}){0}Verknüpft mit: {5}", meta
					);
			}
		}

		#region entities

		/// <summary>
		/// Gibt den Linktyp der übergeordneten Entität zurück.
		/// </summary>
		public Linktyp ParentItemType { get { return ModelManager.SharedItemsService.GetLinkTypeByPK(this.myBase.ParentItemTypeId); } }

		/// <summary>
		/// Gibt den Typ der Verknüpfung zurück.
		/// </summary>
		public Linktyp LinkedItemType { get { return ModelManager.SharedItemsService.GetLinkTypeByPK(this.myBase.LinkedItemTypeId); } }

		/// <summary>
		/// User, der die Notiz erfasst hat.
		/// </summary>
		public User CreatedBy
		{
			get
			{
				if (!string.IsNullOrEmpty(this.myBase.CreatedBy))
				{
					return ModelManager.UserService.FindUser(this.myBase.CreatedBy, Services.UserService.UserSearchParamType.PrimaryKey);
				}
				return null;
			}
		}

		/// <summary>
		/// Gibt die User Instanz zurück, an den die Notiz delegiert wurde.
		/// </summary>
		public User AssignedTo
		{
			get
			{
				return ModelManager.UserService.FindUser(myBase.AssignedTo, Services.UserService.UserSearchParamType.PrimaryKey);
			}
		}

		/// <summary>
		/// Gibt eine sortierbare Liste der mit dieser Notiz verknüpften Dateien zurück.
		/// </summary>
		public SBList<FileLink> Dateilinks
		{
			get
			{
				return ModelManager.FileLinkService.GetFileLinkList(this.UID);
			}
		}

		#endregion

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erstellt eine neue Instanz der Notiz Klasse.
		/// </summary>
		/// <param name="baseRow"></param>
		public Notiz(dsNotes.NoteRow baseRow)
		{
			myBase = baseRow;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Prüft, ob diese Notiz gelöscht werden kann.
		/// False, wenn es mit dieser Notiz verknüpfte Elemente (z. B. Dateilinks) gibt.
		/// </summary>
		/// <returns></returns>
		public bool GetCanDelete()
		{
			return this.Dateilinks == null || this.Dateilinks.Count == 0;
		}

		///// <summary>
		///// Speichert Änderungen an der Dateilink Tabelle.
		///// </summary>
		//public void UpdateDateilinks()
		//{
		//  ModelManager.ModelService.UpdateDateilinks();
		//}

		#endregion

	}
}

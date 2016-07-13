using System;

namespace Products.Common.Parameters
{
	public class CreateServiceterminParams
	{

		#region members



		#endregion

		#region public properties

		public string Kundennummer { get; private set; }
		public string KundenmaschineUid { get; private set; }
		public string TechnikerUid { get; private set; }
		public string Kalendereintrag { get; private set; }
		public string Body { get; private set; }
		public string Subject { get; private set; }
		public string ErstellerUid { get; private set; }
		public DateTime Start { get; private set; }
		public DateTime Ende { get; private set; }
		
		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Erzeugt eine neue Instanz der CreateServiceterminParams Klasse.
		/// </summary>
		/// <param name="kundennummer">Die Nummer des Kunden, dem der Termin zugeordnet werden soll.</param>
		/// <param name="kundenmaschineUid">Der Primärschlüssel der Kundenmaschine, für die der Termin erstellt werden soll.</param>
		public CreateServiceterminParams(string kundennummer, string kundenmaschineUid, string technikerUid, string erstellerUid)
		{
			Kundennummer = kundennummer;
			KundenmaschineUid = kundenmaschineUid;
			TechnikerUid = technikerUid;
			ErstellerUid = erstellerUid;
		}

		#endregion

		#region public procedures

		/// <summary>
		/// Legt die Kundennummer fest.
		/// </summary>
		/// <param name="kundennummer"></param>
		/// <returns></returns>
		public CreateServiceterminParams SetKundennummer(string kundennummer)
		{
			Kundennummer = kundennummer;
			return this;
		}

		/// <summary>
		/// Legt den GUID der Kundenmaschine fest.
		/// </summary>
		/// <param name="kundenmaschineUid"></param>
		/// <returns></returns>
		public CreateServiceterminParams SetKundenmaschineUid(string kundenmaschineUid)
		{
			KundenmaschineUid = kundenmaschineUid;
			return this;
		}

		/// <summary>
		/// Legt den GUID des Technikers (User) fest.
		/// </summary>
		/// <param name="technikerUid"></param>
		/// <returns></returns>
		public CreateServiceterminParams SetTechnikerUid(string technikerUid)
		{
			TechnikerUid = technikerUid;
			return this;
		}

		/// <summary>
		/// Legt Pfad und Dateinamen des verknüpften David Kalendereintrags fest.
		/// </summary>
		/// <param name="kalendereintrag"></param>
		/// <returns></returns>
		public CreateServiceterminParams SetKalendereintrag(string kalendereintrag)
		{
			Kalendereintrag = kalendereintrag;
			return this;
		}

		/// <summary>
		/// Legt den Bodytext des Servicetermins fest.
		/// </summary>
		/// <param name="bodyText"></param>
		/// <returns></returns>
		public CreateServiceterminParams SetBody(string bodyText)
		{
			Body = bodyText;
			return this;
		}

		/// <summary>
		/// Legt die Bezeichnung des Servicetermins fest.
		/// </summary>
		/// <param name="subject"></param>
		/// <returns></returns>
		public CreateServiceterminParams SetSubject(string subject)
		{
			Subject = subject;
			return this;
		}

		/// <summary>
		/// Legt Datum und Uhrzeit des Terminbeginns fest.
		/// </summary>
		/// <param name="start"></param>
		/// <returns></returns>
		public CreateServiceterminParams SetStart(DateTime start)
		{
			Start = start;
			return this;
		}

		/// <summary>
		/// Legt Datum und Uhrzeit des Terminendes fest.
		/// </summary>
		/// <param name="ende"></param>
		/// <returns></returns>
		public CreateServiceterminParams SetEnd(DateTime ende)
		{
			Ende = ende;
			return this;
		}

		#endregion

	}
}

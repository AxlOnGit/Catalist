using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products.Model.Entities
{
	public class WartungsAuswahlKriterium
	{

		#region members
		#endregion

		#region public properties

		/// <summary>
		/// Definiert das Datum, an dem die Wartungstour stattfinden soll.
		/// </summary>
		/// <remarks>
		/// Das Stichtagsdatum definiert das Referenzdatum für die Auswahl der fälligen
		/// </remarks>
		public DateTime Stichtag { get; private set; }

		/// <summary>
		/// Definiert, ob nur Maschinen in der Auswahl erscheinen, für die schon mindestens eine Wartung oder ein Service stattgefunden haben.
		/// </summary>
		public bool MitEinerWartungKennzeichen { get; private set; }

		/// <summary>
		/// Definiert, ob nur Maschinen in der Auswahl erscheinen, für die ein Wartungsintervall größer 0 festgelegt ist.
		/// </summary>
		public bool MitIntervallKennzeichen { get; private set; }

		/// <summary>
		/// Die Anzahl an Monaten, die das Wartungsintervall einer Maschine maximal unterschritten werden darf.
		/// Wartungsintervall - Wert dieser Eigenschaft = Mindestanzahl an Monaten, die die letzte und die nächste Wartung
		/// zeitlich mindestens auseinanderliegen müssen.
		/// </summary>
		/// <remarks>
		/// Beispiel: Wenn das Wartungsintervall auf 12 Monate festgelegt ist und die IntervallUnterschreitungMax auf 2,
		/// werden auch Maschinen angezeigt, bei denen die Wartung statt 12 erst 10 (12-2) Monate zurückliegt.
		/// </remarks>
		public int IntervallUnterschreitungMax { get; private set; }

		/// <summary>
		/// Gibt den Postleitzahlbereich zurück oder legt ihn fest.
		/// </summary>
		public string Postleitzahlbereich { get; private set; }

		#endregion

		#region public procedures

		/// <summary>
		/// Legt den Stichtag der Wartungstour fest.
		/// </summary>
		/// <param name="stichtag"></param>
		/// <returns></returns>
		public WartungsAuswahlKriterium SetStichtag(DateTime stichtag)
		{
			this.Stichtag = stichtag;
			return this;
		}

		/// <summary>
		/// Legt fest, ob die Auswahl nur Maschinen enthält, die mindestens eine Wartung oder einen Service gesehen haben.
		/// </summary>
		/// <param name="jauOchNee"></param>
		/// <returns></returns>
		public WartungsAuswahlKriterium SetMitEinerWartung(bool jauOchNee)
		{
			this.MitEinerWartungKennzeichen = jauOchNee;
			return this;
		}

		/// <summary>
		/// Legt fest, ob die Auswahl nur Maschinen enthält, für die ein Wartungsintervall größer als 0 definiert ist.
		/// </summary>
		/// <param name="jauOchNee"></param>
		/// <returns></returns>
		public WartungsAuswahlKriterium SetMitIntervall(bool jauOchNee)
		{
			this.MitIntervallKennzeichen = jauOchNee;
			return this;
		}

		/// <summary>
		/// Legt den Postleitzahlbereich fest, in dem die Wartungstermine stattfinden sollen.
		/// </summary>
		/// <param name="plz">Postleitzahl oder (Anfangs-)Teil einer Postleitzahl</param>
		/// <param name="minStellen">Die Anzahl von Stellen der PLZ, die beim Eingrenzen der Suche berücksichtigt werden sollen.</param>
		/// <remarks>
		/// Beispiel: Wenn 'plz' den Wert '28201' hat und 'minStellen' den Wert '3', wird die Suche auf den PLZ-Bereich '282' begrenzt.
		/// </remarks>
		/// <returns></returns>
		public WartungsAuswahlKriterium SetPlzBereich(string plz, int minStellen)
		{
			if (plz.Length < minStellen)
			{
				var msg = string.Format("WartungsAuswahlKriterium.SetPlzBereich: Die Zeichenfolge muss mindestens {0} Ziffern enthalten", minStellen);
				throw new ArgumentException(msg, nameof(plz));
			}
			var newValue = plz;
			if (plz.Length > minStellen) newValue = newValue.Substring(0, minStellen);
			this.Postleitzahlbereich = newValue;
			return this;
		}

		#endregion

	}
}

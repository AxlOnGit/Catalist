
namespace Products.Common.Interfaces
{
	public interface ILinkedItem
	{

		/// <summary>
		/// Gibt den Primärschlüssel des Elements zurück.
		/// </summary>
		string Key { get; }

		/// <summary>
		/// Gibt den Primärschlüssel des LinkTyps zurück.
		/// </summary>
		string LinkTypeId { get; }

		/// <summary>
		/// Gibt einen kurzen Text zurück, der z. B. in kurzen Listen
		/// für das verknüpfte Element verwendet werden kann.
		/// </summary>
		string ItemName { get; }

		/// <summary>
		/// Gibt die Bezeichnung eines Elements in der Tabelle cpm_linktyp zurück.
		/// </summary>
		string LinkTypBezeichnung { get; }

	}
}

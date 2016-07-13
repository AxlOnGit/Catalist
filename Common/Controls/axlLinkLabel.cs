using System.Drawing;
using System.Windows.Forms;

namespace Products.Common.Controls
{
	public class axlLinkLabel : LinkLabel
	{

		#region overrides

		

		#endregion

		#region ### .ctor ###

		public axlLinkLabel()
		{
			this.VisitedLinkColor = Color.Blue;
			this.LinkBehavior = LinkBehavior.HoverUnderline;
			this.Margin = new Padding(10, 3, 0, 3);
		}

		#endregion

	}
}

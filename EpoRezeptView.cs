using System;
using System.Windows.Forms;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoRezeptView.
	/// </summary>
	public class EpoRezeptView : EpoCManagerBaseView
	{
		public EpoRezeptView(Epo viewedEpo, object parent) : base(viewedEpo, parent) 
		{
		}
		
		
		protected override void InitSpecialControls() 
		{
			//Die Basis legen
			base.InitSpecialControls();
			
			//und nun etwas verändern
			SetLabel("RubrikOid", "Rubrik");
			SetGeometry("RubrikOid", 1, 1, 11, 1, 20, 1);

			//SetLabel("Name", "Bezeichnung");
			SetGeometry("Name", 1, 2, 11, 2, 20, 1);

			SetLabel("GlasOid", "Glas");
			SetGeometry("GlasOid", 1, 3, 11, 3, 20, 1);

			SetLabel("Zubereitung", "Zubereitung");
			SetGeometry("Zubereitung", 1, 4, 11, 4, 20, 5);

			AddViewedLink("Zutaten",
						  "EpoRezeptZutat",
						  "RezeptOid",
						  null);

			SetLabel("Zutaten", "Zutaten");
			SetGeometry("Zutaten", 1, 10, 11, 10, 20, 5);
			SetLinkEditable("Zutaten", 11, 9);

			AddViewedLink("Garnierungen",
						  "EpoRezeptGarnierung",
						  "RezeptOid",
						  null);
			SetLabel("Garnierungen", "Garnierungen");
			SetGeometry("Garnierungen", 1, 16, 11, 16, 20, 3);
			SetLinkEditable("Garnierungen", 10, 15);
		}
	}
}

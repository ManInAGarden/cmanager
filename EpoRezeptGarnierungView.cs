using System;
using System.Windows.Forms;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoRezeptGarnierungView.
	/// </summary>
	public class EpoRezeptGarnierungView : EpoCManagerBaseView
	{
		public EpoRezeptGarnierungView(Epo viewedEpo, object parent) : base(viewedEpo, parent) 
	{
	}

		public EpoRezeptGarnierungView() : base() 
	{
	}
		
		
		protected override void InitSpecialControls() 
		{
			//Die Basis legen
			base.InitSpecialControls();
			
			//und nun etwas verändern
			SetLabel("RezeptOid", "Rezept");
			SetGeometry("RezeptOid", 1, 1, 11, 1, 20, 1);

			SetLabel("GarnierungOid", "Garnierung");
			SetGeometry("GarnierungOid", 1, 2, 11, 2, 20, 1);

			SetVisibility("Name", false);

			SetLabel("Menge", "Menge");
			SetGeometry("Menge", 1, 3, 11, 3,20, 1);
			
		}
	}
}

using System;
using System.Windows.Forms;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoRezeptZutatView.
	/// </summary>
	public class EpoRezeptZutatView : EpoCManagerBaseView
	{
		public EpoRezeptZutatView(Epo viewedEpo, object parent) : base(viewedEpo, parent) 
		{
		}

		public EpoRezeptZutatView() : base() 
		{
		}
		
		
		protected override void InitSpecialControls() 
		{
			//Die Basis legen
			base.InitSpecialControls();
			
			//und nun etwas verändern
			SetLabel("RezeptOid", "Rezept");
			SetGeometry("RezeptOid", 1, 1, 11, 1, 20, 1);

			SetLabel("ZutatOid", "Zutat");
			SetGeometry("ZutatOid", 1, 2, 11, 2, 20, 1);

			SetVisibility("Name", false);

			SetLabel("Anteil", "Anteil/%");
			SetGeometry("Anteil", 1, 3, 11, 3,20, 1);
			
		}
	}
}

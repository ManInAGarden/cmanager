using System;
using System.Windows.Forms;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoZutatView.
	/// </summary>
	public class EpoZutatView : EpoCManagerBaseView
	{
		public EpoZutatView(Epo viewedEpo, object parent) : base(viewedEpo, parent) 
		{
		}

		public EpoZutatView() : base() 
		{
		}
		
		
		protected override void InitSpecialControls() 
		{
			//Die Basis legen
			base.InitSpecialControls();
			
			//und nun etwas verändern
			SetLabel("Alkoholgehalt", "Alkohohlg./%");
			SetGeometry("Alkoholgehalt", 1, 2, 11, 2, 20, 1);

			SetVisibility("Farbe", false);
			SetVisibility("Deckung", false);
		}
	}
}

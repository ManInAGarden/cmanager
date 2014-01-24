using System;
using System.Windows.Forms;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung f�r EpoGarnierungView.
	/// </summary>
	public class EpoGarnierungView : EpoCManagerBaseView
	{
		public EpoGarnierungView(Epo viewedEpo, object parent) : base(viewedEpo, parent) 
	{
	}

		public EpoGarnierungView() : base() 
	{
	}
		
		
		protected override void InitSpecialControls() 
		{
			//Die Basis legen
			base.InitSpecialControls();
			
			//und nun etwas ver�ndern
			
			SetVisibility("Farbe", false);
			SetVisibility("Deckung", false);
		}
	}
}

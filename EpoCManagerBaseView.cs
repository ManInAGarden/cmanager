using System;
using System.Windows.Forms;
using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung f�r EpoCManagerBaseView.
	/// </summary>
	public class EpoCManagerBaseView : EpoView
	{
		public EpoCManagerBaseView(Epo viewedEpo, object parent) : base(viewedEpo, parent) 
		{
		}

		public EpoCManagerBaseView() : base() 
		{
		}
		
		
		protected override void InitSpecialControls() 
		{
			//Die Basis legen
			base.InitSpecialControls();
			
			//und nun etwas ver�ndern
			SetLabel("Name", "Bezeichnung");
			SetGeometry("Name", 1, 1, 11, 1, 20, 1);
			
		}
	}
}

using System;
using System.Windows.Forms;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoGlasView.
	/// </summary>
	public class EpoGlasView : EpoCManagerBaseView
	{
		public EpoGlasView(Epo viewedEpo, object parent) : base(viewedEpo, parent) 
		{
		}

		public EpoGlasView() : base() 
		{
		}
		
		
		protected override void InitSpecialControls() 
		{
			//Die Basis legen
			base.InitSpecialControls();
			
			//und nun etwas verändern
			SetLabel("FormOid", "Glasform");
			SetGeometry("FormOid", 1, 2, 11, 2, 20, 1);
	
			SetLabel("Inhalt", "Inhalt /ml");
			SetGeometry("Inhalt", 1, 3, 11, 3, 20, 1);
			
		}
	}
}

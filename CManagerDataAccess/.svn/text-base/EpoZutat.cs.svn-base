using System;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für Zutat.
	/// </summary>
	public class EpoZutat : EpoCManagerBase
	{
		private int alkoholgehalt;	//Alkohohlgehalt in %
		private int farbe;			//rgb Wert der Farbe
		private int deckung;		//Deckungsgrad in %
		


		public int Alkoholgehalt 
		{
			set { alkoholgehalt = value; }
			get { return alkoholgehalt; }
		}

		public int Farbe
		{
			set { farbe = value; }
			get { return farbe; }
		}

		public int Deckung
		{
			set { deckung = value; }
			get { return deckung; }
		}


		public EpoZutat() : base()
		{
			Name = "* Neue Zutat";
		
		}

		public EpoZutat(string connstr) : base(connstr) 
		{
		}

		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

		}

		public override EpoCManagerBase GetTreeViewParentObject() 
		{
			return EpoRubrik.GetZutatenRubrik() as EpoCManagerBase;
		}
	}
}

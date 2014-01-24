using System;
using System.Collections;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoGarnierung.
	/// </summary>
	public class EpoGarnierung : EpoCManagerBase
	{
		private static string[] seeds = 
		{ 
			"Olive",
			"Zitronenscheibe",
			"Orangenscheibe",
			"Salzrand",
			"Cocktailkirsche",
			"Silberzwiebel",
			"Orangenzeste",
			"Zitronenzeste",
			"Strohhalm",
			"Ananasscheibe",
			"Minzezweig",
			"Minzeblatt"
		};
		private int farbe;			//rgb Wert der Farbe
		private int deckung;		//Deckungsgrad in %
		

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


		public EpoGarnierung() : base()
		{
			Name = "* Neue Garnierung";
		
		}

		public EpoGarnierung(string connstr) : base(connstr) 
		{
		}

		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

		}

		public override EpoCManagerBase GetTreeViewParentObject() 
		{
			return EpoRubrik.GetGarnierungenRubrik() as EpoCManagerBase;
		}


		public void CreateSeeds() 
		{
			ArrayList			answ;
			int					i;
			EpoGarnierung		garn;
			Oid					myOid;

			answ = this.Select();
			for(i=0; i<seeds.Length; i++) 
			{
				myOid = new Oid("EpoGarnierung_0_0_" + i.ToString());
				if (!ContainsByOid(answ, myOid)) 
				{
					garn = new EpoGarnierung();
					garn.oid = myOid; //Oh Oh - hier OK weil ich weiss was ich tue
					garn.Name = seeds[i];
					garn.Flush();
				}
			}
		}
	}
}

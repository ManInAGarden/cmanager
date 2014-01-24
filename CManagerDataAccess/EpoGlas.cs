using System;
using System.Collections;
using HSp.CsEpo;
using HSp.CsNman;


namespace CManager
{
	/// <summary>
	/// Klasse für vorhandene Gläser
	/// </summary>
	public class EpoGlas : EpoCManagerBase
	{
		private int			inhalt;  // Fassungsvermögen
		private Oid			formOid; // Verweis auf die Glasform
		private string[]	formen = {"Cocktailschale klein", 
								"Cocktailschale groß",
								"Tumbler klein",
							    "Tumbler mittel",
								"Tumbler groß",
								"Sektflöte",
								"Weinbrandschwenker",
								"Schaumweinschale",
								"Irish Coffee Glas",
								"Pousse-Cafe-Glas",
								"Goblet",
								"Goblet groß"};

		private int[] normInhalte = { 65,
									100,
									80,
									150,
									250,
									100,
									120,
									110,
									100,
									100,
									300,
									400
									};
		public int Inhalt 
		{
			set 
			{
				inhalt = value;
			}
			get 
			{
				return inhalt;
			}
		}

		public Oid FormOid
		{
			set 
			{
				formOid = value;
			}
			get 
			{
				return formOid;
			}
		}

		public EpoGlas() : base ()
		{
			inhalt = 100;
			Name = "* Neues Glas";
		}

		public EpoGlas(string connstr) : base(connstr) 
		{
		}


		public string[] GetFormen() 
		{
			return formen;
		}


		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

			SetDbLen("FormOid", Oid.DbSize);
			
			AddJoin("FormOid", "EpoGlasForm");
		}

		public override EpoCManagerBase GetTreeViewParentObject() 
		{
			return EpoRubrik.GetGlaeserRubrik() as EpoCManagerBase;
		}


		public void CreateSeeds() 
		{
			ArrayList	answ;
			int			i;
			EpoGlas		eg;
			EpoGlasForm	egf;
			Oid			myOid;
			ArrayList	formenListe;


			answ = this.Select();
			for(i=0; i<formen.Length; i++) {
				myOid = new Oid("EpoGlas_0_0_" + i.ToString());
				if (!ContainsByOid(answ, myOid)) 
				{
					eg = new EpoGlas();
					eg.oid = myOid; //Oh Oh - hier OK weil ich weiss was ich tue
					eg.Name = formen[i];

                    formenListe = VerwoByClassName("EpoGlasForm").Select("[Name]='" + formen[i] + "'");
					if(formenListe!=null) 
					{
						egf = formenListe[0] as EpoGlasForm;
						if(egf != null)
							eg.FormOid = egf.oid;
					}

					eg.Inhalt = normInhalte[i];
					eg.Flush();
				}
			}
		}
	}
}

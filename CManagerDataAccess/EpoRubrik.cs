using System;
using System.Collections;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Rubrik Epo Klasse zur Einteilung der Cocktailrezepte
	/// </summary>
	public class EpoRubrik : EpoCManagerBase
	{

		private bool isRezept;

		private static EpoRubrik	zutatenRubrik;
		private static EpoRubrik	glaeserRubrik;
		private static EpoRubrik	garnierungenRubrik;
		private string[] seeds = {"01 Gläser",
								  "02 Zutaten",
								  "Energy",
								  "Short Drinks",
								  "Juliep",
								  "Long Drinks",
								  "03 Garnierungen",
								  "Highball",
								  "Coladas",
								  "Collins",
								  "Sparkling",
		                          "Cooler",
		                          "On the Rocks",
								  "Sour",
								  "Fizz",
								  "Caipirinhas"};

		public EpoRubrik() : base()
		{
			Name = "Neue Rubrik";
			isRezept = true;
		}

		public EpoRubrik(string connstr) : base(connstr) 
		{
		}

		public static EpoRubrik GetZutatenRubrik() 
		{
			return zutatenRubrik;
		}

		public static EpoRubrik GetGlaeserRubrik() 
		{
			return glaeserRubrik;
		}

		public static EpoRubrik GetGarnierungenRubrik() 
		{
			return garnierungenRubrik;
		}

		public bool IsRezept 
		{
			set 
			{
				isRezept = value;
			}

			get 
			{
				return isRezept;
			}
		}


		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

		}

		public void CreateSeeds() 
		{
			ArrayList	answ;
			int			i;
			EpoRubrik	er;
			Oid			myOid;

			answ = this.Select();
			for(i=0; i<seeds.Length; i++) 
			{
				myOid = new Oid("EpoRubrik_0_0_" + i.ToString());
				if (!ContainsByOid(answ, myOid)) 
				{
					er = new EpoRubrik();
					er.oid = myOid; //Oh Oh - hier OK weil ich weiss was ich tue
					er.Name = seeds[i];

					if (er.Name.IndexOf('0') == 0) 
						er.isRezept = false;
					else
						er.isRezept = true;
					
					er.Flush();
				}

				if(i==0) 
				{
					glaeserRubrik = ResolveOid(myOid) as EpoRubrik;
				}
				else if (i==1) 
				{
					zutatenRubrik = ResolveOid(myOid) as EpoRubrik;
				}
				else if (i==6) 
				{
					garnierungenRubrik = ResolveOid(myOid) as EpoRubrik;
				}

			}
		}
	}
}

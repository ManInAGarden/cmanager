using System;
using System.Collections;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoGlasForm.
	/// </summary>
	public class EpoGlasForm : EpoCManagerBase
	{
		private string[] formen = {"Cocktailschale klein", 
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

		public EpoGlasForm() : base()
		{
			Name = "* Neue Glasform";
		}

		public EpoGlasForm(string connstr) : base(connstr) 
		{
		}

		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

		}

		public void CreateSeeds() 
		{
			ArrayList		answ;
			int				i;
			EpoGlasForm		egf;
			Oid				myOid;

			answ = this.Select();
			for(i=0; i<formen.Length; i++) 
			{
				myOid = new Oid("EpoGlasForm_0_0_" + i.ToString());
				if (!ContainsByOid(answ, myOid)) 
				{
					egf = new EpoGlasForm();
					egf.oid = myOid; //Oh Oh - hier OK weil ich weiss was ich tue
					egf.Name = formen[i];
					egf.Flush();
				}
			}
		}
	}
}

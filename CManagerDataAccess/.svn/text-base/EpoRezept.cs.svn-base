using System;
using System.Collections;
using HSp.CsEpo;


namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoRezept.
	/// </summary>
	public class EpoRezept : EpoCManagerBase
	{
		private Oid		rubrikOid,
						glasOid;
		private EpoMemo	zubereitung;

		public Oid RubrikOid 
		{
			set { rubrikOid = value; }
			get { return rubrikOid; }
		}

		public Oid GlasOid 
		{
			set { glasOid = value; }
			get { return glasOid; }
		}

		public EpoMemo Zubereitung 
		{
			set { zubereitung = value; }
			get { return zubereitung; }
		}

		public EpoRezept() : base()
		{
			Name = "* Neues Rezept";
		
		}

		public EpoRezept(string connstr) : base(connstr) 
		{
		}

		/// <summary>
		/// Liefert den Alkoholhgehalt des Rezeptes in Volumenprozenten. dazu werden die 
		/// Alkohohlgehalte aller Zutaten anteilig berücksichtigt.
		/// </summary>
		/// <returns>Den Alkohohlgehalt</returns>
		public double GetAlkoholgehalt() 
		{
			ArrayList	rezeptZutaten;
			EpoZutat	zutat;
			double		prozSum;
			double		proz;
			int			eisAnteil = 0, nutzAnteil;

			prozSum = 0;

            rezeptZutaten = VerwoByClassName("EpoRezeptZutat").Select("[RezeptOid]='" + oid.OidStr + "'");
			foreach (EpoRezeptZutat rezzu in rezeptZutaten) 
			{
				if (rezzu.ZutatOid!=null) 
					zutat = rezzu.ResolveOid(rezzu.ZutatOid) as EpoZutat;
				else
					zutat = null;

				if (zutat!=null) 
				{
					//Den Eisanteil merken um ihn später wieder herausrechnen zu können
					if(zutat.Name.Equals("Eis") || zutat.Name.Equals("Eiswürfel") || zutat.Name.Equals("Eis (zerstoßen)"))
						eisAnteil = rezzu.Anteil;
					
					proz = ((double)rezzu.Anteil/100.0) * ((double)zutat.Alkoholgehalt / 100.0); 
					prozSum = prozSum + proz;
				}
			}

			if (eisAnteil != 0) 
			{
				nutzAnteil = 100 - eisAnteil;
				if(nutzAnteil != 0) 
					prozSum = prozSum / ((double)nutzAnteil/100.0);
			}

			return prozSum * 100.0;
		}


		public double GetBiereinheiten() {
			return GetBiereinheiten(null);
		}

		public double GetBiereinheiten(EpoGlas inGlas) 
		{
			double		alk, be,
						eisAnteil = 0,
						volumen, alkVolumen,
						bierAlkVolumen = 300.0 * 0.048;
			EpoGlas		glas = null;
			ArrayList	rezeptZutaten;
			EpoZutat	zutat;

			alk = GetAlkoholgehalt();

			if (inGlas == null) 
			{
				if(GlasOid != null)
					glas = ResolveOid(GlasOid) as EpoGlas;
			} else {
				glas = inGlas;
			}

			if (glas == null) return 0.0;

			volumen = (double)glas.Inhalt;

            rezeptZutaten = VerwoByClassName("EpoRezeptZutat").Select("[RezeptOid]='" + oid.OidStr + "'");
			foreach (EpoRezeptZutat rezzu in rezeptZutaten) 
			{
				if (rezzu.ZutatOid!=null) 
					zutat = rezzu.ResolveOid(rezzu.ZutatOid) as EpoZutat;
				else
					zutat = null;

				if (zutat!=null) 
				{
					if(zutat.Name.Equals("Eis") || zutat.Name.Equals("Eiswürfel") || zutat.Name.Equals("Zerstoßenes Eis"))
						eisAnteil = rezzu.Anteil;
				}
			}

			volumen =  volumen * (100.0 - (double)eisAnteil)/100.0;
			alkVolumen = volumen * alk/100.0;
			be = alkVolumen / bierAlkVolumen;

			return be;
		}


		public override EpoCManagerBase GetTreeViewParentObject() 
		{
			EpoCManagerBase par = null;

			if (RubrikOid != null) 
			{
				par = ResolveOid(RubrikOid) as EpoCManagerBase;
			}

			return par ;
		}

		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

			AddJoin("RubrikOid", "EpoRubrik");
			AddJoin("GlasOid", "EpoGlas");

			AddLink("EpoRezeptZutat",
					"RezeptOid",
					EnumDelRule.cascade,
					EnumCopyRule.copy);

			AddLink("EpoRezeptGarnierung",
					"RezeptOid",
					EnumDelRule.cascade,
					EnumCopyRule.copy);

			SetDbLen("RubrikOid", Oid.DbSize);
			SetDbLen("GlasOid", Oid.DbSize);
		}
	}
}

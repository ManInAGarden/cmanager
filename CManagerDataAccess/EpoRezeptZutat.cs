using System;
using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoRezeptZutat.
	/// </summary>
	public class EpoRezeptZutat : EpoCManagerBase
	{
		private Oid		rezeptOid,	//FK zum zug. Rezepz 
						zutatOid;	//FK zur zug. Zutat
		private int		anteil;		// Volumenanteil in %


		public Oid RezeptOid 
		{
			set {rezeptOid = value; }
			get { return rezeptOid; }
		}

		public Oid ZutatOid 
		{
			set {zutatOid = value; }
			get { return zutatOid; }
		}

		public int Anteil 
		{
			set { anteil = value; }
			get { return anteil; }
		}


		public EpoRezeptZutat() : base()
		{
			Name = "Neue Rezeptzutat";
		}

		public EpoRezeptZutat(string connstr) : base(connstr) 
		{
		}

		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

			SetDbLen("RezeptOid", Oid.DbSize);
			SetDbLen("ZutatOid", Oid.DbSize);

			AddJoin("RezeptOid", "EpoRezept");
			AddJoin("ZutatOid", "EpoZutat");
		}

		public override string ToString()
		{
			string		answ;
			EpoZutat	zut;
			Object		obj;


			answ = "->???";

			if (ZutatOid == null) return answ;
			
			obj = ResolveOid(ZutatOid);
			
			if (obj==null) return answ;

			zut = obj as EpoZutat;
			if (zut==null) return answ;

			answ = anteil.ToString() + "% " + zut.ToString();

			return answ;
		}

		public override string PreferredOrdering()
		{
			return "[Anteil] DESC";
		}

	}
}

using System;

using HSp.CsEpo;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für EpoRezeptGarnierung.
	/// </summary>
	public class EpoRezeptGarnierung : EpoCManagerBase
	{
		private Oid		rezeptOid,		//FK zum zug. Rezepz 
						garnierungOid;	//FK zur zug. Zutat
		private int		menge;			// Volumenanteil in %


		public Oid RezeptOid 
		{
			set {rezeptOid = value; }
			get { return rezeptOid; }
		}

		public Oid GarnierungOid 
		{
			set {garnierungOid = value; }
			get { return garnierungOid; }
		}

		public int Menge
		{
			set { menge = value; }
			get { return menge; }
		}


		public EpoRezeptGarnierung() : base()
		{
			Name = "Neue Rezeptgarnierung";
			Menge = 1;
		}

		public EpoRezeptGarnierung(string connstr) : base(connstr) 
		{
		}

		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

			SetDbLen("RezeptOid", Oid.DbSize);
			SetDbLen("GarnierungOid", Oid.DbSize);

			AddJoin("RezeptOid", "EpoRezept");
			AddJoin("GarnierungOid", "EpoGarnierung");
		}

		public override string ToString()
		{
			string			answ;
			EpoGarnierung	garn;
			Object			obj;


			answ = "->???";

			if (GarnierungOid == null) return answ;
			
			obj = ResolveOid(GarnierungOid);
			
			if (obj==null) return answ;

			garn = obj as EpoGarnierung;
			if (garn==null) return answ;

			answ = menge.ToString() + " " + garn.ToString();

			return answ;
		}

		public override string PreferredOrdering()
		{
			return "[Menge] DESC";
		}

	}
}

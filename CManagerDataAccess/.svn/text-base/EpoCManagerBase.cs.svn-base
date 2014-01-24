using System;
using System.Collections;
using HSp.CsEpo;
using HSp.CsNman;



namespace CManager
{
	/// <summary>
	/// Basisklasse für alle weiteren Epo-Klassen des
	/// Cocktail-Managers
	/// </summary>
	public class EpoCManagerBase : EpoCached
	{
		private string name;

		public string Name 
		{
			set
			{
				name = value;
			}
			get 
			{
				return name;
			}

		}


 
		public EpoCManagerBase() : base()
		{
			name = "Neue Basis";
		}

		public EpoCManagerBase(string connstr) : base(connstr) 
		{
		}

		public override string ToString() 
		{
			return name;
		}


		protected override void InitSpecialDbLen() 
		{
			base.InitSpecialDbLen();

			SetDbLen("Name", 80);
		}


		public override void Flush()
		{
			base.Flush ();
				
			//Sende Klassen und Objektspezifisch die FLUSH-nachricht
			Nman.Instance.Send(new NMessage(this,
				"DATAFLUSH:" + this.GetType().Name,
				null));
			Nman.Instance.Send(new NMessage(this, 
				"DATAFLUSH:" + this.oid.ToString(),
				null));
		}


		public  virtual EpoCManagerBase GetTreeViewParentObject() 
		{
			return null;
		}

		public void OpenForEdit() 
		{
			EpoView			dial = null;
			EpoRezept		erez;
			EpoZutat		ezut;
			EpoGlas			eglas;
			EpoGarnierung	egarn;

			erez = this as EpoRezept;
			ezut = this as EpoZutat;
			eglas = this as EpoGlas;
			egarn = this as EpoGarnierung;

//			if (erez != null) 
//			{
//				dial = new EpoRezeptView(this, FormCManagerMain.MainFrm);
//			} 
//			else if (ezut!=null) 
//			{
//				dial = new EpoZutatView(this, FormCManagerMain.MainFrm);
//			} 
//			else if (eglas != null) 
//			{
//				dial = new EpoGlasView(this, FormCManagerMain.MainFrm);
//			} 
//			else if (egarn != null) 
//			{
//				dial = new EpoGarnierungView(this, FormCManagerMain.MainFrm);
//			}

			if(dial != null)
				dial.Show();
		}

		public override bool Delete() 
		{
			bool answ;
			string title;
				
			answ = base.Delete();
				
			title = "DATADELETE:" + this.oid.ToString();
			Nman.Instance.Send(new NMessage(this, title, null));
				
			return answ;
		}


		protected bool ContainsByOid(ArrayList ar, Oid oid) 
		{
			int i = 0;
			bool found = false;

			while (!found && (i < ar.Count))
			{
				found = (ar[i] as EpoCManagerBase).oid.OidStr.Equals(oid.OidStr);
				i++;
			}

			return found;
		}

		public override string PreferredOrdering()
		{
			return "[Name]";
		}


	}
}

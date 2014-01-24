using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für FormRezeptsuche.
	/// </summary>
	public class FormRezeptsuche : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button startSearchBU;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nameTB;
		private System.Windows.Forms.CheckBox alkoholfreiCHB;
		private System.Windows.Forms.Button addZutatBU;
		private System.Windows.Forms.ListBox ergebnisLB;
		private System.Windows.Forms.Button closeBU;
		private System.Windows.Forms.ToolTip rezeptSucheTT;
		private System.Windows.Forms.ComboBox zutatenCB;
		private System.Windows.Forms.ListBox suchZutatenLB;
		private System.Windows.Forms.Button delZutatBU;
		private System.ComponentModel.IContainer components;

		public FormRezeptsuche()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.startSearchBU = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nameTB = new System.Windows.Forms.TextBox();
			this.alkoholfreiCHB = new System.Windows.Forms.CheckBox();
			this.suchZutatenLB = new System.Windows.Forms.ListBox();
			this.addZutatBU = new System.Windows.Forms.Button();
			this.ergebnisLB = new System.Windows.Forms.ListBox();
			this.closeBU = new System.Windows.Forms.Button();
			this.rezeptSucheTT = new System.Windows.Forms.ToolTip(this.components);
			this.zutatenCB = new System.Windows.Forms.ComboBox();
			this.delZutatBU = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// startSearchBU
			// 
			this.startSearchBU.Location = new System.Drawing.Point(8, 168);
			this.startSearchBU.Name = "startSearchBU";
			this.startSearchBU.TabIndex = 0;
			this.startSearchBU.Text = "Suche Starten";
			this.rezeptSucheTT.SetToolTip(this.startSearchBU, "Startet die Suche");
			this.startSearchBU.Click += new System.EventHandler(this.startSearchBU_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Alkoholfrei";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Zutaten";
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(88, 16);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(192, 20);
			this.nameTB.TabIndex = 2;
			this.nameTB.Text = "";
			this.rezeptSucheTT.SetToolTip(this.nameTB, "Name des Cocktails. Benutzen sie % als Wildcard.");
			// 
			// alkoholfreiCHB
			// 
			this.alkoholfreiCHB.Location = new System.Drawing.Point(88, 48);
			this.alkoholfreiCHB.Name = "alkoholfreiCHB";
			this.alkoholfreiCHB.Size = new System.Drawing.Size(24, 24);
			this.alkoholfreiCHB.TabIndex = 3;
			this.rezeptSucheTT.SetToolTip(this.alkoholfreiCHB, "Markieren um nur nach Cocktails mit weniger als 1% Alkoholgehalt zu suchen.");
			// 
			// suchZutatenLB
			// 
			this.suchZutatenLB.Location = new System.Drawing.Point(88, 104);
			this.suchZutatenLB.Name = "suchZutatenLB";
			this.suchZutatenLB.Size = new System.Drawing.Size(192, 43);
			this.suchZutatenLB.TabIndex = 4;
			this.rezeptSucheTT.SetToolTip(this.suchZutatenLB, "Zutaten hinzufügen um nach Cocktails mit den betreffenden Zutaten zu suchen.");
			// 
			// addZutatBU
			// 
			this.addZutatBU.Location = new System.Drawing.Point(8, 104);
			this.addZutatBU.Name = "addZutatBU";
			this.addZutatBU.Size = new System.Drawing.Size(72, 23);
			this.addZutatBU.TabIndex = 5;
			this.addZutatBU.Text = "Hinzufügen";
			this.rezeptSucheTT.SetToolTip(this.addZutatBU, "Fügt Zutaten zur Zutatensuchliste hinzu");
			this.addZutatBU.Click += new System.EventHandler(this.addZutatBU_Click);
			// 
			// ergebnisLB
			// 
			this.ergebnisLB.Location = new System.Drawing.Point(8, 200);
			this.ergebnisLB.Name = "ergebnisLB";
			this.ergebnisLB.Size = new System.Drawing.Size(272, 95);
			this.ergebnisLB.TabIndex = 6;
			this.rezeptSucheTT.SetToolTip(this.ergebnisLB, "Ergebnisliste.Selektieren Sie einen Eintrag um den Cocktail anzuzeigen.");
			this.ergebnisLB.SelectedIndexChanged += new System.EventHandler(this.ergebnisLB_SelectedIndexChanged);
			// 
			// closeBU
			// 
			this.closeBU.Location = new System.Drawing.Point(8, 304);
			this.closeBU.Name = "closeBU";
			this.closeBU.TabIndex = 0;
			this.closeBU.Text = "Schließen";
			this.rezeptSucheTT.SetToolTip(this.closeBU, "Schließt das Suchfenster");
			this.closeBU.Click += new System.EventHandler(this.closeBU_Click);
			// 
			// zutatenCB
			// 
			this.zutatenCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.zutatenCB.Location = new System.Drawing.Point(88, 80);
			this.zutatenCB.Name = "zutatenCB";
			this.zutatenCB.Size = new System.Drawing.Size(192, 21);
			this.zutatenCB.TabIndex = 7;
			// 
			// delZutatBU
			// 
			this.delZutatBU.Location = new System.Drawing.Point(8, 128);
			this.delZutatBU.Name = "delZutatBU";
			this.delZutatBU.Size = new System.Drawing.Size(72, 23);
			this.delZutatBU.TabIndex = 5;
			this.delZutatBU.Text = "Entfernen";
			this.rezeptSucheTT.SetToolTip(this.delZutatBU, "Fügt Zutaten zur Zutatensuchliste hinzu");
			this.delZutatBU.Click += new System.EventHandler(this.delZutatBU_Click);
			// 
			// FormRezeptsuche
			// 
			this.AcceptButton = this.startSearchBU;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 334);
			this.Controls.Add(this.zutatenCB);
			this.Controls.Add(this.ergebnisLB);
			this.Controls.Add(this.addZutatBU);
			this.Controls.Add(this.suchZutatenLB);
			this.Controls.Add(this.alkoholfreiCHB);
			this.Controls.Add(this.nameTB);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.startSearchBU);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.closeBU);
			this.Controls.Add(this.delZutatBU);
			this.Name = "FormRezeptsuche";
			this.Text = "Rezeptsuche";
			this.Load += new System.EventHandler(this.FormRezeptsuche_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void startSearchBU_Click(object sender, System.EventArgs e)
		{
			ArrayList	erg, ergPart, ergPart2,
						rezeptZutaten;
			EpoZutat	zutVonRez;
			int			foundOnes;
			
			erg = new ArrayList();
			
			ergPart = FormCManagerMain.epoRezeptV.Select("[Name] LIKE '" + nameTB.Text + "%'"); 
			ergPart2 = new ArrayList(ergPart);
			if (alkoholfreiCHB.Checked) 
			{
				foreach(EpoRezept erez in ergPart) 
				{
					if (erez.GetAlkoholgehalt() > 1.0) 
					{
						ergPart2.Remove(erez);
					}
				}
			} 
			
			ergPart = ergPart2;

			if (suchZutatenLB.Items.Count == 0) 
			{
				ergPart2 = new ArrayList(ergPart);
			} else {
			
				ergPart2 = new ArrayList();
				
				foreach(EpoRezept rezept in ergPart) 
				{
					rezeptZutaten = FormCManagerMain.epoRezeptZutatV.Select("[RezeptOid]='" + rezept.oid.OidStr + "'");
					if(rezeptZutaten!=null) 
					{
						foundOnes = 0;
						foreach(EpoZutat zutat in suchZutatenLB.Items) 
						{
							foreach(EpoRezeptZutat rezeptzutat in rezeptZutaten) 
							{
								if(rezeptzutat.ZutatOid!=null) 
								{
									zutVonRez = rezeptzutat.ResolveOid(rezeptzutat.ZutatOid) as EpoZutat;
									if(zutVonRez!=null) 
									{		
										if (zutVonRez.Name.Equals(zutat.Name)) 
										{
											foundOnes++;
										} 
									}
									
								}
							}
						}

						if (foundOnes == suchZutatenLB.Items.Count) 
						{
							ergPart2.Add(rezept);
						}
					}
				}
			}
			
			erg.AddRange(ergPart2);
			
			

			ergebnisLB.BeginUpdate();
			ergebnisLB.Items.Clear();
			foreach(EpoRezept rez in erg) 
			{
				ergebnisLB.Items.Add(rez);
			}
			ergebnisLB.EndUpdate();
		}

		private void closeBU_Click(object sender, System.EventArgs e)
		{
			Hide();
		}

		private void ergebnisLB_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			EpoRezept	selrez;

			selrez = ergebnisLB.SelectedItem as EpoRezept;

			if (selrez==null) return;

			FormCManagerMain.MainFrm.SelectRezept(selrez);

		}

		private void addZutatBU_Click(object sender, System.EventArgs e)
		{
			EpoZutat	selzut;

			selzut = zutatenCB.SelectedItem as EpoZutat;
			if(selzut==null) return;

			suchZutatenLB.Items.Add(selzut);
		}

		private void FormRezeptsuche_Load(object sender, System.EventArgs e)
		{
			ArrayList	zutaten;

			zutaten = FormCManagerMain.epoZutatV.Select();
			if (zutaten==null) return;

			zutatenCB.BeginUpdate();
			zutatenCB.Items.Clear();
	
			foreach(EpoZutat zutat in zutaten) 
			{
				zutatenCB.Items.Add(zutat);
			}
			zutatenCB.EndUpdate();
		}

		private void delZutatBU_Click(object sender, System.EventArgs e)
		{
			int	selind;

			selind = suchZutatenLB.SelectedIndex;
			
			if (selind<0) return;

			suchZutatenLB.Items.RemoveAt(selind);
		}
	}
}

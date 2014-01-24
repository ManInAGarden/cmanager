using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Data.Odbc;
using System.Configuration;

using HSp.CsEpo;
using HSp.CsNman;


namespace CManager
{
	/// <summary>
	/// Zusammenfassung für Form1.
	/// </summary>
	public class FormCManagerMain : System.Windows.Forms.Form
	{

		private static Hashtable			arglst;
		private static string				connName;
		private static FormCManagerMain		mainFrm;
		private static Form					cockSearchFRM = null;

		public static EpoGlas				epoGlasV;
		public static EpoGlasForm			epoGlasFormV;
		public static EpoRubrik				epoRubrikV;
		public static EpoZutat				epoZutatV;
		public static EpoRezept				epoRezeptV;
		public static EpoRezeptZutat		epoRezeptZutatV;
		public static EpoGarnierung			epoGarnierungV;
		public static EpoRezeptGarnierung	epoRezeptGarnierungV;

		private System.Windows.Forms.TreeView cocktailsTV;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem beendenMenuItem;
		private System.Windows.Forms.MenuItem inhaltHilfeMenuItem;
		private System.Windows.Forms.MenuItem aboutMenuItem;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.ContextMenu cocktailsTVContextMenu;
		private System.Windows.Forms.MenuItem cocktailsNeuMenuItem;
		private System.Windows.Forms.MenuItem cocktailsLoeschenMenuItem;
		private System.Windows.Forms.MenuItem cocktailsBearbeitenMenuItem;
		private System.Windows.Forms.Splitter mainSplitter;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.TextBox nameTB;
		private System.Windows.Forms.ComboBox glasCB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inhaltTB;
		private System.Windows.Forms.Label zubereitungL;
		private System.Windows.Forms.TextBox zubereitungTB;
		private System.Windows.Forms.CheckedListBox zutatenAnteileLB;
		private System.Windows.Forms.ListBox zutatenMengenLB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown anzahlNUD;
		private System.Windows.Forms.CheckedListBox garnierungenLB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox volProzTB;
		private System.Windows.Forms.ToolTip mainFormTP;
		private System.Windows.Forms.MenuItem importMenuItem;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem cocktailSucheMenuItem;
		private System.Windows.Forms.TextBox beTB;
		private System.Windows.Forms.MenuItem cockatailsExportierenMenuItem;
		private System.ComponentModel.IContainer components;

		public FormCManagerMain()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		public static FormCManagerMain MainFrm 
		{
			get { return mainFrm; }
		}


		/// <summary>
		/// Gibt den Versionsstring zurück. Dieser wird aus der ProducVersion
		/// des Assemblies entnommen
		/// </summary>
		public static string Version 
		{
			get { return Application.ProductVersion; }
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormCManagerMain));
			this.cocktailsTV = new System.Windows.Forms.TreeView();
			this.cocktailsTVContextMenu = new System.Windows.Forms.ContextMenu();
			this.cocktailsNeuMenuItem = new System.Windows.Forms.MenuItem();
			this.cocktailsBearbeitenMenuItem = new System.Windows.Forms.MenuItem();
			this.cocktailsLoeschenMenuItem = new System.Windows.Forms.MenuItem();
			this.cockatailsExportierenMenuItem = new System.Windows.Forms.MenuItem();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.importMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.beendenMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.cocktailSucheMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.inhaltHilfeMenuItem = new System.Windows.Forms.MenuItem();
			this.aboutMenuItem = new System.Windows.Forms.MenuItem();
			this.panelRight = new System.Windows.Forms.Panel();
			this.volProzTB = new System.Windows.Forms.TextBox();
			this.garnierungenLB = new System.Windows.Forms.CheckedListBox();
			this.anzahlNUD = new System.Windows.Forms.NumericUpDown();
			this.zutatenMengenLB = new System.Windows.Forms.ListBox();
			this.zutatenAnteileLB = new System.Windows.Forms.CheckedListBox();
			this.zubereitungTB = new System.Windows.Forms.TextBox();
			this.inhaltTB = new System.Windows.Forms.TextBox();
			this.glasCB = new System.Windows.Forms.ComboBox();
			this.nameTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.zubereitungL = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.beTB = new System.Windows.Forms.TextBox();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.mainSplitter = new System.Windows.Forms.Splitter();
			this.mainFormTP = new System.Windows.Forms.ToolTip(this.components);
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.anzahlNUD)).BeginInit();
			this.panelLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// cocktailsTV
			// 
			this.cocktailsTV.ContextMenu = this.cocktailsTVContextMenu;
			this.cocktailsTV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cocktailsTV.ImageIndex = -1;
			this.cocktailsTV.Location = new System.Drawing.Point(0, 0);
			this.cocktailsTV.Name = "cocktailsTV";
			this.cocktailsTV.SelectedImageIndex = -1;
			this.cocktailsTV.Size = new System.Drawing.Size(312, 446);
			this.cocktailsTV.Sorted = true;
			this.cocktailsTV.TabIndex = 0;
			this.mainFormTP.SetToolTip(this.cocktailsTV, "Übersicht über Gläser, Zutaten, Dekorationen und Cocktailrezepte.");
			this.cocktailsTV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cocktailsTV_MouseDown);
			this.cocktailsTV.DoubleClick += new System.EventHandler(this.cocktailsTV_DblClick);
			this.cocktailsTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cocktailsTV_AfterSelect);
			// 
			// cocktailsTVContextMenu
			// 
			this.cocktailsTVContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								   this.cocktailsNeuMenuItem,
																								   this.cocktailsBearbeitenMenuItem,
																								   this.cocktailsLoeschenMenuItem,
																								   this.cockatailsExportierenMenuItem});
			this.cocktailsTVContextMenu.Popup += new System.EventHandler(this.cocktailsTVContextMenu_Popup);
			// 
			// cocktailsNeuMenuItem
			// 
			this.cocktailsNeuMenuItem.Index = 0;
			this.cocktailsNeuMenuItem.Text = "Neu";
			this.cocktailsNeuMenuItem.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// cocktailsBearbeitenMenuItem
			// 
			this.cocktailsBearbeitenMenuItem.DefaultItem = true;
			this.cocktailsBearbeitenMenuItem.Index = 1;
			this.cocktailsBearbeitenMenuItem.Text = "Bearbeiten";
			this.cocktailsBearbeitenMenuItem.Click += new System.EventHandler(this.cocktailsBearbeitenMenuItem_Click);
			// 
			// cocktailsLoeschenMenuItem
			// 
			this.cocktailsLoeschenMenuItem.Index = 2;
			this.cocktailsLoeschenMenuItem.Text = "Löschen";
			this.cocktailsLoeschenMenuItem.Click += new System.EventHandler(this.cocktailsLoeschenMenuItem_Click);
			// 
			// cockatailsExportierenMenuItem
			// 
			this.cockatailsExportierenMenuItem.Index = 3;
			this.cockatailsExportierenMenuItem.Text = "Exportieren";
			this.cockatailsExportierenMenuItem.Click += new System.EventHandler(this.cockatailsExportierenMenuItem_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3,
																					  this.menuItem7});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.importMenuItem,
																					  this.menuItem5,
																					  this.beendenMenuItem});
			this.menuItem1.Text = "Datei";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Vollständiger Export";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// importMenuItem
			// 
			this.importMenuItem.Index = 1;
			this.importMenuItem.Text = "Import";
			this.importMenuItem.Click += new System.EventHandler(this.importMenuItem_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "-";
			// 
			// beendenMenuItem
			// 
			this.beendenMenuItem.Index = 3;
			this.beendenMenuItem.Text = "Beenden";
			this.beendenMenuItem.Click += new System.EventHandler(this.beendenMenuItem_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.cocktailSucheMenuItem});
			this.menuItem3.Text = "Cocktail";
			// 
			// cocktailSucheMenuItem
			// 
			this.cocktailSucheMenuItem.Index = 0;
			this.cocktailSucheMenuItem.Text = "Suchen";
			this.cocktailSucheMenuItem.Click += new System.EventHandler(this.cocktailSucheMenuItem_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 2;
			this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.inhaltHilfeMenuItem,
																					  this.aboutMenuItem});
			this.menuItem7.Text = "Hilfe";
			// 
			// inhaltHilfeMenuItem
			// 
			this.inhaltHilfeMenuItem.Index = 0;
			this.inhaltHilfeMenuItem.Text = "Inhalt";
			this.inhaltHilfeMenuItem.Click += new System.EventHandler(this.inhaltHilfeMenuItem_Click);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Index = 1;
			this.aboutMenuItem.Text = "Über";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.volProzTB);
			this.panelRight.Controls.Add(this.garnierungenLB);
			this.panelRight.Controls.Add(this.anzahlNUD);
			this.panelRight.Controls.Add(this.zutatenMengenLB);
			this.panelRight.Controls.Add(this.zutatenAnteileLB);
			this.panelRight.Controls.Add(this.zubereitungTB);
			this.panelRight.Controls.Add(this.inhaltTB);
			this.panelRight.Controls.Add(this.glasCB);
			this.panelRight.Controls.Add(this.nameTB);
			this.panelRight.Controls.Add(this.label1);
			this.panelRight.Controls.Add(this.zubereitungL);
			this.panelRight.Controls.Add(this.label2);
			this.panelRight.Controls.Add(this.label3);
			this.panelRight.Controls.Add(this.label4);
			this.panelRight.Controls.Add(this.beTB);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new System.Drawing.Point(315, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(333, 446);
			this.panelRight.TabIndex = 1;
			// 
			// volProzTB
			// 
			this.volProzTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.volProzTB.AutoSize = false;
			this.volProzTB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.volProzTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.volProzTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.volProzTB.Location = new System.Drawing.Point(280, 8);
			this.volProzTB.Name = "volProzTB";
			this.volProzTB.Size = new System.Drawing.Size(48, 24);
			this.volProzTB.TabIndex = 9;
			this.volProzTB.Text = "";
			this.mainFormTP.SetToolTip(this.volProzTB, "Alkoholgehalt des Cocktails in Volumenprozenten");
			// 
			// garnierungenLB
			// 
			this.garnierungenLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.garnierungenLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.garnierungenLB.Location = new System.Drawing.Point(48, 376);
			this.garnierungenLB.Name = "garnierungenLB";
			this.garnierungenLB.Size = new System.Drawing.Size(224, 45);
			this.garnierungenLB.TabIndex = 8;
			this.mainFormTP.SetToolTip(this.garnierungenLB, "Dekorationen");
			// 
			// anzahlNUD
			// 
			this.anzahlNUD.Location = new System.Drawing.Point(48, 232);
			this.anzahlNUD.Name = "anzahlNUD";
			this.anzahlNUD.Size = new System.Drawing.Size(56, 20);
			this.anzahlNUD.TabIndex = 7;
			this.mainFormTP.SetToolTip(this.anzahlNUD, "Anzahl der Cocktails, wählen Sie die Anzahl der Cocktails die sie zubereiten woll" +
				"en.");
			this.anzahlNUD.Value = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			this.anzahlNUD.ValueChanged += new System.EventHandler(this.anzahlNUD_ValueChanged);
			// 
			// zutatenMengenLB
			// 
			this.zutatenMengenLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.zutatenMengenLB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.zutatenMengenLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.zutatenMengenLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.zutatenMengenLB.IntegralHeight = false;
			this.zutatenMengenLB.ItemHeight = 15;
			this.zutatenMengenLB.Location = new System.Drawing.Point(272, 280);
			this.zutatenMengenLB.Name = "zutatenMengenLB";
			this.zutatenMengenLB.Size = new System.Drawing.Size(56, 75);
			this.zutatenMengenLB.TabIndex = 6;
			this.mainFormTP.SetToolTip(this.zutatenMengenLB, "Zutatenmengen");
			// 
			// zutatenAnteileLB
			// 
			this.zutatenAnteileLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.zutatenAnteileLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.zutatenAnteileLB.Location = new System.Drawing.Point(48, 280);
			this.zutatenAnteileLB.Name = "zutatenAnteileLB";
			this.zutatenAnteileLB.Size = new System.Drawing.Size(224, 75);
			this.zutatenAnteileLB.TabIndex = 5;
			this.mainFormTP.SetToolTip(this.zutatenAnteileLB, "Zutatenliste mit prozentualem Anteil.");
			this.zutatenAnteileLB.SelectedIndexChanged += new System.EventHandler(this.zutatenAnteileLB_SelectedIndexChanged);
			// 
			// zubereitungTB
			// 
			this.zubereitungTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.zubereitungTB.BackColor = System.Drawing.SystemColors.Window;
			this.zubereitungTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.zubereitungTB.Location = new System.Drawing.Point(48, 96);
			this.zubereitungTB.Multiline = true;
			this.zubereitungTB.Name = "zubereitungTB";
			this.zubereitungTB.ReadOnly = true;
			this.zubereitungTB.Size = new System.Drawing.Size(224, 128);
			this.zubereitungTB.TabIndex = 4;
			this.zubereitungTB.Text = "";
			this.mainFormTP.SetToolTip(this.zubereitungTB, "Zubreitung");
			// 
			// inhaltTB
			// 
			this.inhaltTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.inhaltTB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.inhaltTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inhaltTB.Location = new System.Drawing.Point(280, 56);
			this.inhaltTB.Name = "inhaltTB";
			this.inhaltTB.Size = new System.Drawing.Size(48, 13);
			this.inhaltTB.TabIndex = 3;
			this.inhaltTB.Text = "";
			this.mainFormTP.SetToolTip(this.inhaltTB, "Inhalt des Glases in ml.");
			// 
			// glasCB
			// 
			this.glasCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.glasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.glasCB.Location = new System.Drawing.Point(48, 56);
			this.glasCB.Name = "glasCB";
			this.glasCB.Size = new System.Drawing.Size(224, 21);
			this.glasCB.TabIndex = 2;
			this.mainFormTP.SetToolTip(this.glasCB, "Standardglas - wählen Sie hier ein anderes Glas falls Sie nicht das Standardglas " +
				"verwenden.");
			this.glasCB.SelectedIndexChanged += new System.EventHandler(this.glasCB_SelectedIndexChanged);
			// 
			// nameTB
			// 
			this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.nameTB.BackColor = System.Drawing.SystemColors.Control;
			this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nameTB.Location = new System.Drawing.Point(8, 8);
			this.nameTB.Multiline = true;
			this.nameTB.Name = "nameTB";
			this.nameTB.ReadOnly = true;
			this.nameTB.Size = new System.Drawing.Size(264, 48);
			this.nameTB.TabIndex = 0;
			this.nameTB.Text = "";
			this.mainFormTP.SetToolTip(this.nameTB, "Name des Cocktailrezeptes");
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Glas";
			// 
			// zubereitungL
			// 
			this.zubereitungL.Location = new System.Drawing.Point(8, 80);
			this.zubereitungL.Name = "zubereitungL";
			this.zubereitungL.Size = new System.Drawing.Size(152, 16);
			this.zubereitungL.TabIndex = 1;
			this.zubereitungL.Text = "Zubereitung";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 232);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Anzahl";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 264);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Zutaten";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(8, 360);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Garnierung";
			// 
			// beTB
			// 
			this.beTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.beTB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.beTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.beTB.Location = new System.Drawing.Point(280, 32);
			this.beTB.Name = "beTB";
			this.beTB.Size = new System.Drawing.Size(48, 13);
			this.beTB.TabIndex = 3;
			this.beTB.Text = "";
			this.mainFormTP.SetToolTip(this.beTB, "Biereinheiten: Entsprechende Menge 0,3er Biere");
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.cocktailsTV);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(312, 446);
			this.panelLeft.TabIndex = 2;
			// 
			// mainSplitter
			// 
			this.mainSplitter.Location = new System.Drawing.Point(312, 0);
			this.mainSplitter.Name = "mainSplitter";
			this.mainSplitter.Size = new System.Drawing.Size(3, 446);
			this.mainSplitter.TabIndex = 3;
			this.mainSplitter.TabStop = false;
			// 
			// FormCManagerMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 446);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.mainSplitter);
			this.Controls.Add(this.panelLeft);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "FormCManagerMain";
			this.Text = "C-Manager";
			this.Load += new System.EventHandler(this.FormCManagerMain_Load);
			this.panelRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.anzahlNUD)).EndInit();
			this.panelLeft.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static int Main(string[] args) 
		{
			string connStr = "DSN=cmanager"; //Defaultwert für ODBC-Verbindungsname
			connName = "cmanager";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			if (ParseArgs(args)) 
			{
				 if (arglst["DSN"]!=null) {
	   	 			connStr = "DSN=" + arglst["DSN"] as string;
					connName = arglst["DSN"] as string;
				 }

				try 
				{
					Trace.WriteLine("Initialsiere Datenbank " + connName);
					Trace.Indent();
					epoGlasFormV = new EpoGlasForm(connStr);
					epoGlasFormV.CreateSeeds();
					epoGlasV = new EpoGlas(connStr);
					epoGlasV.CreateSeeds();
					epoRubrikV = new EpoRubrik(connStr);
					epoRubrikV.CreateSeeds();
					epoZutatV = new EpoZutat(connStr);
		
					epoRezeptZutatV = new EpoRezeptZutat(connStr);
				
					epoGarnierungV = new EpoGarnierung(connStr);
					epoGarnierungV.CreateSeeds();

					epoRezeptGarnierungV = new EpoRezeptGarnierung(connStr);

					epoRezeptV = new EpoRezept(connStr);
				} 
				catch (OdbcException odbcExc) 
				{
					MessageBox.Show("Die Datenbank konnte nicht unter dem ODBC-Namen: >>"
						+ connName
						+ "<< angebunden werden.");
					Trace.WriteLine(odbcExc.Message);
					return 1;
				}
				catch (ConfigurationException)
				{
					MessageBox.Show("Fehler beim Interpretieren der Konfigurationsdatei oder beim Schreiben der Logdatei. Vermutliche Ursache ist dass Sie versucht haben den Cocktailmanager mehr als ein mal zu starten.");
					// genau das geht hier nicht: Trace.WriteLine(confExc.Message);
					return 1;
				}
				catch (Exception exc) // Alle anderen Probleme
				{
					MessageBox.Show(exc.Message);
					Trace.WriteLine(exc.Message);
					return 1;
				}

				EpoView.AddEpoViewRelation(epoRezeptZutatV, new EpoRezeptZutatView());
				EpoView.AddEpoViewRelation(epoRezeptGarnierungV, new EpoRezeptGarnierungView());

				Trace.Unindent();
				Trace.WriteLine("Initialisierung abgeschlossen");

				mainFrm = new FormCManagerMain();
				Application.Run(mainFrm);

				return 0;
			}
			else
				return 1;
		}


		private void AppendToRubrikNode(TreeNode tvn) 
		{
			EpoRubrik	erik;
			TreeNode	subtn;
			ArrayList	rezepte, 
						zutaten,
						garnierungen,
						glaeser;
			string		deltitle;
			NDelegate	refrFlush = new NDelegate(RefreshAfterFlush),
						refrDel = new NDelegate(RefreshAfterDelete);

			erik = tvn.Tag as EpoRubrik;
			if(erik.IsRezept) 
			{
				rezepte = epoRezeptV.Select("[RubrikOid]='" + erik.oid.ToString() + "'");
				if (rezepte!= null) 
				{
					foreach (EpoRezept rezept in rezepte) 
					{
						deltitle = "DATADELETE:" + rezept.oid.ToString();
						Nman.Instance.Register(deltitle, this, refrDel);

						subtn = new TreeNode(rezept.ToString());
						subtn.Tag = rezept;
						tvn.Nodes.Add(subtn);
					}
				}
			} 
			else 
			{	//Zutaten
				if (erik.Equals(EpoRubrik.GetZutatenRubrik()))
				{	
					zutaten = epoZutatV.Select();
					if(zutaten != null) 
					{
						foreach (EpoZutat zutat in zutaten) 
						{
							deltitle = "DATADELETE:" + zutat.oid.ToString();
							Nman.Instance.Register(deltitle, this, refrDel);

							subtn = new TreeNode(zutat.ToString());
							subtn.Tag = zutat;
							tvn.Nodes.Add(subtn);
						}
					}
				}
				else if (erik.Equals(EpoRubrik.GetGarnierungenRubrik()))
				{
					garnierungen = epoGarnierungV.Select();
					if(garnierungen != null) 
					{
						foreach (EpoGarnierung garn in garnierungen) 
						{
							deltitle = "DATADELETE:" + garn.oid.ToString();
							Nman.Instance.Register(deltitle, this, refrDel);

							subtn = new TreeNode(garn.ToString());
							subtn.Tag = garn;
							tvn.Nodes.Add(subtn);
						}
					}
				} 
				else if (erik.Equals(EpoRubrik.GetGlaeserRubrik())) 
				{
					glaeser = epoGlasV.Select();
					if(glaeser != null) 
					{
						foreach (EpoGlas glas in glaeser) 
						{
							deltitle = "DATADELETE:" + glas.oid.ToString();
							Nman.Instance.Register(deltitle, this, refrDel);

							subtn = new TreeNode(glas.ToString());
							subtn.Tag = glas;
							tvn.Nodes.Add(subtn);
						}
					}
				}
			}
		}

		private TreeNode FindTreeNodeWithTag(TreeNode topTn, EpoCManagerBase ema) 
		{
			TreeNode		foundTn;
			EpoCManagerBase	topEma;

			topEma = topTn.Tag as EpoCManagerBase;

			if (topEma.Equals(ema)) return topTn;

			foundTn = null;
			foreach(TreeNode subnode in topTn.Nodes) 
			{
				foundTn = FindTreeNodeWithTag(subnode, ema);
				if (foundTn != null) return foundTn;
			}

			return null;
		}


		//Den Treeview auffrischen nachdem eines der dargestellten Elemente 
		//seine Löschung gemeldet hat.
		public void RefreshAfterDelete(NMessage msg) 
		{
			TreeNode tn;

			foreach(TreeNode searchTn in cocktailsTV.Nodes) 
			{ 
				tn = FindTreeNodeWithTag(searchTn, 
										 msg.Sender as EpoCManagerBase);

				if (tn!=null) 
				{

					cocktailsTV.Nodes.Remove(tn);
					Nman.Instance.UnRegister(msg.Title);
				}
			}
		}
   
		//Den Treeview auffrischen nachdem eines der dargestellten Elemente 
		//auf der Datenbank verändert wurde.
		public void RefreshAfterFlush(NMessage msg) 
		{
			EpoCManagerBase	ema;
   			TreeNode		tn,
							parTn,
							newTn;
			bool			doneit = false;
			EpoCManagerBase parObj;


			ema = msg.Sender as EpoCManagerBase;
   			
			if (ema == null) return;

			cocktailsTV.BeginUpdate();
			foreach(TreeNode searchTn in cocktailsTV.Nodes) 
			{ 
				tn = FindTreeNodeWithTag(searchTn, 
					msg.Sender as EpoCManagerBase);

				if (tn!=null) 
				{
					tn.Text = ema.Name;
					doneit = true;
				}
			}

			if (!doneit) 
			{
				parObj = ema.GetTreeViewParentObject();
				if(parObj!=null) 
				{
					foreach(TreeNode searchTn in cocktailsTV.Nodes) 
					{ 
		
						parTn = FindTreeNodeWithTag(searchTn, 
													parObj);

						if (parTn!=null) 
						{
							newTn = new TreeNode(ema.Name);
							newTn.Tag = ema;
							parTn.Nodes.Add(newTn);
						}
					}
				}
			}
   		
			cocktailsTV.EndUpdate();
		}


		private void FillMainTree() 
		{
			ArrayList		rubriken;
			TreeNode		tvn;
			NDelegate		refrFlush = new NDelegate(RefreshAfterFlush),
							refrDel = new NDelegate(RefreshAfterDelete);
			

			cocktailsTV.BeginUpdate();
			cocktailsTV.Nodes.Clear();

			Nman.Instance.Register("DATAFLUSH:EpoRubrik", this, refrFlush);
			Nman.Instance.Register("DATAFLUSH:EpoRezept", this, refrFlush);
			Nman.Instance.Register("DATAFLUSH:EpoGlas", this, refrFlush);
			Nman.Instance.Register("DATAFLUSH:EpoZutat", this, refrFlush);
			Nman.Instance.Register("DATAFLUSH:EpoGarnierung", this, refrFlush);

			rubriken = epoRubrikV.Select();
			if (rubriken == null) return;

			foreach (EpoRubrik rubrik in rubriken) 
			{
				tvn = new TreeNode(rubrik.ToString());
				tvn.Tag = rubrik;
				AppendToRubrikNode(tvn);
				cocktailsTV.Nodes.Add(tvn);
			}
			cocktailsTV.EndUpdate();
		}


		private static bool ParseArgs(String [] args) 
		{
			int i = 0;
			int colonIdx;
			String flag, val;
			bool answ = true;

			arglst = new Hashtable();
			try 
			{
				while (i < args.Length)
				{
					if (args[i].StartsWith("/")) 
					{
						colonIdx = args[i].IndexOf(':');
						if (colonIdx >= 0) 
						{
							flag = args[i].Substring(1, colonIdx - 1);
							val = args[i].Substring(colonIdx + 1, args[i].Length - colonIdx - 1);
						}
						else 
						{
							flag = args[i].Substring(1, args[i].Length - 1);
							val = null;
						}
						arglst[flag] = val;
					}
					else
					{
						MessageBox.Show("Fehler auf der Kommandozeile: " + args[i]);
					}

					i = i + 1;
				}
			}
			catch 
			{
				MessageBox.Show("Fehler auf der Kommandozeile: " +  args[i]);
				answ = false;
			}
 	         
			return answ;
		}

		private void beendenMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void FormCManagerMain_Load(object sender, System.EventArgs e)
		{
			FillMainTree();
		}

		private void cocktailsTVContextMenu_Popup(object sender, System.EventArgs e)
		{
			TreeNode	tn;

			tn = cocktailsTV.SelectedNode;
			cocktailsNeuMenuItem.Enabled = true;
			cocktailsBearbeitenMenuItem.Enabled = false;
			cocktailsLoeschenMenuItem.Enabled = false;
			cockatailsExportierenMenuItem.Enabled = false;

			if (tn==null) return;
			if (tn.Tag==null) return;

			cocktailsNeuMenuItem.Enabled = true;
			cocktailsBearbeitenMenuItem.Enabled = true;
			cocktailsLoeschenMenuItem.Enabled = true;
			cockatailsExportierenMenuItem.Enabled = true;
		}

		//Der Anwender hat auf den Contextmenu Eintrag Neu geklickt
		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			EpoRubrik		erik;
			EpoRezept		ezep;
			EpoZutat		ezut;
			EpoGlas			eglas;
			EpoGarnierung	egarn;
			TreeNode		tn;
			string			deltitle = "DATADELETE:";
			NDelegate		refrDel = new NDelegate(RefreshAfterDelete);

			tn = cocktailsTV.SelectedNode;
			if (tn == null) return;
			if (tn.Tag == null) return;

			erik = tn.Tag as EpoRubrik;
			if (erik == null) return;

			if (erik.IsRezept) 
			{
				ezep = new EpoRezept();
				ezep.RubrikOid = erik.oid;
				ezep.Flush();
				deltitle += ezep.oid.ToString();
				Nman.Instance.Register(deltitle, this, refrDel);
			} 
			else if (erik.Equals(EpoRubrik.GetZutatenRubrik())) 
			{
				ezut = new EpoZutat();
				ezut.Flush();
				deltitle += ezut.oid.ToString();
				Nman.Instance.Register(deltitle, this, refrDel);
			} 
			else if (erik.Equals(EpoRubrik.GetGlaeserRubrik())) 
			{
				eglas = new EpoGlas();
				eglas.Flush();

				deltitle += eglas.oid.ToString();
				Nman.Instance.Register(deltitle, this, refrDel);
			} 
			else if (erik.Equals(EpoRubrik.GetGarnierungenRubrik())) 
			{
				egarn = new EpoGarnierung();
				egarn.Flush();

				deltitle += egarn.oid.ToString();
				Nman.Instance.Register(deltitle, this, refrDel);
			}
		}

		private void cocktailsLoeschenMenuItem_Click(object sender, System.EventArgs e)
		{
			TreeNode		tn;
			EpoCManagerBase	ecm;
			DialogResult	res;

			tn = cocktailsTV.SelectedNode;
			if(tn==null) return;
			ecm = tn.Tag as EpoCManagerBase;
			if(ecm==null) return;

			
			res = MessageBox.Show("Wollen Sie das Element wirklich löschen?",
								"Sicherheitsrückfrage",
								MessageBoxButtons.YesNo);

			if (res==DialogResult.Yes)
				ecm.Delete();

		}

		private void cocktailsBearbeitenMenuItem_Click(object sender, System.EventArgs e)
		{
			EpoCManagerBase ema;
			TreeNode		selNode;

			selNode = cocktailsTV.SelectedNode;

			if (selNode==null) return;
			
			ema = selNode.Tag as EpoCManagerBase;
			if(ema == null) return;

			OpenForEdit(ema);
		}


		private void cocktailsTV_DblClick(object sender, System.EventArgs e)
		{
			EpoCManagerBase ema;
			TreeNode		selNode;

			selNode = cocktailsTV.SelectedNode;

			if (selNode==null) return;
			
			ema = selNode.Tag as EpoCManagerBase;
			if(ema == null) return;

			OpenForEdit(ema);
		}

		private void cocktailsTV_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			EpoRezept	rezept;
			TreeNode	selno;
			EpoGlas		myGlas;
			ArrayList	glaeser;

			selno = cocktailsTV.SelectedNode;

			if (selno == null) return;
			
			rezept = selno.Tag as EpoRezept;

			if (rezept==null) return;

			nameTB.Text = rezept.Name;
			anzahlNUD.Value = 1;
			
			glasCB.BeginUpdate();
			glasCB.Items.Clear();
			glaeser = epoGlasV.Select();
			foreach (EpoGlas glas in glaeser) 
			{
				glasCB.Items.Add(glas);
			}

			if (rezept.GlasOid!=null)
				myGlas = epoGlasV.ResolveOid(rezept.GlasOid) as EpoGlas;
			else
				myGlas = null;

			if (myGlas!=null) 
			{
				glasCB.SelectedItem = myGlas;
				inhaltTB.Text = myGlas.Inhalt.ToString() + " ml";
			}
			
			glasCB.EndUpdate();

			if (rezept.Zubereitung!=null)
				zubereitungTB.Text = rezept.Zubereitung.Text;
			else
				zubereitungTB.Text = "";
			
			FillZutatenListe(rezept);
			FillgarnierungenListe(rezept);

			volProzTB.Text = (Math.Round(rezept.GetAlkoholgehalt(),1)).ToString() + "%"; 
			beTB.Text = (Math.Round(rezept.GetBiereinheiten(),1)).ToString() + " be";
		}

		/// <summary>
		/// Selektiert das Rezept im TreeView
		/// </summary>
		/// <param name="rez">Das Rezept das selektiert werden soll</param>
		public void SelectRezept(EpoRezept rez) 
		{
			TreeNode	topTn, 
						foundTn = null;
			int			i = 0;

			while ((foundTn==null) && (i<cocktailsTV.Nodes.Count)) 
			{
				topTn = cocktailsTV.Nodes[i];
				foundTn = FindTreeNodeWithTag(topTn, rez);
				i++;
			}

			if (foundTn!=null) 
			{
				cocktailsTV.SelectedNode = foundTn;
			}
		}


		private void FillgarnierungenListe(EpoRezept rezept) 
		{
			ArrayList		rezeptgarnierungen;
			EpoGarnierung	garnierung;
			string			garnStr;

			garnierungenLB.BeginUpdate();
			garnierungenLB.Items.Clear();
			rezeptgarnierungen = epoRezeptGarnierungV.Select("[RezeptOid]='" + rezept.oid.OidStr + "'");
			foreach(EpoRezeptGarnierung rezgarn in rezeptgarnierungen) 
			{
				if (rezgarn.GarnierungOid!=null)
					garnierung = rezgarn.ResolveOid(rezgarn.GarnierungOid) as EpoGarnierung;
				else
					garnierung = null;

				if (garnierung!=null) 
				{
					garnStr = rezgarn.Menge.ToString() + " " + garnierung.ToString();
					garnierungenLB.Items.Add(garnStr);
				}
			}

			garnierungenLB.EndUpdate();
		}

		private void FillZutatenListe(EpoRezept rezept) 
		{
			ArrayList	rezeptzutaten;
			EpoZutat	zutat;
			EpoGlas		myGlas;
			int			menge;
			string		mengeStr;

			rezeptzutaten = epoRezeptZutatV.Select("[rezeptOid]='" + rezept.oid.OidStr + "'");

			myGlas = glasCB.SelectedItem as EpoGlas;

			zutatenAnteileLB.BeginUpdate();
			zutatenAnteileLB.Items.Clear();
			zutatenMengenLB.BeginUpdate();
			zutatenMengenLB.Items.Clear();
			foreach(EpoRezeptZutat rezeptZutat in rezeptzutaten)
			{
				if (rezeptZutat.ZutatOid!=null)
					zutat = epoRezeptZutatV.ResolveOid(rezeptZutat.ZutatOid) as EpoZutat;
				else
					zutat = null;

				if (zutat!=null) 
				{
					zutatenAnteileLB.Items.Add(rezeptZutat.Anteil + "% " + zutat.Name);
					menge = (int)((double)anzahlNUD.Value * Math.Round((double)myGlas.Inhalt * (double)rezeptZutat.Anteil / 100.0));
					mengeStr = menge.ToString() + " ml";
					zutatenMengenLB.Items.Add(mengeStr);
				}
			}
			zutatenAnteileLB.EndUpdate();
			zutatenMengenLB.EndUpdate();
		}

		private void anzahlNUD_ValueChanged(object sender, System.EventArgs e)
		{
			EpoRezept	rezept;
			TreeNode	selno;

			selno = cocktailsTV.SelectedNode;

			if (selno==null) return;

			rezept = selno.Tag as EpoRezept;
			FillZutatenListe(rezept);
		}

		private void glasCB_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			EpoRezept	rezept;
			TreeNode	selno;
			EpoGlas		myGlas;

			selno = cocktailsTV.SelectedNode;

			if (selno==null) return;

			myGlas = glasCB.SelectedItem as EpoGlas;

			if(myGlas==null) return;

			inhaltTB.Text = myGlas.Inhalt.ToString() + " ml";

			rezept = selno.Tag as EpoRezept;
			FillZutatenListe(rezept);

			beTB.Text = (Math.Round(rezept.GetBiereinheiten(myGlas),1)).ToString() + " be";
		
		}

		private void zutatenAnteileLB_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int itNum;

			itNum = zutatenAnteileLB.SelectedIndex;

			if (itNum>=0)
				zutatenMengenLB.SelectedIndex = itNum;
		}

		private void aboutMenuItem_Click(object sender, System.EventArgs e)
		{
			FormAbout	frm;

			frm = new FormAbout();

			frm.ShowDialog();
		}

		private void inhaltHilfeMenuItem_Click(object sender, System.EventArgs e)
		{
			Process		proc;

			proc = new Process();


			proc.StartInfo.FileName = "HelpCManagerMain.htm";

			Trace.WriteLine("Öffne OnlineHilfe - " + proc.StartInfo.FileName);
			Trace.WriteLine("Arbeitsverzeichnis - " + System.Environment.CurrentDirectory);
			proc.StartInfo.WorkingDirectory = System.Environment.CurrentDirectory;
			proc.Start();
		}

		/// <summary>
		/// Exportiert alle Daten, also alle Cocktails, Gläser, Zarnierungen und
		/// Zutaten in ein xml-file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog  sfd;
			XmlDocument		doc;
			XmlElement		mainNode;
			ArrayList		zutaten, 
							glaeser,
							rezepte,
							garnierungen;
			XmlAttribute	attr;

			sfd = new SaveFileDialog();
			sfd.Title = "Exportieren in xml-Datei";
			sfd.Filter = "XML Datei|*.xml";

			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				doc = new XmlDocument();
			
				mainNode = doc.CreateElement("CManagerData");
				attr = doc.CreateAttribute("Version");
				attr.Value = Version;

				mainNode.Attributes.Append(attr);
				
				zutaten = epoZutatV.Select();
				if (zutaten!=null) 
				{
					foreach (EpoZutat zut in zutaten) 
					{
						zut.AppendXmlRepresentation(mainNode);	
					}
				}

				glaeser = epoGlasV.Select();
				if (glaeser!=null) 
				{
					foreach (EpoGlas glas in glaeser) 
					{
						glas.AppendXmlRepresentation(mainNode);	
					}
				}

				garnierungen = epoGarnierungV.Select();
				if (garnierungen!=null) 
				{
					foreach (EpoGarnierung garn in garnierungen) 
					{
						garn.AppendXmlRepresentation(mainNode);	
					}
				}

				rezepte = epoRezeptV.Select();
				if (rezepte!=null) 
				{
					
					foreach (EpoRezept rez in rezepte) 
					{
						rez.AppendXmlRepresentation(mainNode);	
					}
				}

				doc.AppendChild(mainNode);
				doc.Save(sfd.FileName);
			}

		
		}

		private void importMenuItem_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog	ofd;
			XmlDocument		doc;
			XmlNode			mainNode;
			EpoCManagerBase	eb;

			ofd = new OpenFileDialog();
			ofd.Filter = "XML Datei|*.xml";
			ofd.Title = "Importieren aus xml";

			if (ofd.ShowDialog() == DialogResult.OK) 
			{
				try {
					doc = new XmlDocument();
					doc.Load(ofd.FileName);
				}
				catch (Exception xmlExc) 
				{
					Trace.WriteLine(xmlExc.Message);
					MessageBox.Show(xmlExc.Message);

					return;
				}


				try 
				{
					mainNode = doc.FirstChild;
					if (mainNode == null)
						MessageBox.Show("Die XML-Datei hat nicht das geforderte Format für einen CManager-Datenimport");
				
						
					if (mainNode.Name != "CManagerData")
						MessageBox.Show("Die XML-Datei hat nicht das geforderte Format für einen CManager-Datenimport");

					//Nun alles mit irgendeinem Verwo reinspielen

					epoGlasV.BeginTransaction();
					
					for(int i=0; i<mainNode.ChildNodes.Count; i++) 
					{
						eb = epoGlasV.CreateFromXmlNode(mainNode.ChildNodes[i]) as EpoCManagerBase;
						//eb.Flush(); erfolgt implizit in obiger Zeile
					}
				
					epoGlasV.CommitTransaction();
				}
				catch (Exception exc) 
				{
					Trace.WriteLine(exc.Message);
					MessageBox.Show(exc.Message);
					epoGlasV.RollbackTransaction();
					Trace.WriteLine("TRANSACTION ROLLBACK");
				}

				FillMainTree();
			}
		}

		private void cocktailSucheMenuItem_Click(object sender, System.EventArgs e)
		{
			if (cockSearchFRM == null) 
			{
				cockSearchFRM = new FormRezeptsuche();
				cockSearchFRM.ShowInTaskbar = false;
				cockSearchFRM.Show();
			}

			if (cockSearchFRM.IsDisposed) 
			{
				cockSearchFRM = new FormRezeptsuche();
				cockSearchFRM.ShowInTaskbar = false;
				cockSearchFRM.Show();
			} 
			else 
			{
				cockSearchFRM.Show();
				cockSearchFRM.Activate();
			}
		}

		/// <summary>
		/// Exportiert das Selektierte Objekt im XML-Format
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cockatailsExportierenMenuItem_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog  sfd;
			XmlDocument		doc;
			XmlElement		mainNode;
			XmlAttribute	attr;
			EpoCManagerBase	eb;
			TreeNode		tn;

			tn = cocktailsTV.SelectedNode;
			if (tn == null) return;

			eb = tn.Tag as EpoCManagerBase;
			if (eb == null) return;

			sfd = new SaveFileDialog();
			sfd.Title = "Exportieren in xml-Datei";
			sfd.Filter = "XML Datei|*.xml";

			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				doc = new XmlDocument();
			
				mainNode = doc.CreateElement("CManagerData");
				attr = doc.CreateAttribute("Version");
				attr.Value = Version;

				mainNode.Attributes.Append(attr);
			
				eb.AppendXmlRepresentation(mainNode);
				
				doc.AppendChild(mainNode);
				doc.Save(sfd.FileName);
			}

		

		
		}

		/// <summary>
		/// Rechte Mausklicks ebenfalls als Selektionen werten
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cocktailsTV_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			TreeNode	tn;
			TreeView	tv;

			if (e.Button != MouseButtons.Right)  return;
				
			tv = sender as TreeView;
			if (tv == null) return;
				
			tn = tv.GetNodeAt(e.X, e.Y);

			if (tn != null) tv.SelectedNode = tn;

		}


		public void OpenForEdit(EpoCManagerBase ema) 
		{
			EpoView			dial = null;
			EpoRezept		erez;
			EpoZutat		ezut;
			EpoGlas			eglas;
			EpoGarnierung	egarn;

			erez = ema as EpoRezept;
			ezut = ema as EpoZutat;
			eglas = ema as EpoGlas;
			egarn = ema as EpoGarnierung;

			if (erez != null) 
			{
				dial = new EpoRezeptView(ema, FormCManagerMain.MainFrm);
			} 
			else if (ezut!=null) 
			{
				dial = new EpoZutatView(ema, FormCManagerMain.MainFrm);
			} 
			else if (eglas != null) 
			{
				dial = new EpoGlasView(ema, FormCManagerMain.MainFrm);
			} 
			else if (egarn != null) 
			{
				dial = new EpoGarnierungView(ema, FormCManagerMain.MainFrm);
			}

			if(dial != null)
				dial.Show();
		}
	}
}

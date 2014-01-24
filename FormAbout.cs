using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CManager
{
	/// <summary>
	/// Zusammenfassung für FormAbout.
	/// </summary>
	public class FormAbout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label progtitelL;
		private System.Windows.Forms.TextBox versionTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button closeBU;
		private System.Windows.Forms.TextBox rezepteAnzahlTB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox zutatenAnzahlTB;
		private System.Windows.Forms.TextBox glaeserAnzahlTB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox garnierungenAnzahlTB;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormAbout()
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
            this.progtitelL = new System.Windows.Forms.Label();
            this.versionTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBU = new System.Windows.Forms.Button();
            this.rezepteAnzahlTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zutatenAnzahlTB = new System.Windows.Forms.TextBox();
            this.glaeserAnzahlTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.garnierungenAnzahlTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progtitelL
            // 
            this.progtitelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progtitelL.Location = new System.Drawing.Point(8, 8);
            this.progtitelL.Name = "progtitelL";
            this.progtitelL.Size = new System.Drawing.Size(144, 23);
            this.progtitelL.TabIndex = 0;
            this.progtitelL.Text = "Cocktailmanager";
            // 
            // versionTB
            // 
            this.versionTB.BackColor = System.Drawing.SystemColors.Control;
            this.versionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTB.Location = new System.Drawing.Point(160, 8);
            this.versionTB.Name = "versionTB";
            this.versionTB.ReadOnly = true;
            this.versionTB.Size = new System.Drawing.Size(120, 24);
            this.versionTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(8, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "(c) - Heinrich Speich 2005. Diese Software unterliegt einer Freewarelizenz. Die W" +
                "eitergabe gegen Entgelt ist nicht zulässig.";
            // 
            // closeBU
            // 
            this.closeBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBU.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeBU.Location = new System.Drawing.Point(208, 240);
            this.closeBU.Name = "closeBU";
            this.closeBU.Size = new System.Drawing.Size(75, 23);
            this.closeBU.TabIndex = 3;
            this.closeBU.Text = "Schließen";
            // 
            // rezepteAnzahlTB
            // 
            this.rezepteAnzahlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rezepteAnzahlTB.BackColor = System.Drawing.SystemColors.Control;
            this.rezepteAnzahlTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezepteAnzahlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezepteAnzahlTB.Location = new System.Drawing.Point(120, 40);
            this.rezepteAnzahlTB.Name = "rezepteAnzahlTB";
            this.rezepteAnzahlTB.ReadOnly = true;
            this.rezepteAnzahlTB.Size = new System.Drawing.Size(80, 16);
            this.rezepteAnzahlTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rezepte";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zutaten";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gläser";
            // 
            // zutatenAnzahlTB
            // 
            this.zutatenAnzahlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zutatenAnzahlTB.BackColor = System.Drawing.SystemColors.Control;
            this.zutatenAnzahlTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zutatenAnzahlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zutatenAnzahlTB.Location = new System.Drawing.Point(120, 64);
            this.zutatenAnzahlTB.Name = "zutatenAnzahlTB";
            this.zutatenAnzahlTB.ReadOnly = true;
            this.zutatenAnzahlTB.Size = new System.Drawing.Size(80, 16);
            this.zutatenAnzahlTB.TabIndex = 1;
            // 
            // glaeserAnzahlTB
            // 
            this.glaeserAnzahlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.glaeserAnzahlTB.BackColor = System.Drawing.SystemColors.Control;
            this.glaeserAnzahlTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.glaeserAnzahlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glaeserAnzahlTB.Location = new System.Drawing.Point(120, 88);
            this.glaeserAnzahlTB.Name = "glaeserAnzahlTB";
            this.glaeserAnzahlTB.ReadOnly = true;
            this.glaeserAnzahlTB.Size = new System.Drawing.Size(80, 16);
            this.glaeserAnzahlTB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Garnierungen";
            // 
            // garnierungenAnzahlTB
            // 
            this.garnierungenAnzahlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.garnierungenAnzahlTB.BackColor = System.Drawing.SystemColors.Control;
            this.garnierungenAnzahlTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.garnierungenAnzahlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnierungenAnzahlTB.Location = new System.Drawing.Point(120, 112);
            this.garnierungenAnzahlTB.Name = "garnierungenAnzahlTB";
            this.garnierungenAnzahlTB.ReadOnly = true;
            this.garnierungenAnzahlTB.Size = new System.Drawing.Size(80, 16);
            this.garnierungenAnzahlTB.TabIndex = 1;
            // 
            // FormAbout
            // 
            this.AcceptButton = this.closeBU;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeBU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionTB);
            this.Controls.Add(this.progtitelL);
            this.Controls.Add(this.rezepteAnzahlTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zutatenAnzahlTB);
            this.Controls.Add(this.glaeserAnzahlTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.garnierungenAnzahlTB);
            this.Name = "FormAbout";
            this.Text = "Über Cocktailmanager";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void FormAbout_Load(object sender, System.EventArgs e)
		{
			int		anz;

			versionTB.Text = FormCManagerMain.Version;

			anz = FormCManagerMain.epoRezeptV.GetCount();
			rezepteAnzahlTB.Text = anz.ToString();

			anz = FormCManagerMain.epoGlasV.GetCount();
			glaeserAnzahlTB.Text = anz.ToString();

			anz = FormCManagerMain.epoZutatV.GetCount();
			zutatenAnzahlTB.Text = anz.ToString();

			anz = FormCManagerMain.epoGarnierungV.GetCount();
			garnierungenAnzahlTB.Text = anz.ToString();
		}
	}
}

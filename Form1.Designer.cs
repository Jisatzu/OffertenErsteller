
namespace OffertenErsteller
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.speichern = new System.Windows.Forms.Button();
            this.abbrechen = new System.Windows.Forms.Button();
            this.bearbeiten1 = new System.Windows.Forms.Button();
            this.KostenTabelle = new System.Windows.Forms.TableLayoutPanel();
            this.kosten = new System.Windows.Forms.Label();
            this.stueckTyp = new System.Windows.Forms.Label();
            this.stueckAnzahl = new System.Windows.Forms.Label();
            this.stueckPreis = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.Label();
            this.KostenTabelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // speichern
            // 
            this.speichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speichern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.speichern.Location = new System.Drawing.Point(844, 424);
            this.speichern.Name = "speichern";
            this.speichern.Size = new System.Drawing.Size(73, 25);
            this.speichern.TabIndex = 0;
            this.speichern.Text = "Speichern";
            this.speichern.UseVisualStyleBackColor = true;
            // 
            // abbrechen
            // 
            this.abbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abbrechen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.abbrechen.Location = new System.Drawing.Point(763, 424);
            this.abbrechen.Name = "abbrechen";
            this.abbrechen.Size = new System.Drawing.Size(73, 25);
            this.abbrechen.TabIndex = 1;
            this.abbrechen.Text = "Abbrechen";
            this.abbrechen.UseVisualStyleBackColor = true;
            // 
            // bearbeiten1
            // 
            this.bearbeiten1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bearbeiten1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bearbeiten1.Location = new System.Drawing.Point(682, 424);
            this.bearbeiten1.Name = "bearbeiten1";
            this.bearbeiten1.Size = new System.Drawing.Size(73, 25);
            this.bearbeiten1.TabIndex = 3;
            this.bearbeiten1.Text = "Bearbeiten";
            this.bearbeiten1.UseVisualStyleBackColor = true;
            this.bearbeiten1.Click += new System.EventHandler(this.Bearbeiten_Click);
            // 
            // KostenTabelle
            // 
            this.KostenTabelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KostenTabelle.AutoSize = true;
            this.KostenTabelle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.KostenTabelle.ColumnCount = 6;
            this.KostenTabelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.197018F));
            this.KostenTabelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.81906F));
            this.KostenTabelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.14791F));
            this.KostenTabelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78486F));
            this.KostenTabelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0266F));
            this.KostenTabelle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.02455F));
            this.KostenTabelle.Controls.Add(this.kosten, 5, 0);
            this.KostenTabelle.Controls.Add(this.stueckTyp, 4, 0);
            this.KostenTabelle.Controls.Add(this.stueckAnzahl, 3, 0);
            this.KostenTabelle.Controls.Add(this.stueckPreis, 2, 0);
            this.KostenTabelle.Controls.Add(this.name, 1, 0);
            this.KostenTabelle.Controls.Add(this.pos, 0, 0);
            this.KostenTabelle.Location = new System.Drawing.Point(32, 63);
            this.KostenTabelle.MinimumSize = new System.Drawing.Size(2, 3);
            this.KostenTabelle.Name = "KostenTabelle";
            this.KostenTabelle.RowCount = 2;
            this.KostenTabelle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KostenTabelle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KostenTabelle.Size = new System.Drawing.Size(875, 84);
            this.KostenTabelle.TabIndex = 4;
            // 
            // kosten
            // 
            this.kosten.AutoSize = true;
            this.kosten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kosten.Location = new System.Drawing.Point(770, 4);
            this.kosten.Margin = new System.Windows.Forms.Padding(3);
            this.kosten.Name = "kosten";
            this.kosten.Size = new System.Drawing.Size(101, 48);
            this.kosten.TabIndex = 5;
            this.kosten.Text = "Kosten";
            this.kosten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stueckTyp
            // 
            this.stueckTyp.AutoSize = true;
            this.stueckTyp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stueckTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stueckTyp.Location = new System.Drawing.Point(656, 4);
            this.stueckTyp.Margin = new System.Windows.Forms.Padding(3);
            this.stueckTyp.Name = "stueckTyp";
            this.stueckTyp.Size = new System.Drawing.Size(107, 48);
            this.stueckTyp.TabIndex = 4;
            this.stueckTyp.Text = "Stück Typ";
            this.stueckTyp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stueckAnzahl
            // 
            this.stueckAnzahl.AutoSize = true;
            this.stueckAnzahl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stueckAnzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stueckAnzahl.Location = new System.Drawing.Point(518, 4);
            this.stueckAnzahl.Margin = new System.Windows.Forms.Padding(3);
            this.stueckAnzahl.Name = "stueckAnzahl";
            this.stueckAnzahl.Size = new System.Drawing.Size(131, 48);
            this.stueckAnzahl.TabIndex = 3;
            this.stueckAnzahl.Text = "Stück Anzahl";
            this.stueckAnzahl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stueckPreis
            // 
            this.stueckPreis.AutoSize = true;
            this.stueckPreis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stueckPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stueckPreis.Location = new System.Drawing.Point(395, 4);
            this.stueckPreis.Margin = new System.Windows.Forms.Padding(3);
            this.stueckPreis.Name = "stueckPreis";
            this.stueckPreis.Size = new System.Drawing.Size(116, 48);
            this.stueckPreis.TabIndex = 2;
            this.stueckPreis.Text = "Stück Preis";
            this.stueckPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(58, 4);
            this.name.Margin = new System.Windows.Forms.Padding(3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(330, 48);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pos
            // 
            this.pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.Location = new System.Drawing.Point(4, 4);
            this.pos.Margin = new System.Windows.Forms.Padding(3);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(47, 48);
            this.pos.TabIndex = 0;
            this.pos.Text = "Pos";
            this.pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(937, 461);
            this.Controls.Add(this.KostenTabelle);
            this.Controls.Add(this.bearbeiten1);
            this.Controls.Add(this.abbrechen);
            this.Controls.Add(this.speichern);
            this.MinimumSize = new System.Drawing.Size(953, 500);
            this.Name = "Form1";
            this.Text = "Kosten Tabelle";
            this.KostenTabelle.ResumeLayout(false);
            this.KostenTabelle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button speichern;
        private System.Windows.Forms.Button abbrechen;
        private System.Windows.Forms.Button bearbeiten1;
        private System.Windows.Forms.TableLayoutPanel KostenTabelle;
        private System.Windows.Forms.Label kosten;
        private System.Windows.Forms.Label stueckTyp;
        private System.Windows.Forms.Label stueckAnzahl;
        private System.Windows.Forms.Label stueckPreis;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pos;
    }
}


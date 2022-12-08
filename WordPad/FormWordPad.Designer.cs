namespace WordPad
{
    partial class FormWordPad
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWordPad));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rtbTesto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaconnomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteprimadistampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annullaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ripristinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tagliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incollaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selezionatuttoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.labekAllineamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allineamentoToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.coloreTestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontTestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elencoPuntatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elencoNumeratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.cercaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.cercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.rimpiazzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rimpiazzaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.informazionisuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rtbTesto
            // 
            this.rtbTesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTesto.Location = new System.Drawing.Point(0, 28);
            this.rtbTesto.Margin = new System.Windows.Forms.Padding(4);
            this.rtbTesto.Name = "rtbTesto";
            this.rtbTesto.Size = new System.Drawing.Size(1084, 557);
            this.rtbTesto.TabIndex = 3;
            this.rtbTesto.Text = "";
            this.rtbTesto.TextChanged += new System.EventHandler(this.rtbTesto_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.strumentiToolStripMenuItem,
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.toolStripSeparator,
            this.salvaToolStripMenuItem,
            this.salvaconnomeToolStripMenuItem,
            this.toolStripSeparator1,
            this.stampaToolStripMenuItem,
            this.anteprimadistampaToolStripMenuItem,
            this.toolStripSeparator2,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripMenuItem.Image")));
            this.nuovoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.nuovoToolStripMenuItem.Text = "&Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripMenuItem.Image")));
            this.apriToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.apriToolStripMenuItem.Text = "&Apri";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(229, 6);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripMenuItem.Image")));
            this.salvaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.salvaToolStripMenuItem.Text = "&Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // salvaconnomeToolStripMenuItem
            // 
            this.salvaconnomeToolStripMenuItem.Name = "salvaconnomeToolStripMenuItem";
            this.salvaconnomeToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.salvaconnomeToolStripMenuItem.Text = "Salva &con nome";
            this.salvaconnomeToolStripMenuItem.Click += new System.EventHandler(this.salvaconnomeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stampaToolStripMenuItem.Image")));
            this.stampaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.stampaToolStripMenuItem.Text = "&Stampa";
            this.stampaToolStripMenuItem.Click += new System.EventHandler(this.stampaToolStripMenuItem_Click);
            // 
            // anteprimadistampaToolStripMenuItem
            // 
            this.anteprimadistampaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anteprimadistampaToolStripMenuItem.Image")));
            this.anteprimadistampaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anteprimadistampaToolStripMenuItem.Name = "anteprimadistampaToolStripMenuItem";
            this.anteprimadistampaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.anteprimadistampaToolStripMenuItem.Text = "&Anteprima di stampa";
            this.anteprimadistampaToolStripMenuItem.Click += new System.EventHandler(this.anteprimadistampaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annullaToolStripMenuItem,
            this.ripristinaToolStripMenuItem,
            this.toolStripSeparator3,
            this.tagliaToolStripMenuItem,
            this.copiaToolStripMenuItem,
            this.incollaToolStripMenuItem,
            this.toolStripSeparator4,
            this.selezionatuttoToolStripMenuItem,
            this.toolStripSeparator6,
            this.labekAllineamentoToolStripMenuItem,
            this.allineamentoToolStripComboBox,
            this.toolStripSeparator7,
            this.coloreTestoToolStripMenuItem,
            this.fontTestoToolStripMenuItem});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.modificaToolStripMenuItem.Text = "&Modifica";
            // 
            // annullaToolStripMenuItem
            // 
            this.annullaToolStripMenuItem.Name = "annullaToolStripMenuItem";
            this.annullaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annullaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.annullaToolStripMenuItem.Text = "&Annulla";
            this.annullaToolStripMenuItem.Click += new System.EventHandler(this.annullaToolStripMenuItem_Click);
            // 
            // ripristinaToolStripMenuItem
            // 
            this.ripristinaToolStripMenuItem.Name = "ripristinaToolStripMenuItem";
            this.ripristinaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ripristinaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.ripristinaToolStripMenuItem.Text = "&Ripristina";
            this.ripristinaToolStripMenuItem.Click += new System.EventHandler(this.ripristinaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(211, 6);
            // 
            // tagliaToolStripMenuItem
            // 
            this.tagliaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tagliaToolStripMenuItem.Image")));
            this.tagliaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagliaToolStripMenuItem.Name = "tagliaToolStripMenuItem";
            this.tagliaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tagliaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.tagliaToolStripMenuItem.Text = "&Taglia";
            this.tagliaToolStripMenuItem.Click += new System.EventHandler(this.tagliaToolStripMenuItem_Click);
            // 
            // copiaToolStripMenuItem
            // 
            this.copiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiaToolStripMenuItem.Image")));
            this.copiaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiaToolStripMenuItem.Name = "copiaToolStripMenuItem";
            this.copiaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.copiaToolStripMenuItem.Text = "&Copia";
            this.copiaToolStripMenuItem.Click += new System.EventHandler(this.copiaToolStripMenuItem_Click);
            // 
            // incollaToolStripMenuItem
            // 
            this.incollaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incollaToolStripMenuItem.Image")));
            this.incollaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incollaToolStripMenuItem.Name = "incollaToolStripMenuItem";
            this.incollaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.incollaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.incollaToolStripMenuItem.Text = "&Incolla";
            this.incollaToolStripMenuItem.Click += new System.EventHandler(this.incollaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(211, 6);
            // 
            // selezionatuttoToolStripMenuItem
            // 
            this.selezionatuttoToolStripMenuItem.Name = "selezionatuttoToolStripMenuItem";
            this.selezionatuttoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.selezionatuttoToolStripMenuItem.Text = "Seleziona &tutto";
            this.selezionatuttoToolStripMenuItem.Click += new System.EventHandler(this.selezionatuttoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(211, 6);
            // 
            // labekAllineamentoToolStripMenuItem
            // 
            this.labekAllineamentoToolStripMenuItem.Name = "labekAllineamentoToolStripMenuItem";
            this.labekAllineamentoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.labekAllineamentoToolStripMenuItem.Text = "Allineamento:";
            // 
            // allineamentoToolStripComboBox
            // 
            this.allineamentoToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allineamentoToolStripComboBox.Items.AddRange(new object[] {
            "Sinistra",
            "Destra",
            "Centro"});
            this.allineamentoToolStripComboBox.Name = "allineamentoToolStripComboBox";
            this.allineamentoToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.allineamentoToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.AllineamentoToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(211, 6);
            // 
            // coloreTestoToolStripMenuItem
            // 
            this.coloreTestoToolStripMenuItem.Name = "coloreTestoToolStripMenuItem";
            this.coloreTestoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.coloreTestoToolStripMenuItem.Text = "Colore Testo";
            this.coloreTestoToolStripMenuItem.Click += new System.EventHandler(this.coloreTestoToolStripMenuItem_Click);
            // 
            // fontTestoToolStripMenuItem
            // 
            this.fontTestoToolStripMenuItem.Name = "fontTestoToolStripMenuItem";
            this.fontTestoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.fontTestoToolStripMenuItem.Text = "Font Testo";
            this.fontTestoToolStripMenuItem.Click += new System.EventHandler(this.fontTestoToolStripMenuItem_Click);
            // 
            // strumentiToolStripMenuItem
            // 
            this.strumentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elencoPuntatoToolStripMenuItem,
            this.elencoNumeratoToolStripMenuItem,
            this.toolStripSeparator8,
            this.cercaToolStripTextBox,
            this.cercaToolStripMenuItem,
            this.toolStripSeparator9,
            this.rimpiazzaToolStripTextBox,
            this.rimpiazzaToolStripMenuItem});
            this.strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            this.strumentiToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.strumentiToolStripMenuItem.Text = "&Strumenti";
            // 
            // elencoPuntatoToolStripMenuItem
            // 
            this.elencoPuntatoToolStripMenuItem.Name = "elencoPuntatoToolStripMenuItem";
            this.elencoPuntatoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.elencoPuntatoToolStripMenuItem.Text = "Elenco Puntato";
            this.elencoPuntatoToolStripMenuItem.Click += new System.EventHandler(this.elencoPuntatoToolStripMenuItem_Click);
            // 
            // elencoNumeratoToolStripMenuItem
            // 
            this.elencoNumeratoToolStripMenuItem.Name = "elencoNumeratoToolStripMenuItem";
            this.elencoNumeratoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.elencoNumeratoToolStripMenuItem.Text = "Elenco Numerato";
            this.elencoNumeratoToolStripMenuItem.Click += new System.EventHandler(this.elencoNumeratoToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // cercaToolStripTextBox
            // 
            this.cercaToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cercaToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cercaToolStripTextBox.Name = "cercaToolStripTextBox";
            this.cercaToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // cercaToolStripMenuItem
            // 
            this.cercaToolStripMenuItem.Name = "cercaToolStripMenuItem";
            this.cercaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cercaToolStripMenuItem.Text = "Cerca";
            this.cercaToolStripMenuItem.Click += new System.EventHandler(this.cercaToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(221, 6);
            // 
            // rimpiazzaToolStripMenuItem
            // 
            this.rimpiazzaToolStripMenuItem.Name = "rimpiazzaToolStripMenuItem";
            this.rimpiazzaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rimpiazzaToolStripMenuItem.Text = "Rimpiazza";
            this.rimpiazzaToolStripMenuItem.Click += new System.EventHandler(this.rimpiazzaToolStripMenuItem_Click);
            // 
            // rimpiazzaToolStripTextBox
            // 
            this.rimpiazzaToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rimpiazzaToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rimpiazzaToolStripTextBox.Name = "rimpiazzaToolStripTextBox";
            this.rimpiazzaToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.informazionisuToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(30, 24);
            this.ToolStripMenuItem.Text = "&?";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(200, 6);
            // 
            // informazionisuToolStripMenuItem
            // 
            this.informazionisuToolStripMenuItem.Name = "informazionisuToolStripMenuItem";
            this.informazionisuToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.informazionisuToolStripMenuItem.Text = "&Informazioni su...";
            this.informazionisuToolStripMenuItem.Click += new System.EventHandler(this.informazionisuToolStripMenuItem_Click);
            // 
            // FormWordPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 585);
            this.Controls.Add(this.rtbTesto);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormWordPad";
            this.Text = "WordPad Clone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWordPad_FormClosing);
            this.Load += new System.EventHandler(this.FormWordPad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox rtbTesto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaconnomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteprimadistampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annullaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ripristinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tagliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incollaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selezionatuttoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox allineamentoToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem informazionisuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem labekAllineamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem coloreTestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontTestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elencoPuntatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elencoNumeratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem cercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox cercaToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem rimpiazzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox rimpiazzaToolStripTextBox;
    }
}


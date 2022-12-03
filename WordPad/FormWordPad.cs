using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordPad.Controllers;

namespace WordPad
{
    public partial class FormWordPad : Form
    {

        private const int LIST_INDENTATION = 10;


        private readonly WordPadController _wordPadController;

        public FormWordPad()
        {
            InitializeComponent();
            
            _wordPadController = new WordPadController();
        }

        private void SaveHandler()
        {
            if (_wordPadController.SaveAs(out string fileName))
            {
                rtbTesto.SaveFile(fileName);
            }
            else
            {
                MessageBox.Show("Operazione annullata");
            }
        }

        private void OpenHandler()
        {
            if (_wordPadController.Open(out string fileName))
            {
                rtbTesto.LoadFile(fileName);
            }
            else
            {
                MessageBox.Show("Operazione annullata");
            }
        }

        private void NewDocumentHandler()
        {
            if (_wordPadController.DiscardChanges())
            {
                rtbTesto.Clear();
                _wordPadController.Modificato = false;
            }
            else
            {
                SaveHandler();
            }
        }

        private void FormWordPad_Load(object sender, EventArgs e)
        {
            allineamentoToolStripComboBox.SelectedIndex = 0;

            rtbTesto.BulletIndent = LIST_INDENTATION;
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e) => NewDocumentHandler();

        private void apriToolStripMenuItem_Click(object sender, EventArgs e) => OpenHandler();

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e) =>
            rtbTesto.SaveFile(_wordPadController.GetDefaultFileSavePath());

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e) => SaveHandler();

        private void rtbTesto_TextChanged(object sender, EventArgs e) => _wordPadController.Modificato = true;

        private void AllineamentoToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbTesto.SelectAll();
            rtbTesto.SelectionAlignment = (HorizontalAlignment)allineamentoToolStripComboBox.SelectedIndex;
        }

        private void selezionatuttoToolStripMenuItem_Click(object sender, EventArgs e) => rtbTesto.SelectAll();

        private void tagliaToolStripMenuItem_Click(object sender, EventArgs e) => rtbTesto.Cut();

        private void copiaToolStripMenuItem_Click(object sender, EventArgs e) => rtbTesto.Copy();

        private void incollaToolStripMenuItem_Click(object sender, EventArgs e) => rtbTesto.Paste();

        private void informazionisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void annullaToolStripMenuItem_Click(object sender, EventArgs e) => rtbTesto.Undo();


        private void ripristinaToolStripMenuItem_Click(object sender, EventArgs e) => rtbTesto.Redo();

        private void coloreTestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_wordPadController.SelectColor(out Color color))
            {
                rtbTesto.ForeColor = color;
            }
        }

        private void fontTestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_wordPadController.SelectFont(out Font font))
            {
                rtbTesto.Font = font;
            }
        }

        private void elencoPuntatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTesto.SelectionBullet = true;
        }

        private void elencoNumeratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }


        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FormWordPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_wordPadController.Modificato && !_wordPadController.DiscardChanges())
            {
                SaveHandler();
            }
        }

       
    }
}

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
                rtbTesto.Text = "";
            }
            else
            {
                SaveHandler();
            }
        }

        private void FormWordPad_Load(object sender, EventArgs e)
        {

        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e) => NewDocumentHandler();

        private void apriToolStripMenuItem_Click(object sender, EventArgs e) => OpenHandler();

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e) =>
            rtbTesto.SaveFile(_wordPadController.GetDefaultFileSavePath());

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e) => SaveHandler();

        private void rtbTesto_TextChanged(object sender, EventArgs e) => _wordPadController.Modificato = true;
    }
}

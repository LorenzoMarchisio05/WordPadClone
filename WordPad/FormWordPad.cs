using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordPad.Controllers;
using WordPad.Validators;

namespace WordPad
{
    public partial class FormWordPad : Form
    {

        private const int LIST_INDENTATION = 10;


        private readonly WordPadController _wordPadController;
        private readonly clsStampa _printer;

        public FormWordPad()
        {
            InitializeComponent();
            
            _wordPadController = new WordPadController();
            _printer = new clsStampa();
        }

        private void FileNameChangedHandler(string fileName)
        {
            if(fileName.Contains('\\'))
            {
                fileName = fileName.Substring(fileName.LastIndexOf('\\')+1);
            }
            this.Text = $"Wordpad Clone - {fileName}";
        }

        private void SaveHandler()
        {
            if (_wordPadController.SaveAs(out string fileName))
            {
                rtbTesto.SaveFile(fileName);
                FileNameChangedHandler(fileName);
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
                FileNameChangedHandler(fileName);
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
                FileNameChangedHandler("senza nome");
            }
            else
            {
                SaveHandler();
            }
        }

        private void ResearchHandler()
        {
            string searchedText = cercaToolStripTextBox.Text.ToLower();
            string whereToSearch = Regex.Replace(rtbTesto.Text, @"\W", " ").ToLower();
            int startIndex = 0;

            IEnumerable<string> matchingWords = whereToSearch
                .Split(' ')
                .Where(word => word == searchedText);

            foreach (string word in matchingWords)
            {
                int wordIndex = rtbTesto.Text.IndexOf(word, startIndex);

                rtbTesto.Select(wordIndex, word.Length);
                rtbTesto.SelectionColor = Color.Red;

                startIndex = wordIndex + word.Length;
            }
        }

        private void ReplaceHandler()
        {
            rtbTesto.Text = rtbTesto.Text
                .ToLower()
                .Replace(
                    cercaToolStripTextBox.Text
                    .ToLower(), 
                    rimpiazzaToolStripTextBox.Text
                    );
        }
        
        private void NumberedListHandler()
        {
            string text;

            int indexFirstChar = rtbTesto.GetFirstCharIndexOfCurrentLine();

            int lineIndex = rtbTesto.GetLineFromCharIndex(indexFirstChar);

            string selectedText = rtbTesto.SelectedText.Trim();

            
            try
            {
                string[] righe = selectedText == "" ?
                new string[] { rtbTesto.Lines[lineIndex] } :
                selectedText.Split('\n');
                text = _wordPadController.getNumberedListFormattedText(rtbTesto.Text, righe);
            }
            catch (Exception)
            {
                text = "1. ";
            }

            rtbTesto.Text = text;
            rtbTesto.Select(rtbTesto.Text.Length, 0);
        }


        private void KeyPressHandler(Keys key)
        {
            try
            {
                if (key == Keys.Return)
                {
                    int lineIndex = rtbTesto.GetLineFromCharIndex(rtbTesto.GetFirstCharIndexOfCurrentLine())-1;
                    string line = rtbTesto.Lines[lineIndex];

                    if (NumberedRowsValidator.Validate(line))
                    {
                        return;
                    }

                    if(line.EndsWith(". "))
                    {
                        return;
                    }

                    int numero = int.Parse(line.Substring(0, line.IndexOf('.')));
                    rtbTesto.AppendText($"{numero + 1}. ");
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void FormWordPad_Load(object sender, EventArgs e)
        {
            allineamentoToolStripComboBox.SelectedIndex = 0;

            rtbTesto.BulletIndent = LIST_INDENTATION;

            _wordPadController.Modificato = false;

            rtbTesto.Font = new Font("arial", 9.5f);

            NewDocumentHandler();
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

        private void informazionisuToolStripMenuItem_Click(object sender, EventArgs e) => new AboutBox().ShowDialog();

        private void annullaToolStripMenuItem_Click(object sender, EventArgs e) => rtbTesto.Undo();


        private void ripristinaToolStripMenuItem_Click(object sender, EventArgs e) => rtbTesto.Redo();

        private void coloreTestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_wordPadController.SelectColor(out Color color))
            {
                rtbTesto.SelectionColor = color;
            }
        }

        private void fontTestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_wordPadController.SelectFont(out Font font))
            {
                rtbTesto.SelectionFont = font;
            }
        }

        private void elencoPuntatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTesto.SelectionBullet = !rtbTesto.SelectionBullet;
        }

        private void elencoNumeratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            NumberedListHandler();
        }
        
        private void esciToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void FormWordPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_wordPadController.Modificato && !_wordPadController.DiscardChanges())
            {
                SaveHandler();
            }
        }


        private void cercaToolStripMenuItem_Click(object sender, EventArgs e) => ResearchHandler();

        private void rimpiazzaToolStripMenuItem_Click(object sender, EventArgs e) => ReplaceHandler();

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e) => _printer.Stampa(rtbTesto.Text, null);

        private void anteprimadistampaToolStripMenuItem_Click(object sender, EventArgs e) => _printer.Anteprima(rtbTesto.Text, null);

        private void rtbTesto_KeyUp(object sender, KeyEventArgs e) => KeyPressHandler(e.KeyCode);

        private void immagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_wordPadController.SelectImage())
            {
                rtbTesto.Paste();
                Clipboard.Clear();
            }
        }
    }
}

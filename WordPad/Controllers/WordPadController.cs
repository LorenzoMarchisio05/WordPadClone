using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordPad.Validators;

namespace WordPad.Controllers
{
    public sealed class WordPadController
    {
        public bool Modificato { get; set; }

        public bool SelectColor(out Color color)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult res = colorDialog.ShowDialog();
            color = colorDialog.Color;
            return res == DialogResult.OK;
        }

        public bool SelectFont(out Font color)
        {
            FontDialog colorDialog = new FontDialog();
            DialogResult res = colorDialog.ShowDialog();
            color = colorDialog.Font;
            return res == DialogResult.OK;
        }

        public bool DiscardChanges()
        {
            if(!Modificato)
            {
                return true;
            }

            Modificato = false;
            return MessageBox.Show(
                "Vuoi salvare il contenuto del documento?",
                "Salva",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning) != DialogResult.Yes;
        }

        public bool SaveAs(out string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "WordPad - Salva File";
            saveFileDialog.Filter = "Data Filses (*.rtf)|*.rtf";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = GetDefaultFolderPath();

            fileName = saveFileDialog.ShowDialog() == DialogResult.OK ?
                saveFileDialog.FileName :
                "";

            Modificato = fileName == "";

            return fileName != "";
        }

        public bool Open(out string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "WordPad - Salva File";
            saveFileDialog.Filter = "Data Filses (*.rtf)|*.rtf";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = GetDefaultFolderPath();

            fileName = saveFileDialog.ShowDialog() == DialogResult.OK ?
                saveFileDialog.FileName :
                "";

            return fileName != "";
        }

        public string GetDefaultFileSavePath()
        {
            Modificato = false;
            return $"{GetDefaultFolderPath()}\\senza nome.rtf";
        }

        public string getNumberedListFormattedText(string source, string[] righe)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string returnedText = source;
            string joinedRows = string.Join("", righe).Trim();

            for (int i = 0; i < righe.Length; i++)
            {
                if (NumberedRowsValidator.Validate(righe[i]))
                {
                    stringBuilder
                    .Append($"{i + 1}. ")
                    .Append(righe[i])
                    .Append("\n");
                }
            }

            if(joinedRows == "")
            {
                returnedText = $"{source}1. ";
            }
            else if(stringBuilder.Length > 0 )
            {
                string newText = stringBuilder.ToString().Substring(0, stringBuilder.Length - 1);
                returnedText = source.Replace(joinedRows, newText);
            }

            return returnedText;
        }

        private string GetDefaultFolderPath() => Environment
                        .GetFolderPath(Environment.SpecialFolder.Desktop);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad.Controllers
{
    public sealed class WordPadController
    {
        public bool Modificato { get; set; }

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
            if (!Modificato)
            {
                fileName = "";
                return false;
            }

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

        private string GetDefaultFolderPath() => Environment
                        .GetFolderPath(Environment.SpecialFolder.Desktop);
    }
}

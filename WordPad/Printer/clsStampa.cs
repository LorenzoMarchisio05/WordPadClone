using System.Drawing;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Forms;

namespace WordPad
{
    public sealed class clsStampa
    {
        #region costants

        // 1 unit = 1/100 inch ( 0,254mm )
        private const int InlineMargin = 79;

        private const int BlockMargin = 100;
        
        private static readonly Font DefaultFont = new Font("Arial", 20, FontStyle.Regular);
        #endregion


       // Documento stampa
        private readonly PrintDocument _printDocument;


        // Finestre di dialogo
        private readonly PageSetupDialog _pageSetupDialog;

        private readonly PrintDialog _printDialog;

        private readonly PrintPreviewDialog _printPreviewDialog;


        // user settings
        private string _userText;

        private Font _userFont;



        public clsStampa()
        {
            _printDocument = new PrintDocument();

            _pageSetupDialog = new PageSetupDialog();

            _printDialog = new PrintDialog();

            _printPreviewDialog = new PrintPreviewDialog();

            // imposto parametri di default
            initDefaultParameters();

        }

        public void ImpostaPagina()
        {
            _pageSetupDialog.ShowDialog();
            /*
             * In corrispondenza dell'ok i valori impostati vengono
             * automaticamente copiati dentro il printDocument
             */
        }


        public void Anteprima(string text, Font font)
        {
            _userText = text;
            _userFont = font ?? DefaultFont;

            _printPreviewDialog.ShowDialog();
        }


        public void Stampa(string text, Font font)
        {
            _userText = text;
            _userFont = font ?? DefaultFont;

            // L'utente può decidere se stampare o annullare
             _printDocument.Print();
            
        }


        private void initDefaultParameters()
        {

            // setting margins 
            _printDocument
                .DefaultPageSettings
                .Margins
                .Left = InlineMargin;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Right = InlineMargin;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Top = BlockMargin;

            _printDocument
                .DefaultPageSettings
                .Margins
                .Bottom = BlockMargin;

            // setting copies count
            _printDocument
                .PrinterSettings
                .Copies = 1;


            // linking commond dialog with print document
            _pageSetupDialog.Document = _printDocument;

            _printPreviewDialog.Document = _printDocument;

            _printDialog.Document = _printDocument;

            _pageSetupDialog.EnableMetric = true;
        }


    }
}

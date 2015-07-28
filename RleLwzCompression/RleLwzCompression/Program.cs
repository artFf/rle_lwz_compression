using System;
using System.Windows.Forms;
using RleLwzCompressionLibrary.Presenters;

namespace RleLwzCompression
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Create presenter and initialize form
            var rleLwzCompressionForm = new RleLwzCompressionForm();
            CompressionPresenter compressionPresenter = new CompressionPresenter(rleLwzCompressionForm);

            rleLwzCompressionForm.StartPosition = FormStartPosition.CenterScreen;
            rleLwzCompressionForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            rleLwzCompressionForm.MaximizeBox = false;
            Application.Run(rleLwzCompressionForm);
        }
    }
}

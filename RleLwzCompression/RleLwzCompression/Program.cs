using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RleLwzCompressionLibrary.Algorithms.Interfaces;
using RleLwzCompressionLibrary.Enums;
using RleLwzCompressionLibrary.Enums.Extenstions;
using RleLwzCompressionLibrary.Presenters;
using RleLwzCompressionLibrary.ViewInerfaces;

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

            var rleLwzCompressionForm = new RleLwzCompressionForm();
            CompressionPresenter compressionPresenter = new CompressionPresenter(rleLwzCompressionForm);

            rleLwzCompressionForm.StartPosition = FormStartPosition.CenterScreen;
            rleLwzCompressionForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            rleLwzCompressionForm.MaximizeBox = false;
            string fg = OpenFileDialogEnums.Filter.ToString();
            var hjh = OpenFileDialogEnums.Filter.GetStringValue();
            Application.Run(rleLwzCompressionForm);
        }
    }
}

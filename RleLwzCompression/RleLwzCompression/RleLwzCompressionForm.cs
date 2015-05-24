using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RleLwzCompressionLibrary.Models;
using RleLwzCompressionLibrary.ViewInerfaces;
using RleLwzCompressionLibrary.Enums;
using RleLwzCompressionLibrary.Enums.Extenstions;

namespace RleLwzCompression
{
    public partial class RleLwzCompressionForm : Form, IRleLwzCompressionForm
    {
        #region Actions

        public event Action ButtonLoadPicture;
        public event Action ButtonShowLogView;
        public event Action ButtonCloseRleLwzCompressionForm;
        public event Action ButtonEncodePicture;
        public event Action ButtonDecodePicture;
        public event Action ButtonClearSources;

        #endregion

        public RleLwzCompressionForm()
        {
            InitializeComponent();
            CreateActions();
        }
        
        public void ShowPicture(Picture picture)
        {
            pictureBoxLoadedPicture.Image = new Bitmap(picture.Path);
            labelLoadedPictureName.Text += string.Format(" {0}", picture.Name);
            labelLoadedPicturePath.Text += string.Format(" {0}", picture.Path);
            labelLoadedPictureSize.Text += string.Format(" {0}", picture.Size);
        }

        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        public void ClearSources()
        {
            throw new NotImplementedException();
        }

        public string LoadPicture()
        {
            var dialog = new OpenFileDialog
            {
                Filter = OpenFileDialogEnums.Filter.GetStringValue(),
                InitialDirectory = Environment.CurrentDirectory,
                Title = OpenFileDialogEnums.Title.GetStringValue()
            };

            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
        }

        #region Private methods

        private void CreateActions()
        {
            loadPictureToolStripMenuItem.Click += loadPictureToolStripMenuItem_Click;
            logViewToolStripMenuItem.Click += logViewToolStripMenuItem_Click;
            buttonEncode.Click += buttonEncode_Click;
            buttonDecode.Click += buttonDecode_Click;
            buttonClear.Click += buttonClear_Click;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (ButtonClearSources != null)
            {
                ButtonClearSources();
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            if (ButtonDecodePicture != null)
            {
                ButtonDecodePicture();
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            if (ButtonEncodePicture != null)
            {
                ButtonEncodePicture();
            }
        }

        private void logViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ButtonShowLogView != null)
            {
                ButtonShowLogView();
            }
        }

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ButtonLoadPicture != null)
            {
                ButtonLoadPicture();
            }
        }

        #endregion
    }
}

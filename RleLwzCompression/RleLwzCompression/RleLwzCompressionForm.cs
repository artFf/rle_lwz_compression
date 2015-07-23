using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private Picture LPicture { get; set; }
        private Picture RlePicture { get; set; }
        private Picture LwzPicture { get; set; }

        public RleLwzCompressionForm()
        {
            InitializeComponent();
            CreateActions();
            InitializeControls();
        }

        public void ShowPicture(Picture picture)
        {
            LPicture = picture;
            pictureBoxLoadedPicture.Image = new Bitmap(LPicture.Path);
            labelLPicN.Text = string.Format(" {0}", LPicture.Name);
            labelLPicP.Text = string.Format(" {0}", (LPicture.Path.Length > 35) ? "..." + LPicture.Path.Substring(LPicture.Path.Length - 35, 35) : LPicture.Path);
            labelLPicS.Text = string.Format(" {0}", LPicture.Size);
        }

        private void InitializeControls()
        {
            labelLPicN.Text = string.Format("{0}", "---");
            labelLPicP.Text = string.Format("{0}", "---");
            labelLPicS.Text = string.Format("{0}", "---");
            labelLWZComressinResult.Text = string.Format("{0}", "---");
            labelRleComressionResult.Text = string.Format("{0}", "---");
            labelRleSize.Text = string.Format("{0}", "---");
            labelLwzSize.Text = string.Format("{0}", "---");
        }

        public void ShowRleEncoded(Picture picture)
        {
            RlePicture = picture;
            //todo check need to convert to double
            labelRleComressionResult.Text = string.Format(" {0}", (float)RlePicture.Size / (float)LPicture.Size * 100);
            labelRleSize.Text = string.Format(" {0}", RlePicture.Size);
        }

        public void ShowLwzEncoded(Picture picture)
        {
            LwzPicture = picture;
            labelLWZComressinResult.Text = string.Format(" {0}", (float)LwzPicture.Size / (float)LPicture.Size * 100);
            labelLwzSize.Text = string.Format(" {0}", LwzPicture.Size);
        }

        public void ShowRleDecoded(Picture picture)
        {
            RlePicture = picture;
            pictureBoxRleDecodePicture.Image = new Bitmap(new MemoryStream(RlePicture.DecodedContents));
        }

        public void ShowLwzDecoded(Picture picture)
        {
            LwzPicture = picture;
            pictureBoxLwzDecodePicture.Image = new Bitmap(new MemoryStream(LwzPicture.DecodedContents));
        }

        public void ShowLogView()
        {
            throw new NotImplementedException();
        }

        public Picture GetRleEncodedPicture()
        {
            return RlePicture;
        }

        public Picture GetLwzEncodedPicture()
        {
            return LwzPicture;
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void ClearSources()
        {
            InitializeControls();
            ClearImages();
        }

        private void ClearImages()
        {
            pictureBoxLoadedPicture.Image = null;
            pictureBoxLoadedPicture.Refresh();
            pictureBoxRleDecodePicture.Image = null;
            pictureBoxRleDecodePicture.Refresh();
            pictureBoxLwzDecodePicture.Image = null;
            pictureBoxLwzDecodePicture.Refresh();

            progressBarRleEncode.Value = 0;
            progressBarLwzEncode.Value = 0;
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

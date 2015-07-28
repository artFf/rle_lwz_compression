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
using RleLwzCompressionLibrary.Exceptions;

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
            labelEncodeRleProgress.Text = @"Encode RLE progress:";
            labelEncodeLwzProgress.Text = @"Encode LWZ progress:";
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
            pictureBoxRleDecodePicture.Image = new Bitmap(new MemoryStream(RlePicture.DecodedContents.ToArray()));
        }

        public void ShowLwzDecoded(Picture picture)
        {
            LwzPicture = picture;
            pictureBoxLwzDecodePicture.Image = new Bitmap(new MemoryStream(LwzPicture.DecodedContents.ToArray()));
        }

        public void ShowLogView()
        {
            throw new NotImplementedException();
        }

        public Picture GetEncodedPicture(AlgorithmEnum algorithmType)
        {
            if (algorithmType == AlgorithmEnum.Rle)
                return RlePicture;
            if (algorithmType == AlgorithmEnum.Lwz)
                return LwzPicture;
            
            return new Picture();
        }
        
        public Picture GetPictureInfo(string pathToPicture)
        {
            try
            {
                var picture = new Picture
                {
                    Path = pathToPicture,
                    Name = Path.GetFileName(pathToPicture),
                    Size = new FileInfo(pathToPicture).Length
                };

                return picture;
            }
            catch (Exception e)
            {
                throw new PresenterException(e.Message, e);
            }
        }

        public void CloseForm()
        {
            ClearSources();
            this.Close();
        }

        public void ClearSources()
        {
            InitializeControls();
            ClearImages();
        }

        private void ClearImages()
        {
            if (pictureBoxLoadedPicture.Image != null)
            {
                pictureBoxLoadedPicture.Image.Dispose();
                pictureBoxLoadedPicture.Image = null;
            }

            if (pictureBoxRleDecodePicture.Image != null)
            {
                pictureBoxRleDecodePicture.Image.Dispose();
                pictureBoxRleDecodePicture.Image = null;
            }

            if (pictureBoxLwzDecodePicture.Image != null)
            {
                pictureBoxLwzDecodePicture.Image.Dispose();
                pictureBoxLwzDecodePicture.Image = null;
            }
            
            LPicture = null;
            RlePicture = null;
            LwzPicture = null;
        }

        public string LoadPicture()
        {
            try
            {
                var dialog = new OpenFileDialog
                {
                    Filter = OpenFileDialogEnum.Filter.GetStringValue(),
                    InitialDirectory = Environment.CurrentDirectory,
                    Title = OpenFileDialogEnum.Title.GetStringValue()
                };

                return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
            }
            catch (Exception e)
            {
                throw new PresenterException(e.Message,e);
            }
        }

        public void ShowError(string errorMassage)
        {
            MessageBox.Show(errorMassage);
        }

        public void ShowLoader(AlgorithmEnum algorithm, bool switchOn,OperationEnum operation)
        {
            if (operation == OperationEnum.Encode)
            {
                labelEncodeRleProgress.Text = @"Encode RLE progress:";
                labelEncodeLwzProgress.Text = @"Encode LWZ progress:";
            }
            if (operation == OperationEnum.Decode)
            {
                labelEncodeRleProgress.Text = @"Decode RLE progress:";
                labelEncodeLwzProgress.Text = @"Decode LWZ progress:";
            }

            if (switchOn)
            {
                if (algorithm == AlgorithmEnum.Rle)
                    pictureBoxRleWorking.Visible = true;
                if (algorithm == AlgorithmEnum.Lwz)
                    pictureBoxLwzWorking.Visible = true;
            }
            else
            {
                if (algorithm == AlgorithmEnum.Rle)
                    pictureBoxRleWorking.Visible = false;
                if (algorithm == AlgorithmEnum.Lwz)
                    pictureBoxLwzWorking.Visible = false;
            }
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

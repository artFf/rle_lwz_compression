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

namespace RleLwzCompression
{
    public partial class RleLwzCompression : Form, IRleLwzCompression
    {
        public RleLwzCompression()
        {
            InitializeComponent();
        }

        public event Action ButtonLoadPicture;
        public event Action ButtonCloseRleLwzCompressionForm;
        public event Action ButtonEncodePicture;
        public event Action ButtonDecodePicture;
        public event Action ButtonClearSources;
        public void ShowPicture(Picture picture)
        {
            throw new NotImplementedException();
        }

        public void CloseForm()
        {
            throw new NotImplementedException();
        }

        public void ClearSources()
        {
            throw new NotImplementedException();
        }

        public void LoadPicture()
        {
            throw new NotImplementedException();
        }
    }
}

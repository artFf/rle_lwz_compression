using System;
using RleLwzCompressionLibrary.Enums;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.ViewInerfaces
{
    public interface IRleLwzCompressionForm
    {
        #region Events

        event Action ButtonLoadPicture;
        event Action ButtonShowLogView;
        event Action ButtonCloseRleLwzCompressionForm;
        event Action ButtonEncodePicture;
        event Action ButtonDecodePicture;
        event Action ButtonClearSources;

        #endregion

        /// <summary>
        /// Show loaded picture
        /// </summary>
        /// <param name="picture"></param>
        void ShowPicture(Picture picture);

        /// <summary>
        /// Show RLE encoded result
        /// </summary>
        /// <param name="picture"></param>
        void ShowRleEncoded(Picture picture);

        /// <summary>
        /// Show LWZ encoded result
        /// </summary>
        /// <param name="picture"></param>
        void ShowLwzEncoded(Picture picture);

        /// <summary>
        /// Show RLE decoded result
        /// </summary>
        /// <param name="picture"></param>
        void ShowRleDecoded(Picture picture);

        /// <summary>
        /// Show LWZ decoded result
        /// </summary>
        /// <param name="picture"></param>
        void ShowLwzDecoded(Picture picture);

        /// <summary>
        /// Show Log View
        /// </summary>
        void ShowLogView();

        /// <summary>
        /// Close main form
        /// </summary>
        void CloseForm();

        /// <summary>
        /// Clear sources
        /// </summary>
        void ClearSources();

        /// <summary>
        /// Show error
        /// </summary>
        /// <param name="errorMassage"></param>
        void ShowError(string errorMassage);

        /// <summary>
        /// Show animation
        /// </summary>
        /// <param name="algorithm">algorithm type</param>
        /// <param name="switchOn">switch on/off animation</param>
        /// <param name="operation">operation type</param>
        void ShowLoader(AlgorithmEnum algorithm, bool switchOn, OperationEnum operation);

        /// <summary>
        /// Get encoded picture
        /// </summary>
        /// <param name="algorithmType">algorithm type</param>
        /// <returns></returns>
        Picture GetEncodedPicture(AlgorithmEnum algorithmType);

        /// <summary>
        /// Get picture info
        /// </summary>
        /// <param name="pathToPicture">path to picture</param>
        /// <returns></returns>
        Picture GetPictureInfo(string pathToPicture);

        /// <summary>
        /// Show window for load picture
        /// </summary>
        /// <returns></returns>
        string LoadPicture();
    }
}

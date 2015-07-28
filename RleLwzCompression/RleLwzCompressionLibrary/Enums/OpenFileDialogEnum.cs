using RleLwzCompressionLibrary.Enums.Attributes;

namespace RleLwzCompressionLibrary.Enums
{
    /// <summary>
    /// Open file dialog settings
    /// </summary>
    public enum OpenFileDialogEnum
    {
        [EnumDisplay("JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif")]
        Filter,
        [EnumDisplay("Please select an image file to test.")]
        Title
    }
}

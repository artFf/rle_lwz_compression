using RleLwzCompressionLibrary.Enums.Attributes;

namespace RleLwzCompressionLibrary.Enums
{
    public enum OpenFileDialogEnums
    {
        [EnumDisplay("JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif")]
        Filter,
        [EnumDisplay("Please select an image file to test.")]
        Title
    }
}

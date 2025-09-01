using System.Windows;
using System.Windows.Media.Imaging;

namespace OOP_Final_Project_WPF.Models
{
    /// <summary>
    /// Selectable shape model
    /// </summary>
    public class ImageOptionModel
    {
        /// <summary>
        /// name of selected shape display at the bottom left
        /// </summary>
        public string Heading { get; set; }
        /// <summary>
        /// Shape loaded image
        /// </summary>
        public BitmapImage Bitmap { get; set; }
        /// <summary>
        /// Is this shape 2D
        /// </summary>
        public bool Is2D { get; set; }
        /// <summary>
        /// Location of shape on disk
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Click call back when user clicks on shape
        /// </summary>
        public event RoutedEventHandler onClick;
        public void onButtonClick(object sender, RoutedEventArgs e)
        {
            onClick?.Invoke(sender, e);
        }
    }
}

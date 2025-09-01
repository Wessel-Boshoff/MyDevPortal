using OOP_Final_Project_WPF.Models;
using System.Windows;
using System.Windows.Controls;

namespace OOPProject.WPF.Views
{
    /// <summary>
    /// Interaction logic for ImageOptionUserControl.xaml
    /// </summary>
    public partial class ImageOptionUserControl : UserControl
    {
        private readonly ImageOptionModel model;
        public ImageOptionUserControl()
        {
            model = new ImageOptionModel();
            init();
        }

        public ImageOptionUserControl(ImageOptionModel imageModel)
        {
            model = imageModel;
            init();
        }

        private void init()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model.onButtonClick(model, e);
        }
    }
}

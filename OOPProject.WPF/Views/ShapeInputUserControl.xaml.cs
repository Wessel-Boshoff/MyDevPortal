using OOP_Final_Project_WPF.Models;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace OOPProject.WPF.Views
{
    /// <summary>
    /// Interaction logic for ShapeInputUserControl.xaml
    /// </summary>
    public partial class ShapeInputUserControl : UserControl
    {
        private readonly ShapeInputModel model;
        public ShapeInputUserControl()
        {
            model = new ShapeInputModel();
            init();
        }

        public ShapeInputUserControl(ShapeInputModel shapeInput)
        {
            model = shapeInput;
            init();
        }

        private void init()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}

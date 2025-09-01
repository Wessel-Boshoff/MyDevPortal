using OOP_Final_Project_WPF.Models;
using OOPProject.Common.Enums;
using OOPProject.WPF.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace OOPProject.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private bool Is2D { get; set; }

    public MainWindow()
    {
        InitializeComponent();
    }

    private void tcShapes_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string tabItem = ((sender as TabControl).SelectedItem as TabItem).Header as string;
        LoadSelectableShapes(tabItem == "2D Shapes");
    }

    private void LoadSelectableShapes(bool is2D)
    {
        Is2D = is2D;
        wrpSelectableShapes.Children.Clear();
        string dir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", is2D ? "Shapes2D" : "Shapes3D");
        foreach (var path in System.IO.Directory.GetFiles(dir))
        {
            BitmapImage bitmap = new();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(path);
            bitmap.EndInit();
            bitmap.Freeze();
            ImageOptionModel imageModel = new()
            {
                Bitmap = bitmap,
                Heading = System.IO.Path.GetFileNameWithoutExtension(path),
                Path = path,
                Is2D = is2D
            };
            imageModel.onClick += Button_Click;
            ImageOptionUserControl imageControl = new(imageModel);
            wrpSelectableShapes.Children.Add(imageControl);
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        docMainContainer.Children.Clear();
        ImageOptionModel? objSender = sender as ImageOptionModel;
        ShapesModel model = new()
        {
            ShapeType = (Shape)Enum.Parse(typeof(Shape), objSender.Heading),
            ImagePath = objSender.Path,
            ImageName = objSender.Heading,
            Is2D = objSender.Is2D
        };
        ShapesUserControl shapesControl = new ShapesUserControl(model);

        docMainContainer.Children.Add(shapesControl);
    }
}
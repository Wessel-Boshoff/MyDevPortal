using OOP_Final_Project_WPF.Models;
using OOPProject.Calculations;
using System.Windows;
using System.Windows.Controls;

namespace OOPProject.WPF.Views
{
    /// <summary>
    /// Interaction logic for ShapesUserControl.xaml
    /// </summary>
    public partial class ShapesUserControl : UserControl
    {
        private readonly ShapesModel model;
        private Calculator shapeCalculator;
        public ShapesUserControl()
        {
            model = new ShapesModel();
            init();
        }

        public ShapesUserControl(ShapesModel shapesModel)
        {
            model = shapesModel;
            init();
        }

        private void init()
        {
            InitializeComponent();
            DataContext = model;
            shapeCalculator = new Calculator();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetResult(0);
            LoadInputs();
        }

        private void LoadInputs()
        {
            stkInputs.Children.Clear();
            var shapeInputModel = model.Inputs.Select(c => new ShapeInputModel(c));
            if (shapeInputModel == null) return;
            foreach (var input in shapeInputModel)
            {
                stkInputs.Children.Add(new ShapeInputUserControl(input));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region Get Values
            List<double> values = new List<double>();
            foreach (var item in stkInputs.Children)
            {
                ShapeInputUserControl inputControl = item as ShapeInputUserControl;
                if (inputControl == null)
                {
                    continue;
                }

                ShapeInputModel input = (ShapeInputModel)inputControl.DataContext;
                values.Add(input.Value);
            }
            #endregion

            #region Do calculation
            var calculationResult = shapeCalculator.Calculate(model.ShapeType, model.CalculationType, values.ToArray());
            if (!calculationResult.Success)
            {
                MessageBox.Show(calculationResult.ErrorsDisplay);
                return;
            }
            SetResult(calculationResult.Result);

            #endregion
        }

        private void SetResult(double value)
        {
            model.Result = value;
            txtResult.Text = model.ResultDisplay;
        }

    }
}

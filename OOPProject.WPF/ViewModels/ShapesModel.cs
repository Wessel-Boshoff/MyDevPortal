using OOPProject.Common;
using OOPProject.Common.Enums;
using System.Globalization;

namespace OOP_Final_Project_WPF.Models
{
    /// <summary>
    /// Selected shape
    /// </summary>
    public class ShapesModel
    {
        /// <summary>
        /// selected calculation
        /// </summary>
        public Calculation CalculationType { get; set; }
        /// <summary>
        /// Selected shape
        /// </summary>
        public Shape ShapeType { get; set; }
        /// <summary>
        /// Selected Shape dimension
        /// </summary>
        public bool Is2D { get; set; }
        /// <summary>
        /// name of selected shape image
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// Location of selected shape on disk
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// List of inputs for shape and calculation
        /// </summary>
        public List<string> Inputs
        {
            get
            {
                return Constants.Formulas[ShapeType][CalculationType];
            }
        }
        /// <summary>
        /// Result of calculation
        /// </summary>
        public double Result { get; set; }
        /// <summary>
        /// End user view of result
        /// </summary>
        public string ResultDisplay
        {
            get
            {
                return Result.ToString("n2", CultureInfo.CurrentCulture);
            }
        }
        /// <summary>
        /// Calculation types of selected shape
        /// </summary>
        public IEnumerable<SelectItemModel> CalculationTypes
        {
            get
            {
                return Constants.Formulas[ShapeType].Select(c => new SelectItemModel() { Text = c.Key.ToString(), Value = c.Key });
            }
        }
    }
}

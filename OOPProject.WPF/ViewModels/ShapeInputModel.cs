namespace OOP_Final_Project_WPF.Models
{
    /// <summary>
    /// Label input pair
    /// </summary>
    public class ShapeInputModel
    {
        /// <summary>
        /// Input text the user sees
        /// </summary>
        public string LabelContent { get; set; }
        /// <summary>
        /// Field of numerical inputs 
        /// </summary>
        public double Value { get; set; }

        public ShapeInputModel()
        { }

        public ShapeInputModel(string labelContent)
        {
            LabelContent = labelContent;
        }

    }
}

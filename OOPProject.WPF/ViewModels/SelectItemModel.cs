namespace OOP_Final_Project_WPF.Models
{
    /// <summary>
    /// Generic item selection model used in drop downs
    /// </summary>
    public class SelectItemModel
    {
        /// <summary>
        /// Text user see
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Code behind object example an id 
        /// </summary>
        public object Value { get; set; }
    }
}

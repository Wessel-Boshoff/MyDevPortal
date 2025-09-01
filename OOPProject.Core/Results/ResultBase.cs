using System.Text;

namespace OOPProject.Calculations.Results
{
    public class ResultBase
    {
        public bool Success { get { return Errors.Count == 0; } }
        public List<string> Errors { get; set; } = [];
        public string ErrorsDisplay
        {
            get
            {
                if (Errors == null)
                {
                    return "";
                } 

                StringBuilder sb = new();
                Errors.ForEach((c) =>
                {
                    sb.AppendLine(c);
                });
                return sb.ToString();
            }
        }
    }
}

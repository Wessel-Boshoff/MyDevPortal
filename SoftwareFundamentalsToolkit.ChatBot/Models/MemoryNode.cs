namespace SoftwareFundamentalsToolkit.ChatBot.Models
{
    public class MemoryNode
    {
        public List<Association> Associations { get; set; } = [];
        public string Value { get; set; } = "";
        internal string GetMostAssured(string value) =>
            Associations.OrderByDescending(c => c.Assurance).First().Value;
    }
}

namespace SoftwareFundamentalsToolkit.ChatBot.Models
{
    public class Association
    {
        public int Assurance { get; set; }
        public string Value { get; set; } = "";

        internal void Assure()
        {
            Assurance++;
        }
    }
}

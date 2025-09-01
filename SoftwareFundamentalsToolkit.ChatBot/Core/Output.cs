namespace SoftwareFundamentalsToolkit.ChatBot.Core
{
    internal class Output
    {

        internal Output(Bot bot)
        {
            bot.OnConsoleMessage += Bot_OnConsoleMessage;
        }

        private void Bot_OnConsoleMessage(string message) =>
            Console.WriteLine(message);


    }
}

namespace ListProcessingApp.Models
{
    class ReverseCommand:Command
    {
        public ReverseCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}

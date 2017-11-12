namespace ListProcessingApp.Models
{
    class PrependCommand:Command
    {
        public PrependCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}

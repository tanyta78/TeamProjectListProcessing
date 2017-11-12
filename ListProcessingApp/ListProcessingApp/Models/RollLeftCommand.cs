namespace ListProcessingApp.Models
{
    class RollLeftCommand:Command
    {
        public RollLeftCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace ListProcessingApp.Models
{
    class RollRightCommand:Command
    {
        public RollRightCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace ListProcessingApp.Models
{
    class SortCommand:Command
    {
        public SortCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}

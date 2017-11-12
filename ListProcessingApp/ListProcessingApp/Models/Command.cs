namespace ListProcessingApp.Models
{
    using System;
    using System.IO;

    public abstract class Command
    {
        private string input;
        private string[] data;

        public Command(string input, string[] data)
        {
            this.Input = input;
            this.Data = data;
        }


        public string Input
        {
            get { return this.input; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //to do - change type of exception when created
                    throw new InvalidDataException();
                }
                this.input = value;
            }
        }

        public string[] Data
        {
            get { return this.data; }
            private set
            {
                if (value==null || value.Length==0 )
                {
                    //to do - change type of exception when created
                    throw new NullReferenceException();
                }
                this.data = value;
            }
        }

        public abstract void Execute();
    }
}

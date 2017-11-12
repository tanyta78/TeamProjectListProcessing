using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessingApp.Models
{
    class DeleteCommand:Command
    {
        public DeleteCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}

namespace ListProcessingApp.IO
{
    using System;
    using Models;

    public class CommandInterpreter
    {
        private string input;
        private string[] data;

        public void InterpredCommand(string input)
        {
            string[] data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string commandName = data[0].ToLower();

            try
            {
                Command cmd = this.ParseCommand(input, commandName, data);
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private Command ParseCommand(string input, string command, string[] data)
        {
            //to do change when all commands are created
            switch (command)
            {
                case "append":return  new AppendCommand(input,data);
                case "prepend": return new PrependCommand(input, data);
                case "reverse": return new ReverseCommand(input, data);
                case "insert": return new InsertCommand(input, data);
                case "delete": return new DeleteCommand(input, data);
                case "rollleft": return new RollLeftCommand(input, data);
                case "rollright": return new RollRightCommand(input, data);
                case "sort": return new SortCommand(input,
                    data);
                case "count":
                    return new CountCommand(input,
                        data);
                case "end":
                    return new EndCommand(input,
                        data);
                default:
                    throw new InvalidCommandException(input);


            }
            /*	append < string > – adds the specified string at the end of the list and prints the list(space separated).
                •	prepend < string > – inserts the specified string at the start of the list and prints the list.
                •	reverse – reorders the list items in reversed order(from its end to its start) and prints the list.
                •	insert < index > < string > – inserts the specified string at the specified position in the list and prints the list after that.
                o Positions are indexed from 0 to list_size -1.
                o In case of invalid index, print “Error: invalid index<index>”.
            •	delete<index> – deletes the string at the specified position in the list and prints the list.
                o Positions are indexed from 0 to list_size -1.
                o In case of invalid index, print “Error: invalid index<index>”.
            •	roll left – rolls the list on the left and prints the list. The first list item comes last.
                •	roll right – rolls the list on the right and prints the list. The last list item comes first.
                •	sort – sorts the list in alphabetical order and prints the list.
                •	count<string> – prints how many times the specified string occurs in the list (case sensitive). The command prints a single integer number as output.
                •	end – stops the execution of commands.Print “Finished” as command output.*/

        }
    }
}

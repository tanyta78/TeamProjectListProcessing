namespace ListProcessingApp.IO
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Models;

    public class CommandInterpreter
    {
        private List<string> list;
        
       public CommandInterpreter(List<string> list)
        {
            this.List = list;
        }

        public List<string> List
        {
            get { return this.list; }
            set { this.list = value; }
        }

        public void InterpredCommand(string input)
        {
            string[] cmdData = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string commandName = cmdData[0].ToLower();

            try
            {
                Command cmd = this.ParseCommand(this.list, commandName, cmdData);
                cmd.Execute();
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private Command ParseCommand(List<string> listForManipulation, string command, string[] cmdData)
        {
            //to do change when all commands are created
            switch (command)
            {
                case "append":return  new AppendCommand(listForManipulation,cmdData);
                case "prepend": return new PrependCommand(listForManipulation, cmdData);
                case "reverse": return new ReverseCommand(listForManipulation, cmdData);
                case "insert": return new InsertCommand(listForManipulation, cmdData);
                case "delete": return new DeleteCommand(listForManipulation, cmdData);
                case "rollleft": return new RollLeftCommand(listForManipulation, cmdData);
                case "rollright": return new RollRightCommand(listForManipulation, cmdData);
                case "sort": return new SortCommand(listForManipulation,
                    cmdData);
                case "count":
                    return new CountCommand(listForManipulation,
                        cmdData);
                case "end":
                    return new EndCommand(listForManipulation,
                        cmdData);
                default:
                    //to do - change when exceptions created
                    throw new InvalidDataException();


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

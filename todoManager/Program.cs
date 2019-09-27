using System;
using System.Collections.Generic;

namespace todoManager
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> validBaseCommands = new List<String>() { "addlist", "additem", "rmlist", "rmitem", "lslist", "lsitem", "ls", "done" };

            if (String.IsNullOrEmpty(args[0]))
	        {
                Console.WriteLine("NO ARGUMENTS PROVIDED");

	        }

        

            else if ( (validBaseCommands.Contains(args[0])))
            {
                //String listName = args[1];

                switch (args[0])
                {
                    case "addlist":
                        // connect to db
                        dbUtility.addListItemToDB("Server=LAPTOP-PMN2DM89;Database=db_todoApp;User Id=AppAccess;Password=dmcasucks;");

                        // insert new list with listName
                        break;

                    case "additem": // adds a list item to a given list
                       // connect to db
                       // find listID beloning to listName
                       // insert new record with args[2] as todoItemDescription and the listID from previous step as parentListID, auto assign other values
                        break;

                    case "rmlist": // removes an entire list and it's contents
                        // connect to db
                        //
                        break;

                    case "rmitem": //marks an item as removed
                        
                        break;

                    case "lslist": // fetches a given list's items, sorts by time created, applies numbers to them and displays a numbered list; prompts for input for add, remove, done
                        
                        break;

                    case "lsitem": //lists all items in a given list
                        
                        break;

                    case "ls": //lists all lists by name

                        break;

                    case "done": //lists all lists by name

                        break;

                    default:
                        break;
                }


            } //if ( !(validBaseCommands.Contains(args[0])))
            else
            {
                Console.WriteLine("INVALID ARGUMENT");
            }
           

            
            

            // for item in todo list write line

        }
    }
}
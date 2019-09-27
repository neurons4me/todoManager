using System;
using System.Collections.Generic;

namespace todoManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> validBaseCommands = new List<String>() { "addlist", "additem", "rmlist", "rmitem", "lslist", "lsitem", "ls" };

            if ( !(validBaseCommands.Contains(args[0])))
            {
                String listName = args[1];

                switch (args[0])
                {
                    case "addlist":
                        // connect to db
                        // insert new list with listName
                        break;

                    case "additem":
                       // connect to db
                       // find listID beloning to listName
                       // insert new record with args[2] as todoItemDescription and the listID from previous step as parentListID, auto assign other values
                        break;

                    case "rmlist":
                        // connect to db
                        //
                        break;

                    case "rmitem":
                        
                        break;

                    case "lslist":
                        
                        break;

                    case "lsitem":
                        
                        break;

                    case "ls":
                        //
                        // console printout of all list names
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
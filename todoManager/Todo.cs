using System;
using System.Collections.Generic;
using System.Text;

namespace todoManager
{
    public class clsTodoItem
    {
        public String itemDescription { get; set; }
        public Int16 itemID { get; set; }
        public DateTime creationTime { get; set; }
        public DateTime completionTime { get; set; }
        public Int16 isActive { get; set; }
        public Int16 parentListID { get; set; }


    }

    public class clsTodoList
    {
        //it should work by running a query and pulling list items from db then populating this list
        //public clsTodoItem[] listContents {get; set;}

        //public clsTodoItem[] populateTodoList(String pListID)
        //{
        //    // connect to db
        //    // run query for all items for listID
        //    // populate each item with values
        //    // append each item to the list
        //    // return list of todoItem objects
        
        //}

        public Int16 listID { get; set; }
        public clsTodoItem[] todoListContents { get; set; }




    }
}

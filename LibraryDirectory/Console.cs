using System;
using ClassLibrary;

namespace LibraryDirectory
{
    class Console
    {
        static void Main()
        {
            string storeObject = Console.ReadLine();
            string name = Convert.ToString(Console.ReadLine());
            string fio = Convert.ToString(Console.ReadLine());
            try
            {
                StoreObject s = StoreObjectCreate.Create(storeObject, name, fio);
                Console.WriteLine(s.Display);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class StoreObjectCreate
    {
        static public StoreObject Create(string objecttCode, string name, string fio)
        {
            StoreObject objectt = null;

            switch (objecttCode)
            {
                case "Book":
                case "B":
                    objectt = new Book(name, fio);
                    break;

                case "Puzzle":
                case "P":
                    objectt = new Puzzle(name, fio);
                    break;

                case "TableGame":
                case "T":
                    objectt = new TableGame(name, fio);
                    break;
            }
        }
    }
}
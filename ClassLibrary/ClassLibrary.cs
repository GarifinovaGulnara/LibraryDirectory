using System;

namespace ClassLibrary
{
    public class StoreObject
    {
        protected string name;
        protected string fio;

        public StoreObject(string newName, string newFIO)
        {
            name = newName;
            fio = newFIO;
        }

        public virtual void Display()
        {
        }
    }

    public class Book : StoreObject
    {
        protected string author;
        protected string illustrator;
        protected string publisher;
        protected DateTime year;
        public Book(string newName, string newFIO, string newAuthor, string newIllustrator, string newPublisher, DateTime newYear) : base(newName, newFIO)
        {
            author = newAuthor;
            illustrator = newIllustrator;
            publisher = newPublisher;
            year = newYear;
        }
        public override void Display()
        {
        }
    }

    public class Puzzle : StoreObject
    {
        protected int amountElements;
        protected string company;
        public Puzzle(string newName, string newFIO, int newAmountElements, string newCompany) : base(newName, newFIO)
        {
            amountElements = newAmountElements;
            company = newCompany;
        }
        public override void Display()
        {
        }
    }

    public class TableGame : StoreObject
    {
        protected string develop;
        protected string gameplay;
        protected string players;
        public TableGame(string newName, string newFIO, string newDevelop, string newGameplay, string newPlayers) : base(newName, newFIO)
        {
            develop = newDevelop;
            gameplay = newGameplay;
            players = newPlayers;
        }
        public override void Display()
        {
        }
    }
}
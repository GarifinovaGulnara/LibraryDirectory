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
            Console.WriteLine($"");
        }
    }

    public class Book : StoreObject
    {
        private string author;
        private string illustrator;
        private string publisher;
        private DateTime year;
        public Book(string newName, string newFIO, string newAuthor, string newIllustrator, string newPublisher, DateTime newYear) : base(newName, newFIO)
        {
            author = newAuthor;
            illustrator = newIllustrator;
            publisher = newPublisher;
            year = newYear;
        }
        public override void Display()
        {
            Console.WriteLine($"Книга {name}, автор: {author}, иллюстратор: {illustrator}, издательство: {publisher}, {year} года выпуска. Владелец {fio}");
        }
    }

    public class Puzzle : StoreObject
    {
        private int amountElements;
        private string company;
        public Puzzle(string newName, string newFIO, int newAmountElements, string newCompany) : base(newName, newFIO)
        {
            amountElements = newAmountElements;
            company = newCompany;
        }
        public override void Display()
        {
            Console.WriteLine($"Пазл {name} от {company}, кол-во элементов: {amountElements}. Владелец {fio}");
        }
    }

    public class TableGame : StoreObject
    {
        private string develop;
        private string gameplay;
        private string players;
        public TableGame(string newName, string newFIO, string newDevelop, string newGameplay, string newPlayers) : base(newName, newFIO)
        {
            develop = newDevelop;
            gameplay = newGameplay;
            players = newPlayers;
        }
        public override void Display()
        {
            Console.WriteLine($"Настольная игра {name} от {develop}. Суть игры: {gameplay}. Для {players} игроков. Владелец {fio}");
        }
    }
}
using EditionCatalog.BL.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace EditionCatalog.BL.Model 
{
    public class BookShelf : IEnumerable
    {
        private List<Edition> _editions;
        public int Count => _editions.Count;
        public double MaxPrice => _editions.Max(edition => edition.Price);
        public int MaxYear => _editions.Max(edition => edition.YearOfPublishing);

        public BookShelf()
        {
            _editions = new List<Edition>();
        }
        public void AddBook(string authorName,
                            string name,
                            int countOfPages,
                            int yearOfPublishing,
                            double price,
                            string genre)
        {
            _editions.Add(new Book(authorName, name, countOfPages, yearOfPublishing, price, genre));
        }

        public void AddMagazine(string authorName,
                                string name,
                                int countOfPages,
                                int yearOfPublishing,
                                double price,
                                int periodicalPerMonth,
                                int number)
        {
            _editions.Add(new Magazine(authorName, name, countOfPages, yearOfPublishing, price, periodicalPerMonth,
                number));
        }

        public void AddRange(params Edition[] editions)
        {
            _editions.AddRange(editions);
        }
        public void UpdateEdition(string[] editionData,int index)
        {
            _editions[index].Author.Name = editionData[0];
            _editions[index].Name = editionData[1];
            _editions[index].CountOfPages = int.Parse(editionData[2]);
            _editions[index].YearOfPublishing = int.Parse(editionData[3]);
            _editions[index].Price = double.Parse(editionData[4]);
            switch (_editions[index])
            {
                case Book _:

                    ((Book) _editions[index]).Genre = editionData[5];
                    break;
                case Magazine _:
                    ((Magazine) _editions[index]).PeriodicalPerMonth = int.Parse(editionData[5]);
                    ((Magazine)_editions[index]).Number = int.Parse(editionData[6]);
                    break;
            }
        }
        public Edition Last()
        {
            if (_editions.Count <= 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _editions[_editions.Count - 1];
        }
        public void RemoveAtIndex(int index)
        {
            if(index < 0)return;
            _editions.RemoveAt(index);
        }
        public void Load(string editionsInfo)
        {
            editionsInfo = editionsInfo.Replace("\r", "");
            List<string> editionDatas = new List<string>();
            editionDatas.AddRange(editionsInfo.Split('\n'));

            foreach (var editionData in editionDatas)
            {
                List<string> data = new List<string>();
                data.AddRange(editionData.Split('\t'));
                switch (data[0])
                {
                    case "1":
                        AddBook(data[1],
                            data[2],
                            int.Parse(data[3]),
                            int.Parse(data[4]),
                            double.Parse(data[5]),
                            data[6]);
                        break;
                    case "0":
                        AddMagazine(data[1],
                            data[2],
                            int.Parse(data[3]),
                            int.Parse(data[4]),
                            double.Parse(data[5]),
                            int.Parse(data[6]),
                            int.Parse(data[7]));
                        break;
                }
            }

            List<string> vs = _editions.Select(edition => edition.ToString()).ToList();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable) _editions).GetEnumerator();
        }

        public void Clear()
        {
            _editions = new List<Edition>();
        }

        public Edition this[int index]
        {
            get => _editions[index];
            set => _editions[index] = value;
        }

        public Dictionary<string, int> GroupBy()
        {
            Dictionary<string,int> authorAndHisBookCount = new Dictionary<string, int>();
            var authors = new List<string>();
            foreach (var t in _editions.Where(t => !authors.Contains(t.Author.Name)))
            {
                authors.Add(t.Author.Name);
            } 
            List<int> counts = authors.Select(t => _editions.Count(e => e.Author.Name == t)).ToList();
            for (int i = 0; i < authors.Count; i++)
            {
                authorAndHisBookCount.Add(authors[i],counts[i]);
            }
            return authorAndHisBookCount;
        }

        public void MakeDiscount(int value)
        {
            if(value >=100 || value < 0)return;
            foreach (var edition in _editions)
            {
                edition.Price = Math.Round(edition.Price*(100 - value)/100,2);
            }
        }
    }
}

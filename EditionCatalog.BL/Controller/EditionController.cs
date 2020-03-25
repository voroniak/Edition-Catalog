using EditionCatalog.BL.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditionCatalog.BL.Controller
{
    public class EditionController: IEnumerable
    {
        private List<Edition> _editions;
        public int Count => _editions.Count;
        public EditionController()
        {
            _editions = new List<Edition>();
        }
        public void AddEdition(Edition edition)
        {

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
            _editions.Add(new Magazine(authorName, name, countOfPages, yearOfPublishing, price, periodicalPerMonth, number));
        }

        public Edition Last()
        {
            if (_editions.Count <= 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _editions[_editions.Count - 1];
        }

        //public List<string> LoadEditions(string editionsInfo)
        //{
        //    Regex regex = new Regex(@"(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(\w+)\n");
        //    Match magazineMatch = new Regex(@"(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(\w+)\n").Match(editionsInfo);
        //    MatchCollection matchCollection = regex.Matches(editionsInfo);
        //    //= new Regex("(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\n").Match(editionsInfo);

        //    List<string> info = new List<string>();
        //    for (int i = 0; i < matchCollection.Count; i++)
        //    {
        //        Match bookMatch = new Regex("(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\t(.*?)\n").Match(editionsInfo);
        //        if (bookMatch.Length != 0)
        //        {
        //            if (bookMatch.Groups[1].Value.ToString() == "1")
        //            {
        //                AddBook(bookMatch.Groups[2].Value.ToString(),
        //                        bookMatch.Groups[3].Value.ToString(),
        //                        Int32.Parse(bookMatch.Groups[4].Value),
        //                        Int32.Parse(bookMatch.Groups[5].Value),
        //                        Decimal.Parse(bookMatch.Groups[7].Value),
        //                        bookMatch.Groups[7].Value.ToString());
        //            }

        //        }

        //        //string todelete = editionsInfo.Substring(bookMatch.Index, bookMatch.Length);
        //        editionsInfo = editionsInfo.Remove(bookMatch.Index, bookMatch.Length);
        //    }

        //    return info;
        //}
        public void Load(string editionsInfo)
        {
            editionsInfo = editionsInfo.Replace("\r", "");
            List<string> info = new List<string>();
               info.AddRange(editionsInfo.Split('\n'));
            
            for(int i = 0; i < info.Count; i++)
            {
                List<string> edinfo = new List<string>();
                edinfo.AddRange(info[i].Split('\t'));
                if (edinfo[0] == "1")
                {
                   
                    AddBook(edinfo[1],
                            edinfo[2],
                            Int32.Parse(edinfo[3]),
                            Int32.Parse(edinfo[4]),
                            Double.Parse(edinfo[5]), 
                            edinfo[6]);
                }
               else if (edinfo[0] == "0")
                {
                    AddMagazine(edinfo[1],
                                edinfo[2],
                                Int32.Parse(edinfo[3]),
                                Int32.Parse(edinfo[4]),
                                Double.Parse(edinfo[5]),
                                Int32.Parse(edinfo[6]),
                                Int32.Parse(edinfo[7]));
                }
            }
            List<string> vs = new List<string>();
            foreach (var edition in _editions)
            {
                vs.Add(edition.ToString());
            }
           
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_editions).GetEnumerator();
        }
        public void Clear()
        {
            _editions = new List<Edition>();
        }
    }
}

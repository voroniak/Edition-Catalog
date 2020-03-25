using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditionCatalog.BL.Model
{
   public abstract class Edition : IComparable
    {
        public Author Author { get; protected set; }
        public string Name { get; protected set; }
        public int CountOfPages { get; protected set; }
        public int YearOfPublishing { get; protected set; }
        public double Price { get; protected set; }
        public Edition(string authorName,
                       string name,
                       int countOfPages,
                       int yearOfPublishing,
                       double price)
        {
            #region checking the conditions
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name can not be null or empty.", nameof(name));
            }
            if(countOfPages <= 0)
            {
                throw new ArgumentException("Count of count of pages can not be less or equal than zero.", nameof(countOfPages));
            }
            if(yearOfPublishing > DateTime.Now.Year)
            {
                throw new ArgumentException("", nameof(yearOfPublishing));

            }
            if (price < 0)
            {
                throw new ArgumentException("Price of can not be less than zero.", nameof(price));
            }
            #endregion
            Author = new Author(authorName);
            Name = name;
            CountOfPages = countOfPages;
            YearOfPublishing = yearOfPublishing;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Author}\t{Name}\t{CountOfPages}\t{YearOfPublishing}\t";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

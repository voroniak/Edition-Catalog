using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditionCatalog.BL.Model
{
    public class Book : Edition
    {
        public string Genre { get; set; }
        public Book(string authorName,
                    string name,
                    int countOfPages,
                    int yearOfPublishing,
                    double price,
                    string genre) : base(authorName,
                                         name,
                                         countOfPages,
                                         yearOfPublishing,
                                         price)
        {
            #region checking the conditions
            if (string.IsNullOrWhiteSpace(genre))
            {
                throw new ArgumentNullException(nameof(genre), "Genre can not be null or empty.");
            }
            #endregion
            Genre = genre;

        }
        public override string ToString()
        {
            return base.ToString() + $"{Price}\t{Genre}\t";
        }
    }
}

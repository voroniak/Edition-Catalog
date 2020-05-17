using System;
namespace EditionCatalog.BL.Model
{
   public class Magazine : Edition
    {
        public int PeriodicalPerMonth { get; set; }
        public int Number { get;  set; }
        public Magazine(string authorName,
                        string name,
                        int countOfPages,
                        int yearOfPublishing,
                        double price,
                        int periodicalPerMonth,
                        int number) : base(authorName,
                                         name,
                                         countOfPages,
                                         yearOfPublishing,
                                         price)
        {
            #region checking the conditions
            if (periodicalPerMonth < 0)
            {
                throw new ArgumentException("Periodical per month of can not be less than zero.", nameof(periodicalPerMonth));
            }
            if(number < 0)
            {
                throw new ArgumentNullException("Magazine number can not be null or empty.", nameof(number));
            }
            #endregion
            PeriodicalPerMonth = periodicalPerMonth;
            Number = number;

        }
        public override string ToString()
        {
            return base.ToString() + $"{PeriodicalPerMonth}\t{Number}";
        }
    }
}

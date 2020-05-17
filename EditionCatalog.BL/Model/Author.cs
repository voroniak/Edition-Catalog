using System;
namespace EditionCatalog.BL.Model
{
   public class Author
    {
        public string Name { get; set; }
        public Author (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Name can not be null or empty.");
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

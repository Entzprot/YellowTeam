using System.Collections.Generic;

namespace BibliographyParser
{
    /// <summary>
    /// Parses text containing bibliographic data into a collection of bibliography <see cref="Item"/> objects.
    /// </summary>
    public interface IBibliographyParser
    {
        List<Item> Parse(string data);
    }
}

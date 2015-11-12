using System.Linq;

namespace BibliographyParser
{
    /// <summary>
    /// Default <see cref="IItemChecker"/> implementation for when no custom checker is specified.
    /// When all fields contained by the item are valid, the item is valid.
    /// </summary>
    class DefaultItemChecker : IItemChecker
    {
        readonly FieldValidator _validator = new FieldValidator();

        public bool Validate(Item item)
        {
            return item.Fields.All(field => _validator.IsFieldValid(field.Value, field.Key));
        }

    }
}

using System.Collections.Generic;

namespace BibliographyParser
{
    /// <summary>
    /// Class which validates fields associated to bibliographic items.
    /// </summary>
    public class FieldValidator
    {
        readonly Dictionary<Item.FieldType, IFieldChecker> _checkers;
        readonly IFieldChecker _defaultChecker = new DefaultFieldChecker();

        /// <summary>
        /// Constructs a new <see cref="FieldValidator"/>.
        /// </summary>
        /// <param name="checkers">A dictionary of field checkers. If not specified, <see cref="DefaultFieldChecker"/> is used.</param>
        public FieldValidator(Dictionary<Item.FieldType, IFieldChecker> checkers = null)
        {
            _checkers = checkers ?? new Dictionary<Item.FieldType, IFieldChecker>();
        }

        /// <summary>
        /// Checks whether or not a given field is valid.
        /// </summary>
        /// <param name="field">The field data to validate.</param>
        /// <param name="type">The field type.</param>
        /// <returns>returns true if the field is valid; false otherwise.</returns>
        public bool IsFieldValid(string field, Item.FieldType type)
        {
            return _checkers.ContainsKey(type) ? _checkers[type].Validate(field) : _defaultChecker.Validate(field);
        }
    }
}
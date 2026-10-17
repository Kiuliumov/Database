
using Database.Core.Enums;

namespace Database.Core.Models
{
    public sealed class ColumnDefinition
    {
        public string Name { get; }

        public ColumnType Type { get; }

        public string? DefaultValue { get; }

        public ColumnDefinition(
            string name,
            ColumnType type,
            string? defaultValue = null)
        {
            ValidateName(name);

            Name = name;
            Type = type;
            DefaultValue = defaultValue;
        }

        private static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(
                    "Column name cannot be empty.",
                    nameof(name));
            }
        }
    }
}

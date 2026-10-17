using System;
using Database.Core.Enums;

namespace Database.Core.Models;

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
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(
                "Column name is required.");

        Name = name;
        Type = type;
        DefaultValue = defaultValue;
    }
}
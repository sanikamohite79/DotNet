namespace NullableApp;
class DatabaseReader
{
    // Nullable fields
    public int? numericValue = null; // int? is shorthand for Nullable<int>
    public bool? boolValue = true;

    // Nullable return types
    public int? GetIntFromDatabase()   { return numericValue; }
    public bool? GetBoolFromDatabase()  { return boolValue; }
}


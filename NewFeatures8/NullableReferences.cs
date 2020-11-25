#nullable enable
using System;
namespace NewFeatures8
{
  class ShowNullableReferences
  {
    void FNullable(string? s) => Console.Write(s.Length);//warning
    void FNullForgivingOperator(string? s) => Console.Write(s!.Length);
    string? GetStringValue() { return null; }

    void F()
    {
      string result = GetStringValue(); //warning
    }

  }
}


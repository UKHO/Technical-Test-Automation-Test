namespace UKHO.Navigation.Books.API.Validators;

internal static class IsbnRegEx
{
    internal static readonly string Value = @"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$";
}
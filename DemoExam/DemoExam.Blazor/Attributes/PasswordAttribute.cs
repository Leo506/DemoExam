using System.ComponentModel.DataAnnotations;

namespace DemoExam.Blazor.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class PasswordAttribute : ValidationAttribute
{
    public override string FormatErrorMessage(string name)
    {
        return "Слишком короткий пароль";
    }

    public override bool IsValid(object? value)
    {
        if (value is not string password)
            return false;

        return password.Length >= 8;
    }
}
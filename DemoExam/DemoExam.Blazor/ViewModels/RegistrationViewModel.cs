using System.ComponentModel.DataAnnotations;
using DemoExam.Blazor.Attributes;

namespace DemoExam.Blazor.ViewModels;

public class RegistrationViewModel
{
    [Required(ErrorMessage = "Поле обязательно")] public string UserName { get; set; } = default!;
    [Required(ErrorMessage = "Поле обязательно")] public string UserSurname { get; set; } = default!;
    [Required(ErrorMessage = "Поле обязательно")] public string UserPatronymic { get; set; } = default!;
    [Required(ErrorMessage = "Поле обязательно")] public string Login { get; set; } = default!;
    
    [Required(ErrorMessage = "Поле обязательно")]
    [Password]
    public string Password { get; set; } = default!;
}
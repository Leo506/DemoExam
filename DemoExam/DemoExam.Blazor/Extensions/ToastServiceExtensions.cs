using Arbus.Network.Exceptions;
using BlazorBootstrap;
using DemoExam.Domain.Exceptions;

namespace DemoExam.Blazor.Extensions;

public static class ToastServiceExtensions
{
    public static void FromException(this ToastService toastService, Exception exception)
    {
        if (exception is NetworkException networkException)
            toastService.ToastForNetworkException(networkException);
        else
            toastService.ToastUnexpectedException();
    }

    private static void ToastForNetworkException(this ToastService toastService, NetworkException networkException)
    {
        var message = networkException.Message switch
        {
            NotEnoughProductsInStockException.MessageText => "Недостаточно товаров на складе",
            _ => "При обработке запроса произошла ошибка. Повторите попытку позже"
        };
        toastService.Notify(new ToastMessage()
        {
            Type = ToastType.Danger,
            IconName = IconName.EmojiFrown,
            Title = "Ошибка",
            Message = message
        });
    }

    public static void ToastUnexpectedException(this ToastService toastService)
    {
        toastService.Notify(new ToastMessage()
        {
            
            Type = ToastType.Danger,
            IconName = IconName.EmojiFrown,
            Title = "Ошибка",
            Message = "Произошла неожиданная ошибка, но мы ее уже чиним"
        });
    }
}

using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Alquileres;

public static class AlquilerErrors
{
    public static Error NotFound = new Error(
        "Alquiler.Found",
        "El Alquiler con el Id especificado no fue encontrado"
    );

    public static Error Overlap= new Error(
        "Arquiler.Overlap",
        "El alquiler esta siendo tomando por 2 o mas cliente al mismo tiempo en la misma fecha"
    );

    public static Error NotReserverd = new Error(
        "Alquiler.NotReserverd",
        "El alquiler no esta reservado"
    );
    
    public static Error NotConfirmado = new Error(
        "Alquiler.NotConfirmed",
        "El alquiler no esta Confirmado"
    );

    public static Error AlreadyStarted = new Error(
        "Alquiler.AlreadyStarted",
        "El alquiler ya ha comenzado"
    );
}

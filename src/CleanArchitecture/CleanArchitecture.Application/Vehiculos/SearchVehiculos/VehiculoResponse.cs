

namespace CleanArchitecture.Application.Vehiculos.SearchVehiculos;

public sealed class VehiculoResponse
{
    Guid Id { get; init; }
    public string? Model { get; init; }

    public string? Vin { get; init; }

    public decimal Precio { get; init; }
    public string? TipoMoneda { get; init; }

    public DireccionResponse? Direccion { get; set; }
}

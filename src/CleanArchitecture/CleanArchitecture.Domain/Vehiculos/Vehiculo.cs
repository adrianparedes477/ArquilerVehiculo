

using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehiculos;

public sealed class Vehiculo : Entity
{
    public Vehiculo(
        Guid id,
        Modelo modelo,
        Vin vin,
        Moneda precio,
        Moneda mantenimiento,
        DateTime? fechaUltimaArquiler,
        List<Accesorio> accesorios,
        Direccion? direccion
        ) : base(id)
    {
        Modelo = modelo;
        Vin = vin;
        Precio = precio;
        Mantenimiento = mantenimiento;
        FechaUltimaArquiler = fechaUltimaArquiler;
        Accesorios = accesorios;
        Direccion = direccion;

    } //se llama al padre y genera el id

    //Modelos enriquesido basado en object value
    public Modelo? Modelo { get;private set; }

    public Vin? Vin { get;private set; }

    public Direccion? Direccion { get;private set; }

    public Moneda? Precio {get; private set;}

    public Moneda? Mantenimiento {get; private set;}

    public DateTime? FechaUltimaArquiler {get; private set;}

    public List<Accesorio> Accesorios {get; private set;} = new();

}

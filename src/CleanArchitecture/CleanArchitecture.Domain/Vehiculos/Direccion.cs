

namespace CleanArchitecture.Domain.Vehiculos;

public record  Direccion( // object value -> es unico x valor no tiene un id se representan por valores
    string Pais,
    string Departamento,
    string Provincia,
    string Cuidad,
    string Calle
);

//No puede aver en el mundo real Dos direcciones iguales

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces;

public interface IUniOnWork
{
    ICiudad Ciudades { get; }
    IDepartamento Departamentos { get; }
    IPais Paises { get; }
    Task<int> SaveAsync();

}

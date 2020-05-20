using System;

namespace Biblioteca
{
    public interface IDado : IEquatable<IDado>
    {
        int Codigo { get; set; }
        new bool Equals(IDado obj);
    }
}

using System;
using System.Collections.Generic;

namespace Models.Contracts
{
    public interface EnderecoDao
    {
        bool insira(Endereco e);
        List<Endereco> consulte();
        Endereco consulte(int id);
        bool altere(Endereco e);
        bool exclua(Endereco e);
    }
}
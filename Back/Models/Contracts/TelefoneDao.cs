using System;
using System.Collections.Generic;

namespace Models.Contracts
{
    public interface TelefoneDao
    {
        bool insira(Telefone t);
        List<Telefone> consulte();
        Telefone consulte(int id);
        bool altere(Telefone t);
        bool exclua(Telefone t);
        TelefoneTipo tipo(Telefone t);
    }
}
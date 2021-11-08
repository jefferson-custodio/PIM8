using System;
using System.Collections.Generic;

namespace Models.Contracts
{
    public interface TelefoneTipoDao
    {
        bool insira(TelefoneTipo tt);
        List<TelefoneTipo> consulte();
        TelefoneTipo consulte(int id);
        bool altere(TelefoneTipo tt);
        bool exclua(TelefoneTipo tt);
    }
}
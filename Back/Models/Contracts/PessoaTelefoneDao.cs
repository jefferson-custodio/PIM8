using System;
using System.Collections.Generic;

namespace Models.Contracts
{
    public interface PessoaTelefoneDao
    {
        bool associar(Pessoa p, Telefone t);
        bool desassociar(Pessoa p, Telefone t);
        List<Telefone> telefones_da_pessoa(Pessoa p);
    }
}
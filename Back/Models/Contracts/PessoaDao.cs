using System;
using System.Collections.Generic;

namespace Models.Contracts
{
    public interface PessoaDao
    {
        bool insira(Pessoa p);
        List<Pessoa> consulte();
        Pessoa consulte(int id);
        bool altere(Pessoa p);
        bool exclua(Pessoa p);
        Endereco endereco(Pessoa p);
        List<Telefone> telefones(Pessoa p);
    }
}
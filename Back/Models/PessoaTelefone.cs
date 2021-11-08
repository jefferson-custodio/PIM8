using System;
using Models;
using Models.Contracts;
using DataBase;
using System.Collections.Generic;

namespace Models
{
    public class PessoaTelefone : DB, PessoaTelefoneDao
    {
        private static string TABELA = "PESSOA_TELEFONE";
        private static string CAMPOS = "ID_PESSOA, ID_TELEFONE";
        private int ID_PESSOA {get;set;}
        private int ID_TELEFONE {get;set;}

        bool PessoaTelefoneDao.associar(Pessoa p, Telefone t)
        {
           this.runQuery("INSERT INTO " + TABELA + " (ID_PESSOA, ID_TELEFONE)" + 
                " VALUES (" + p.ID + ", " + t.ID + ")");
            return true;
        }
        
        bool PessoaTelefoneDao.desassociar(Pessoa p, Telefone t)
        {
           this.runQuery("DELETE FROM " + TABELA + " WHERE ID_PESSOA = " + p.ID + " AND ID_TELEFONE = " + t.ID );
            return true;
        }

        List<Telefone> PessoaTelefoneDao.telefones_da_pessoa(Pessoa p)
        {
            List<Telefone> telefones = new List<Telefone>();

            var reader = this.runSelectQuery("SELECT ID_TELEFONE FROM " + TABELA + " WHERE ID_PESSOA = " + p.ID);
            while (reader.Read())
            {
                Telefone telefone = new Telefone();
                var tel = (telefone as TelefoneDao).consulte(reader.GetInt32(0));
                telefones.Add(tel);
            }
            reader.Close();
            return telefones;
        }

    }
}
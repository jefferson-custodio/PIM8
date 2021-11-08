using System;
using Models;
using Models.Contracts;
using DataBase;
using System.Collections.Generic;

namespace Models
{
    public class Telefone : DB, TelefoneDao
    {
        private static string TABELA = "TELEFONE";
        private static string CAMPOS = "ID, NUMERO, DDO, TIPO";
        public int ID {get;set;}
        public int NUMERO {get;set;}
        public int DDO {get;set;}
        public int TIPO {get;set;}

        bool TelefoneDao.altere(Telefone t)
        {
            this.runQuery("UPDATE " + TABELA + " SET NUMERO = " + t.NUMERO + ", DDO = " + t.DDO + ", TIPO = " + 
                t.TIPO + " WHERE ID = " + t.ID);
            return true;
        }

        List<Telefone> TelefoneDao.consulte()
        {
            List<Telefone> pessoas = new List<Telefone>();

            var reader = this.runSelectQuery("SELECT " + CAMPOS + " FROM " + TABELA);
            while (reader.Read())
            {
                Telefone pessoa = new Telefone();
                pessoa.ID = reader.GetInt32(0);
                pessoa.NUMERO = reader.GetInt32(1);
                pessoa.DDO = reader.GetInt32(2);
                pessoa.TIPO = reader.GetInt32(3);
                pessoas.Add(pessoa);
            }
            reader.Close();
            return pessoas;
        }

        Telefone TelefoneDao.consulte(int id)
        {
           Telefone pessoa = new Telefone();

            var reader = this.runSelectQuery("SELECT "+CAMPOS+" FROM " + TABELA + " WHERE ID = '" + id + "'");
            while (reader.Read())
            {
                pessoa.ID = reader.GetInt32(0);
                pessoa.NUMERO = reader.GetInt32(1);
                pessoa.DDO = reader.GetInt32(2);
                pessoa.TIPO = reader.GetInt32(3);
            }
            reader.Close();
            return pessoa;
        }

        bool TelefoneDao.exclua(Telefone t)
        {
            this.runQuery("DELETE FROM " + TABELA + " WHERE ID = " + t.ID);
            return true;
        }

        bool TelefoneDao.insira(Telefone t)
        {
            this.runQuery("INSERT INTO " + TABELA + " (NUMERO, DDO, TIPO)" + 
                " VALUES (" + t.NUMERO + ", " + t.DDO + ", "+t.TIPO+")");
            return true;
        }

        TelefoneTipo TelefoneDao.tipo(Telefone t)
        {
            TelefoneTipo tipo = new TelefoneTipo();
            return (tipo as TelefoneTipoDao).consulte(t.TIPO);
        }

    }
}
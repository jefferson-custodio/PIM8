using System;
using Models.Contracts;
using DataBase;
using System.Collections.Generic;

namespace Models
{
    public class Endereco : DB, EnderecoDao
    {
        private static string TABELA = "ENDERECO";
        private static string CAMPOS = "ID, LOGRADOURO, NUMERO, CEP, BAIRRO, CIDADE, ESTADO";
        public int ID {get;set;}
        public string LOGRADOURO {get;set;}
        public int NUMERO {get;set;}
        public int CEP {get;set;}
        public string BAIRRO {get;set;}
        public string CIDADE {get;set;}
        public string ESTADO {get;set;}

        bool EnderecoDao.altere(Endereco e)
        {
            this.runQuery("UPDATE " + TABELA + " SET LOGRADOURO = '" + e.LOGRADOURO + "', NUMERO = " + e.NUMERO + ", CEP = " + 
                e.CEP + ", BAIRRO = '"+e.BAIRRO+"', CIDADE = '"+e.CIDADE+"', ESTADO = '"+e.ESTADO+"' WHERE ID = " + e.ID);
            return true;
        }

        List<Endereco> EnderecoDao.consulte()
        {
            List<Endereco> enderecos = new List<Endereco>();

            var reader = this.runSelectQuery("SELECT "+CAMPOS+" FROM " + TABELA);
            while (reader.Read())
            {
                Endereco endereco = new Endereco();
                endereco.ID = reader.GetInt32(0);
                endereco.LOGRADOURO = reader.GetString(1);
                endereco.NUMERO = reader.GetInt32(2);
                endereco.CEP = reader.GetInt32(3);
                endereco.BAIRRO = reader.GetString(4);
                endereco.CIDADE = reader.GetString(5);
                endereco.ESTADO = reader.GetString(6);
                enderecos.Add(endereco);
            }
            reader.Close();
            return enderecos;
        }

        Endereco EnderecoDao.consulte(int id)
        {
            Endereco endereco = new Endereco();
            var reader = this.runSelectQuery("SELECT "+CAMPOS+" FROM " + TABELA + " WHERE ID = " + id);
            while (reader.Read())
            {
                 endereco.ID = reader.GetInt32(0);
                endereco.LOGRADOURO = reader.GetString(1);
                endereco.NUMERO = reader.GetInt32(2);
                endereco.CEP = reader.GetInt32(3);
                endereco.BAIRRO = reader.GetString(4);
                endereco.CIDADE = reader.GetString(5);
                endereco.ESTADO = reader.GetString(6);
            }
            reader.Close();
            return endereco;
        }

         bool EnderecoDao.exclua(Endereco e)
        {
            this.runQuery("DELETE FROM " + TABELA + " WHERE ID = " + e.ID);
            return true;
        }

         bool EnderecoDao.insira(Endereco e)
        {
            this.runQuery("INSERT INTO " + TABELA + " (LOGRADOURO, NUMERO, CEP, BAIRRO, CIDADE, ESTADO)" + 
                " VALUES ('" + e.LOGRADOURO + "', " + e.NUMERO + ", "+e.CEP+", '"+BAIRRO+"', '"+CIDADE+"', '"+ESTADO+"')");
            return true;
        }

    }
}
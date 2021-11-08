using System;
using Models;
using Models.Contracts;
using DataBase;
using System.Collections.Generic;

namespace Models
{
    public class Pessoa : DB, PessoaDao
    {
        private static string TABELA = "PESSOA";
        private static string CAMPOS = "ID, NOME, CPF, ENDERECO";
        public int ID {get;set;}
        public string NOME {get;set;}
        public long CPF {get;set;}
        public int ENDERECO {get;set;}

        bool PessoaDao.altere(Pessoa p)
        {
            this.runQuery("UPDATE " + TABELA + " SET NOME = '" + p.NOME + "', CPF = " + p.CPF + ", ENDERECO = " + 
                p.ENDERECO + " WHERE ID = " + p.ID);
            return true;
        }

        List<Pessoa> PessoaDao.consulte()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            var reader = this.runSelectQuery("SELECT " + CAMPOS + " FROM " + TABELA);
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.ID = reader.GetInt32(0);
                pessoa.NOME = reader.GetString(1);
                pessoa.CPF = reader.GetInt64(2);
                pessoa.ENDERECO = reader.GetInt32(3);
                pessoas.Add(pessoa);
            }
            reader.Close();
            return pessoas;
        }

        Pessoa PessoaDao.consulte(int id)
        {
           Pessoa pessoa = new Pessoa();

            var reader = this.runSelectQuery("SELECT "+CAMPOS+" FROM " + TABELA + " WHERE ID = '" + id + "'");
            while (reader.Read())
            {
                pessoa.ID = reader.GetInt32(0);
                pessoa.NOME = reader.GetString(1);
                pessoa.CPF = reader.GetInt64(2);
                pessoa.ENDERECO = reader.GetInt32(3);
            }
            reader.Close();
            return pessoa;
        }

        bool PessoaDao.exclua(Pessoa p)
        {
            this.runQuery("DELETE FROM " + TABELA + " WHERE ID = " + p.ID);
            return true;
        }

        bool PessoaDao.insira(Pessoa p)
        {
            this.runQuery("INSERT INTO " + TABELA + " (NOME, CPF, ENDERECO)" + 
                " VALUES ('" + p.NOME + "', " + p.CPF + ", "+p.ENDERECO+")");
            return true;
        }

        Endereco PessoaDao.endereco(Pessoa p)
        {
            Endereco endereco = new Endereco();
            return (endereco as EnderecoDao).consulte(p.ENDERECO);
        }
        List<Telefone> PessoaDao.telefones(Pessoa p)
        {
            PessoaTelefone pessoa_telefone = new PessoaTelefone();
            return (pessoa_telefone as PessoaTelefoneDao).telefones_da_pessoa(p);
        }

    }
}
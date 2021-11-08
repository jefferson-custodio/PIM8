using System;
using Models.Contracts;
using DataBase;
using System.Collections.Generic;

namespace Models
{
    public class TelefoneTipo : DB, TelefoneTipoDao
    {
        private static string TABELA = "TELEFONE_TIPO";
        private static string CAMPOS = "ID, TIPO";
        public int ID {get;set;}
        public string TIPO {get;set;}

        bool TelefoneTipoDao.altere(TelefoneTipo tt)
        {
            this.runQuery("UPDATE " + TABELA + " SET TIPO = '" + tt.TIPO +"' WHERE ID = " + tt.ID);
            return true;
        }

        List<TelefoneTipo> TelefoneTipoDao.consulte()
        {
            List<TelefoneTipo> telefone_tipos = new List<TelefoneTipo>();

            var reader = this.runSelectQuery("SELECT "+CAMPOS+" FROM " + TABELA);
            while (reader.Read())
            {
                TelefoneTipo telefone_tipo = new TelefoneTipo();
                telefone_tipo.ID = reader.GetInt32(0);
                telefone_tipo.TIPO = reader.GetString(1);
                telefone_tipos.Add(telefone_tipo);
            }
            reader.Close();
            return telefone_tipos;
        }

        TelefoneTipo TelefoneTipoDao.consulte(int id)
        {
            TelefoneTipo telefone_tipo = new TelefoneTipo();
            var reader = this.runSelectQuery("SELECT "+CAMPOS+" FROM " + TABELA + " WHERE ID = " + id);
            while (reader.Read())
            {
                telefone_tipo.ID = reader.GetInt32(0);
                telefone_tipo.TIPO = reader.GetString(1);
            }
            reader.Close();
            return telefone_tipo;
        }

         bool TelefoneTipoDao.exclua(TelefoneTipo tt)
        {
            this.runQuery("DELETE FROM " + TABELA + " WHERE ID = " + tt.ID);
            return true;
        }

         bool TelefoneTipoDao.insira(TelefoneTipo tt)
        {
            this.runQuery("INSERT INTO " + TABELA + " (TIPO)" + 
                " VALUES ('" + tt.TIPO + "')");
            return true;
        }

    }
}
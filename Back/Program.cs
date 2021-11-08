using System;
using DataBase;
using Models;
using Models.Contracts;

namespace Back
{
    class Program
    {
        static void Main()
        {
            var endereco = new Endereco();
            endereco.LOGRADOURO = "Rua 1";
            endereco.NUMERO = 10;
            endereco.CEP = 09332900;
            endereco.BAIRRO = "Primeiro";
            endereco.CIDADE = "Mauá";
            endereco.ESTADO = "São Paulo";
            (endereco as EnderecoDao).insira(endereco);

            var enderecos = (endereco as EnderecoDao).consulte();

            var pessoa = new Pessoa();
            pessoa.CPF = 86465337002;
            pessoa.NOME = "JEFFERSON";
            pessoa.ENDERECO = enderecos[0].ID;
            (pessoa as PessoaDao).insira(pessoa);
            var pessoas = (pessoa as PessoaDao).consulte();

            var telefone_tipo = new TelefoneTipo();
            telefone_tipo.TIPO = "FIXO";
            (telefone_tipo as TelefoneTipoDao).insira(telefone_tipo);
            var telefone_tipos = (telefone_tipo as TelefoneTipoDao).consulte();

            var telefone = new Telefone();
            telefone.DDO = 11;
            telefone.NUMERO = 43544242;
            telefone.TIPO = telefone_tipos[0].ID;
            (telefone as TelefoneDao).insira(telefone);
            var telefones = (telefone as TelefoneDao).consulte();

            var pessoa_telefone = new PessoaTelefone();
            (pessoa_telefone as PessoaTelefoneDao).associar(pessoas[0], telefones[0]);
        }


    }
}

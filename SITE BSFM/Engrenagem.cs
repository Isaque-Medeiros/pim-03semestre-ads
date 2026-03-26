using System;
using System.Collections.Generic;
using ClassesBSFM;

namespace BSFM
{
    public class UsuarioService
    {
        private CalcularNutricional _calculadora = new CalularNutricional();

        public Usuario CriarNovoUsuario(string nome, int idade, string email, double peso, double altura, string sexo, string tipoPessoa, bool aceitou, List<string> intolerancias)
        {
            Usuario novoUser = new Usuario
            {
                Nome = nome,
                Idade = idade,
                Email = email,
                Peso = peso,
                Altura = altura,
                Sexo = sexo,
                TipoPessoa = tipoPessoa,
                AceitouTermos = aceitou,
                DataAceite = DateTime.Now,
                VersaoTermos = "v1.0",
                Intolerância = intolerancias
            };

            _calculadora.RegistrarCalculos(novoUser);

            return novoUser;

        }

        public void SalvarNoBancoDeDados(Usuario usuario)
        {
            // Aqui você implementaria a lógica para salvar o usuário no banco de dados
            // Pode ser um banco SQL, NoSQL, ou até mesmo um arquivo local
            Console.WriteLine($"Usuário {usuario.Nome} salvo no banco de dados com IMC: {usuario.IMC}, TMB: {usuario.TMB}, Gasto Total: {usuario.GastoTotal}");
        }
    }
}
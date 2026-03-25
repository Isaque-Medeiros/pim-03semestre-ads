namespace BSFM_Classes
{
    class  Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public bool AceitouTermos { get; set; }        // Guarda True ou False
        public DateTime DataAceite { get; set; }     // Guarda O DIA e HORA do aceite (importante para LGPD)
        public string VersaoTermos { get; set; }    // Se um dia os termos mudarem, você sabe qual ele assinou
        public string Sexo { get; set; } // Masculino, Feminino
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string TipoPessoa { get; set; } // Sedentário, Ativo, Muito Ativo
        public List<string> Intolerancia { get; set; } // Glúten, Lactose, Frutos do Mar, etc.
        public double IMC { get; set; }
        public double TMB { get; set; }
        public double GastoTotal { get; set; }
        public Usuario()        {
            Intolerância = new List<string>();
            AceitouTermos = false; // Por padrão, o usuário não aceitou os termos
            DataAceite = DateTime.MinValue; // Por padrão, a data de aceite é inválida
            VersaoTermos = string.Empty; // Por padrão, a versão dos termos é vazia
        }
        
        
   }

    class CalcularNutricional
    {
        public double CalcularIMC(double peso, double altura)
        {
            if (altura <= 0) return 0;
            return peso / (altura * altura);
        }

        public double CalcularTMB(string sexo, double peso, double alturaMetros, int idade)
        {
            double alturaCm = alturaMetros * 100;

            if (sexo.ToLower() == "masculino")
            {
                // Fórmula Revisada de Harris-Benedict para Homens
                return 88.362 + (13.397 * peso) + (4.799 * alturaCm) - (5.677 * idade);
            }
            else
            {
                // Fórmula Revisada de Harris-Benedict para Mulheres
                return 447.593 + (9.247 * peso) + (3.098 * alturaCm) - (4.330 * idade);
            }
        }

        public double CalcularGastoTotal(string nivelAtividade, double tmb)
        {
            // Usamos ToLower para aceitar "Sedentário", "sedentário", "SEDENTARIO"
            string nivel = nivelAtividade.ToLower();

            if (nivel == "sedentario" || nivel == "sedentário")
            {
                return tmb * 1.2;
            }   

            if (nivel == "ativo")
            {
                return tmb * 1.55;
            }

             if (nivel == "muito ativo")
            {
                return tmb * 1.725;
            }

            return tmb; // Caso não identifique o nível, retorna a TMB base
        }
        // Funções para registrar calculos nos atributos do usuário

        public void RegistrarCalculos(Usuario usuario)
        {
            usuario.IMC = CalcularIMC(usuario.Peso, usuario.Altura);
            usuario.TMB = CalcularTMB(usuario.Sexo, usuario.Peso, usuario.Altura, usuario.Idade);
            usuario.GastoTotal = CalcularGastoTotal(usuario.TipoPessoa, usuario.TMB);
        }

    }

   class Refeição
   {
        public string NomeRefeição { get; set; }
        public string Categoria { get; set; } // Ex: Café da Manhã, Almoço, Jantar, Lanche
        public List<string> Ingredientes { get; set; }
        public double Calorias { get; set; }
        public double Proteínas { get; set; }
        public double Carboidratos { get; set; }
        public double Gorduras { get; set; }
   }

    class Comida
    {
        public string NomeComida { get; set; }
        public string Categoria { get; set; } // Ex: Frutas, Legumes, Carnes, etc.
        public double Calorias { get; set; }
        public double Proteínas { get; set; }
        public double Carboidratos { get; set; }
        public double Gorduras { get; set; }
    }

    class CronogramaAlimentar
    {
        public Usuario Usuario { get; set; }
        public List<Refeição> Refeições { get; set; }
        public string Planos { get; set; }

        public CronogramaAlimentar()
        {
            Refeições = new List<Refeição>();
        }
    }

    class Hospital

    {
        public string NomeHospital { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
    }

}

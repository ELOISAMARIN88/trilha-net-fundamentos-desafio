namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

       
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            
        }

        public void AdicionarVeiculo()
        {
            


            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            
            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"Veículo com placa {placa} já está estacionado no Estacionamento.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com placa {placa} adicionado no Estacionamento");
            }



        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            
           
            
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                 int horas = int.Parse(Console.ReadLine());

                
                decimal valorTotal = 0; 
                
                valorTotal =precoInicial + (precoPorHora * horas);

                

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               
                for (int i = 0; i < veiculos.Count; i++)
        {
            var veiculo = veiculos[i];
            Console.WriteLine($"Veículo {i + 1}: Placa: {veiculos}");
            
        }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

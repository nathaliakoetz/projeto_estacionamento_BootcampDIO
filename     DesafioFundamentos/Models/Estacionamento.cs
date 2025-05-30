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
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            string placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper()); // Adiciona a placa em maiúsculas para padronizar
            Console.WriteLine($"Veículo com placa '{placa.ToUpper()}' adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                int horas = 0;
                while (!int.TryParse(Console.ReadLine(), out horas) || horas <= 0)
                {
                    Console.WriteLine("Quantidade de horas inválida. Por favor, digite um número inteiro positivo:");
                }

                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Remover a placa digitada da lista de veículos
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal:N2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realizar um laço de repetição, exibindo os veículos estacionados
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"Placa: {veiculos[i]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
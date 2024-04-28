namespace ControleMedicamentos.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Bem-vindo {Environment.MachineName}");

            TelaMedicameto novaTelaMedicamento = new();
            TelaPaciente novaTelaPaciente = new();
            TelaRequisicao novaTelaRequisicao = new(novaTelaMedicamento, novaTelaPaciente);

            while (true)
            {
                int escolha = Menu.MenuPrincipal();
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        novaTelaMedicamento.ExibeMenuMedicamento();

                        break;

                    case 2:
                        Console.Clear();
                        novaTelaPaciente.ExibeMenuPaciente();
                        break;

                    case 3:
                        Console.Clear();
                        novaTelaRequisicao.ExibeMenuRequisicao();
                        break;

                    case 4:
                        Console.WriteLine("Pressione qualquer tecla para sair");
                        Console.ReadLine();

                        return;
                }
            }


        }
    }
}

namespace ControleMedicamentos.ConsoleApp;

public static class Menu
{
    public static int MenuMedicamento()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Gestão de Medicamentos");
        Console.ResetColor();

        Console.WriteLine("Por favor escolha a opcao desejada \n" +
         "1- Cadastrar Medicamento \n" +
         "2- Listagem de Medicamentos \n" +
         "3- Edicao de Medicamentos \n" +
         "4- Remocao de Medicamentos \n" +
         "5- Sair para o Menu Principal");
        int escolha = Convert.ToInt32(Console.ReadLine());
        return escolha;
    }

    public static int MenuPaciente()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Gestão de Pacientes");
        Console.ResetColor();

        Console.WriteLine("Por favor escolha a opcao desejada \n" +
         "1- Cadastrar Paciente \n" +
         "2- Listagem de Pacientes \n" +
         "3- Edicao de Pacientes \n" +
         "4- Remocao de Pacientes \n" +
         "5- Sair o Menu Principal");
        int escolha = Convert.ToInt32(Console.ReadLine());
        return escolha;
    }

    public static int MenuRequisicao()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Gestão de Requisições");
        Console.ResetColor();

        Console.WriteLine("Por favor escolha a opcao desejada \n" +
         "1- Cadastrar Requisicao \n" +
         "2- Listagem de Requisicoes \n" +
         "3- Edicao de Requisicoes \n" +
         "4- Remocao de Requisicoes \n" +
         "5- Sair para o Menu Principal");
        int escolha = Convert.ToInt32(Console.ReadLine());
        return escolha;
    }

    public static int MenuPrincipal()
    {
        Console.WriteLine("Por favor escolha a opcao desejada \n" +
         "1- Gerenciar Medicamentos \n" +
         "2- Gerenciar Pacientes \n" +
         "3- Gerenciar Requisicoes \n" +
         "4- Sair");
        int escolha = Convert.ToInt32(Console.ReadLine());
        return escolha;
    }
}

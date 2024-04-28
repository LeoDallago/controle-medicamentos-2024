namespace ControleMedicamentos.ConsoleApp;
public class TelaMedicameto
{
    Repositorio novoRepositorio = new();
    
    public void ExibeMenuMedicamento()
    {

        int escolha = Menu.MenuMedicamento();

        switch (escolha)
        {

            case 1:
                Console.Clear();
                Medicamento novoMedicamento = ObterMedicamento();
                string[] erros = novoMedicamento.Validar();

                novoRepositorio.CadastraMedicamento(novoMedicamento);


                if (erros.Length > 0)
                {
                    
                    ApresentaErros(erros);
                    return;

                }
                MensagemSucesso.ConteudoMensagem("Cadastro realizado com sucesso!", ConsoleColor.Green);

                ExibeMenuMedicamento();
                break;

            case 2:
                Console.Clear();
                ExibeMedicamento();

                ExibeMenuMedicamento();
                break;

            case 3:
                Console.Clear();
                ExibeMedicamento();
                Console.WriteLine("Escolha o ID do medicamento a ser EDITADO");
                int id = Convert.ToInt32(Console.ReadLine());
                Medicamento medicamentoEditado = ObterMedicamento();
                novoRepositorio.EditarMedicamento(medicamentoEditado, id);
                MensagemSucesso.ConteudoMensagem("Informações alteradas com sucesso!", ConsoleColor.Yellow);

                ExibeMenuMedicamento();
                break;

            case 4:
                Console.Clear();
                ExibeMedicamento();
                Console.WriteLine("Escolha o ID do medicamento a ser REMOVIDO");
                id = Convert.ToInt32(Console.ReadLine());
                novoRepositorio.DeletaMedicamento(id);
                MensagemSucesso.ConteudoMensagem("Informações removidas com sucesso!", ConsoleColor.Red);

                ExibeMenuMedicamento();
                break;
        }
    }

    private void ApresentaErros(string[] erros)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        for (int i = 0; i < erros.Length; i++)
        {
            Console.WriteLine(erros[i]);
        }

        Console.ReadLine();
        Console.ResetColor();
    }

    public Medicamento ObterMedicamento()
    {
        Console.WriteLine("Informe o NOME do medicamento");
        string nome = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Informe a DESCRICAO do medicamento");
        string descricao = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Informe a QUANTIDADE diponivel");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        return new Medicamento(nome,descricao,quantidade);
    }

    public void ExibeMedicamento()
    {
        Console.WriteLine(
           "{0, -10} | {1,-15} | {2,-15} | {3, -10}",
           "ID", "Nome", "Descricao", "Quantidade"
           );

        Medicamento[] estoque = novoRepositorio.SelecionaEstoque(); 

        for (int i = 0; i < estoque.Length; i++)
        {
            if (estoque[i] != null)
                Console.WriteLine(
                    "{0, -10} | {1,-15} | {2,-15} | {3, -10}",
                    estoque[i].id, estoque[i].nome, estoque[i].descricao, estoque[i].quantidade
                    );
        }
    }

}
namespace ControleMedicamentos.ConsoleApp;

public static class MensagemSucesso
{
    public static void ConteudoMensagem(string mensagem, ConsoleColor cor)
    {
        Console.ForegroundColor = cor;
        Console.WriteLine(mensagem);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
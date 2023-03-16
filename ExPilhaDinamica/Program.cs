using ExPilhaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro pilha = new PilhaLivro();
        Livro livro = new Livro("Poeira em alto mar", "Pestana", 2025);

        pilha.Push(livro);
        pilha.Push(new Livro("A volta dos que não foram", "Andre", 2022));

        pilha.PrintPilha();

        pilha.Pop();
        pilha.PrintPilha();
        pilha.Pop();
        pilha.PrintPilha();
        pilha.Pop();

        pilha.Push(new Livro("As tranças de um careca", "Papini", 2023));
        pilha.PrintPilha();
    }
}
using System.Diagnostics;

int result = Fibonacci(6);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    // Escreve no console de depuração que o método Fibonacci foi acessado
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    
    // Escreve no console de depuração qual número da sequência de Fibonacci está sendo calculado
    Debug.WriteLine($"We are looking for the {n}th number");
    
    // Inicializa os dois primeiros números da sequência de Fibonacci
    int n1 = 0;
    int n2 = 1;
    int sum;

    // Loop para calcular o enésimo número de Fibonacci
    for (int i = 2; i <= n; i++)
    {
        // Calcula a soma dos dois últimos números
        sum = n1 + n2;
        
        // Atualiza n1 e n2 para os próximos números na sequência
        n1 = n2;
        n2 = sum;
        
        // Escreve no console de depuração se a soma for igual a 1
        Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
    }
    
    // Verifica se o valor retornado é 5, caso contrário, gera um aviso
    Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");
    
    // Retorna n1 se n for 0, caso contrário, retorna n2
    return n == 0 ? n1 : n2;
}

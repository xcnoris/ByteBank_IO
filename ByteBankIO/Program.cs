using ByteBankIO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDEBytesLido = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; // 1KB


        // Caso o retorno seja 0, que dizer que nao existe mais bytes para ler no arquivo txt
        while (numeroDEBytesLido != 0)
        {
            // Ler o arquivo txt, 1024 bytes por vez
            numeroDEBytesLido = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }
        

        
        Console.ReadLine();
    }
    static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();

        //Descodificando os bytes do arquivo
        var texto = utf8.GetString(buffer);
        Console.Write(texto);
        /*
        foreach (var meyByte in buffer)
        {
            Console.Write(meyByte);
            Console.Write("");
        }
        */
    }
}
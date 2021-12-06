using System;

namespace TemplateMethodPattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tMP4\n");
            VideoPlayer arquivoVideo = new VideoMP4();
            arquivoVideo.CarregarArquivo();
            arquivoVideo.DecodeVideoFormato();
            arquivoVideo.IniciarExecucao();

            Console.WriteLine("\tMKV\n");
            arquivoVideo = new VideoMKV();
            arquivoVideo.CarregarArquivo();
            arquivoVideo.DecodeVideoFormato();
            arquivoVideo.IniciarExecucao();
        }
    }
}

using System;

namespace TemplateMethodPattern
{
    // Template Method
    public abstract class VideoPlayer
    {
        public void ExecutarVideo()
        {
            CarregarArquivo();
            DecodeVideoFormato();
            IniciarExecucao();
        }

        #region Comportamentos Sobrescritos

        public abstract void DecodeVideoFormato();

        #endregion

        #region Comportamentos Padrão
        public void CarregarArquivo() =>
            Console.WriteLine("Arquivo de vídeo carregando");

        public void IniciarExecucao() =>
            Console.WriteLine("Iniciou a execução do vídeo \n");

        #endregion
    }
}

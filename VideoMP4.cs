using System;

namespace TemplateMethodPattern
{
    public class VideoMP4 : VideoPlayer
    {
        public override void DecodeVideoFormato() => 
            Console.WriteLine("O vídeo esta sendo processado com o decoder MP4");
    }
}

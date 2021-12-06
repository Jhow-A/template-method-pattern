using System;

namespace TemplateMethodPattern
{
    public class VideoMKV : VideoPlayer
    {
        public override void DecodeVideoFormato() =>
            Console.WriteLine("O vídeo esta sendo processado com o decoder MKV");
    }
}

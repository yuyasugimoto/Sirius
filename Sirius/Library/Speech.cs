using System;
using System.IO;
using Google.Cloud.TextToSpeech.V1;

namespace Sirius.Library
{
    class Speech
    {

        public void TextSpeech(string text)
        {

            TextToSpeechClient client = TextToSpeechClient.Create();

            SynthesisInput input = new SynthesisInput
            {
                Text = text
            };

            VoiceSelectionParams voice = new VoiceSelectionParams
            {
                LanguageCode = "ja-JP",
                SsmlGender = SsmlVoiceGender.Female
            };

            AudioConfig config = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Linear16,

            };

            var response = client.SynthesizeSpeech(
                input, 
                voice,
                config
            );

            using (var memoryStream = new MemoryStream(response.AudioContent, true))
            {
                var player = new System.Media.SoundPlayer(memoryStream);
                Console.Write("Play");
                player.Play();
            }

        }

    }
}

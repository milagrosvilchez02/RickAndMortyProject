using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyProject
{
    class InfoProcessor
    {
        public async Task<bool> LoadCharacter(string characterId = "")
        {
            try
            {
                int id = int.Parse(characterId);
                if (id > 0 && id < 672)
                {
                    var json = await GetCharacter(characterId);
                    CharacterModel characterModel = JsonConvert.DeserializeObject<CharacterModel>(json);
                    Console.WriteLine(@$"Character name: {characterModel.Name},
Character id: {characterModel.Id}
Character status: {characterModel.Status}.");
                }
                else
                {
                    Console.WriteLine("Error");
                }
                return true;
            }
            catch
            {
                Console.WriteLine("Error");
                return false;
            }
        }
        private async Task<string> GetCharacter(string characterId)
        {
            HttpClient client = new HttpClient() { BaseAddress = new Uri("https://rickandmortyapi.com/api/character/") };
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await client.GetAsync(characterId);
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            return jsonString;
        }

        
    }
}

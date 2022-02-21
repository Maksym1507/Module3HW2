using System.IO;
using Module3HW2.Interfaces;
using Module3HW2.Models;
using Newtonsoft.Json;

namespace Module3HW2.Services
{
    public class AlphabetConfigurationService : IAlphabetConfigurationService
    {
        public void SerializeAlphabets(Alphabet alphabet, string jsonFile = @"C:\Users\Maksym\Desktop\Module3HW2\Module3HW2\config.json")
        {
            string dictionaryJsonFile = JsonConvert.SerializeObject(alphabet);
            File.WriteAllText(jsonFile, dictionaryJsonFile);
        }

        public Alphabet DeserializeAlphabets(string jsonFile)
        {
            var configFile = File.ReadAllText(jsonFile);
            return JsonConvert.DeserializeObject<Alphabet>(configFile);
        }
    }
}

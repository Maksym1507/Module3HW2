using Module3HW2.Models;

namespace Module3HW2.Interfaces
{
    public interface IAlphabetConfigurationService
    {
        public void SerializeAlphabets(Alphabet alphabet, string jsonFile);

        public Alphabet DeserializeAlphabets(string jsonFile);
    }
}

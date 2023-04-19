using Newtonsoft.Json;

namespace a1qa_L2_UserInterface.Utilities
{
    public static class FileReader
    {
        public static T ReadJsonData<T>(string path) => JsonConvert.DeserializeObject<T>(ReadFile(path))!;

        private static string ReadFile(string path)
        {
            using StreamReader sr = new(path);
            return sr.ReadToEnd();
        }
    }
}
using System.Text.Json;

namespace Comparsion.Helpers
{
    static public class SerializedStorage
    {
        public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (FileStream stream = new FileStream(filePath, append ? FileMode.Append : FileMode.Create))
            {
                JsonSerializer.Serialize(stream, objectToWrite);
            }       
        }

        public static T? ReadFromJsonFile<T>(string filePath)
        {
            var data = JsonSerializer.Deserialize<T>(File.ReadAllBytes(filePath));
            return data;
        }
    }
}

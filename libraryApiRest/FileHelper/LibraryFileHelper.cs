namespace libraryApiRest.FileHelper;
using System.Text.Json;

public class LibraryFileHelper
{
    private string Serializer<T>(List<T> objList)
    {
        return JsonSerializer.Serialize(objList);
    }

    public void WriteAndSerialize<T>(string path, List<T> animals)
    {
        string json = Serializer(animals);
        File.WriteAllText(path, json);
    }

    public List<T> ReadAndDeserialize<T>(string path)
    {

        if (!File.Exists(path))
        {
            File.Create(path).Close();
        }
        

        string json = File.ReadAllText(path);
        if (json == string.Empty)
        {
            return new List<T>();
        }
        else
        {
            List<T> objList = JsonSerializer.Deserialize<List<T>>(json);
            return objList;
        }
    }
}

using Newtonsoft.Json;
using System.Text;

namespace DiscordBotTutorialExampleProject.Config
{
    public class ConfigJsonReader
    {
        //Declare our Token properties of this class
        public string discordToken { get; set; }
        
        public async Task ReadJSON() //This method must be run asynchronously
        {
            //Initialise a StreamReader
            using StreamReader sr = new("config.json", new UTF8Encoding(false));

            //Read the JSON file
            string json = await sr.ReadToEndAsync();

            //Deserialize into a JSONStruct object
            JSONStruct obj = JsonConvert.DeserializeObject<JSONStruct>(json);

            //Set the properties
            this.discordToken = obj.token;
        }
    }

    internal sealed class JSONStruct
    {
        public string token { get; set; }
    }
}

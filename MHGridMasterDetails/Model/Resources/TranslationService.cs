using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Model.Resources
{
    public class TranslationService
    {
        public static string getTranslate(string Code, string Lang = "en")
        {
            try
            {
                string JsonFile;
                if (Lang == null)
                    Lang = "en";

                JsonFile = Directory.GetCurrentDirectory() + "/Resources/" + Lang + ".json";
                if (File.Exists(JsonFile))
                {
                    using (StreamReader r = new StreamReader(JsonFile))
                    {
                        string json = r.ReadToEnd();
                        var data = (JObject)JsonConvert.DeserializeObject(json);
                        string result = data[Code].Value<string>();
                        if (result != null)
                            return result;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Code;
        }
    }
}


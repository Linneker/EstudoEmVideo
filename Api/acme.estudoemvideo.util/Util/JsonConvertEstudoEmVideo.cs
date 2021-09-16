using acme.estudoemvideo.domain.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.Util
{
    public class JsonConvertEstudoEmVideo<Entity> where Entity : class
    {
        public static string Serialize(Entity alunoEscolas)
        {

            var settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(alunoEscolas, settings);
            return json;
        }
        public static Task<string> SerializeAsync(Entity alunoEscolas)
        {

            var settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                Formatting = Formatting.Indented
            };

            Task<string> json = Task.Factory.StartNew(() => JsonConvert.SerializeObject(alunoEscolas, settings));
            return json;
        }

        public static Task<Entity> DescerializeAsync(string alunoEscolas)
        {

            var settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                Formatting = Formatting.Indented
            };

            Task<Entity> json = Task.Factory.StartNew(() => JsonConvert.DeserializeObject<Entity>(alunoEscolas, settings));
            return json;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using ClubeLeitura.ConsoleApp.ModuloCaixa;
using Newtonsoft.Json;


namespace ClubeLeitura.ConsoleApp.Compartilhado
{
    public class Serialization
    {

        public void SerializarUmObjeto(List<EntidadeBase> entidade)
        {

            using (StreamWriter stream = new StreamWriter(Path.Combine(@"G:\Projetos_C#\Clone_Repositories\Leitura_Refatorado_Thiago_3.0\ClubeLeitura.ConsoleApp\ArquivosJson", "caixa.json")))
            {

                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, entidade);

            }
        }

        /*
        public Caixa DeserilizarUmObjeto()
        {

            using (StreamReader stream = new StreamReader(@"G:\Projetos_C#\Clone_Repositories\Leitura_Refatorado_Thiago_3.0\ClubeLeitura.ConsoleApp\ArquivosJson\caixa.json"))
            {
                string jsonString = stream.ReadToEnd();
                //caixa = JsonConvert.DeserializeObject<Caixa>(jsonString);
            }


          //  return caixa;

        }
        */
    }

}



    


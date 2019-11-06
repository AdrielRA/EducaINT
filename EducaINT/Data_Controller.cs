using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducaINT
{
    public class Data_Controller
    {
        private static string path;
        public static string path_data, path_images, path_perguntas;
        
        private static List<Pergunta> perguntas = null;

        public static void Start_Controller()
        {
            path = Application.StartupPath + "\\";
            path_images = path + "files\\imgs\\";
            path_data = path + "files\\data\\";
            path_perguntas = path_data + "perguntas.json";

            perguntas = Load_Perguntas();
            if (perguntas == null) perguntas = new List<Pergunta>();
        }

        private static List<Pergunta> Load_Perguntas()
        {
            if (File.Exists(path_perguntas))
            {
                using (StreamReader r = new StreamReader(path_perguntas))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Pergunta>>(json);
                }
            }
            return null;
        }

        public static void Add_Pergunta(Pergunta pergunta)
        {
            if (!perguntas.Contains(pergunta)) { perguntas.Add(pergunta); Save_Pergunta_To_Storage(); }
            Save_Pergunta_To_Storage();
        }
        public static void Remove_Pergunta(Pergunta pergunta)
        {
            perguntas.Remove(pergunta);
            Save_Pergunta_To_Storage();
        }
        public static void Save_Pergunta_To_Storage()
        {
            if (Create_Diretory(path_data))
            {
                File.WriteAllText(path_perguntas, JsonConvert.SerializeObject(perguntas));
            }
        }

        public static bool Create_Diretory(string path)
        {
            try
            {
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                return true;
            }
            catch { return false; }
        }
        public static bool File_Exists(string path) { return File.Exists(path); }
    }
}

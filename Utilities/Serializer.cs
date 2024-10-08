﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ProyectoOpenTk.Utilities
{
    public class Serializer
    {
        public static void save<T>(T o, string filename)
        {
            try
            {
                string json = JsonConvert.SerializeObject(o);
                using (StreamWriter fileWriter = new StreamWriter(filename))
                {
                    fileWriter.WriteLine(json);
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception($"Error al cargar el archivo: {ex.Message}");
            }
        }

        public static T Load<T>(string filepath)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(filepath))
                {
                    return JsonConvert.DeserializeObject<T>(fileReader.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception($"Error al cargar el archivo: {ex.Message}");
            }
        }
    }
}

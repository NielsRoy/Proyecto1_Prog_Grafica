using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using ProyectoOpenTk.Estructura3D;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ProyectoOpenTk.Utilities
{
    public class Serializer
    {
        public static void SaveJson<T>(T o, string filename)
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

        public static T LoadJson<T>(string filepath)
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

        public static Objeto LoadObj(string filepath)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(filepath))
                {
                    string texto = fileReader.ReadToEnd();
                    Objeto objeto = DeserializeObj(texto);
                    return objeto;
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception($"Error al cargar el archivo: {ex.Message}");
            }
        }

        private static Objeto DeserializeObj(string texto)
        {
            string nombresPartesRegex = @"o\s.*";
            string partesRegex = @"((usemtl\s.+\n)?f(\s\d+(\/\d+)*)+\n?)+";
            string verticesRegex = @"v(\s-?\d+(\.\d+)?){3}";
            MatchCollection nombresPartesMc = Regex.Matches(texto, nombresPartesRegex);
            MatchCollection partesMc = Regex.Matches(texto, partesRegex);
            MatchCollection verticesMc = Regex.Matches(texto, verticesRegex);
            Dictionary<string, Parte> partes = new Dictionary<string, Parte>();
            for (int i = 0; i < partesMc.Count; i++)
            {
                string nombreParte = nombresPartesMc[i].Value.Split(' ')[1]; //todo: arreglar
                Parte p = GetParte(partesMc[i].Value, verticesMc);
                partes.Add(nombreParte, p);    
            }
            Objeto objeto = new Objeto(0, 0, 0);
            objeto.partes = partes;
            return objeto;
        }
    
        private static Parte GetParte(string parteTxt, MatchCollection verticesMc)
        {
            string poligonosRegex = "f.+";
            MatchCollection poligonosMc = Regex.Matches(parteTxt, poligonosRegex);
            List<Poligono> poligonos = new List<Poligono>();
            foreach (Match poligonoTxt in poligonosMc)
            {
                Poligono p = GetPoligono(poligonoTxt.Value, verticesMc);
                poligonos.Add(p);
            }
            Parte parte = new Parte(0, 0, 0);
            parte.poligonos = poligonos;
            return parte;
        }

        private static Poligono GetPoligono(string poligonoTxt, MatchCollection verticesMc)
        {
            string indicesVerticeRegex = @"\s\d+";
            MatchCollection indicesVerticesMc = Regex.Matches(poligonoTxt, indicesVerticeRegex);
            List<Vertice> vertices = new List<Vertice>();
            foreach (Match indiceVerticeTxt in indicesVerticesMc)
            {
                int index = int.Parse(indiceVerticeTxt.Value);
                Vertice v = GetVertice(verticesMc[index - 1].Value);
                vertices.Add(v);
            }
            Poligono poligono = new Poligono();
            poligono.vertices = vertices;
            return poligono;
        }

        private static Vertice GetVertice(string verticeTxt)
        {
            string coordenadasRegex = @"-?\d+(\.?\d+)?";
            MatchCollection coordenadasMc = Regex.Matches(verticeTxt, coordenadasRegex);
            float x = float.Parse(coordenadasMc[0].Value, CultureInfo.InvariantCulture);
            float y = float.Parse(coordenadasMc[1].Value, CultureInfo.InvariantCulture);
            float z = float.Parse(coordenadasMc[2].Value, CultureInfo.InvariantCulture);
            return new Vertice(x, y, z);
        }
    }
}

using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    //static void Main()
    //{
    //    // Define la duración de la animación (en segundos)
    //    const float animationDuration = 5f;

    //    // Define las posiciones de inicio y fin
    //    float startX = 0f;
    //    float endX = 100f;

    //    // Crea un temporizador para medir el tiempo transcurrido
    //    Stopwatch stopwatch = new Stopwatch();
    //    stopwatch.Start();

    //    // Bucle de la animación
    //    while (stopwatch.Elapsed.TotalSeconds < animationDuration)
    //    {
    //        // Calcula el progreso de la animación como porcentaje (0 a 1)
    //        float elapsedTime = (float)stopwatch.Elapsed.TotalSeconds;
    //        float progress = elapsedTime / animationDuration;

    //        // Interpola la posición del cubo usando el progreso
    //        float currentX = Lerp(startX, endX, progress);

    //        // Renderiza la animación (esto es solo un ejemplo de renderización en consola)
    //        Console.Clear();
    //        Console.SetCursorPosition((int)currentX, 0);
    //        Console.Write("■");  // Dibujar el cubo

    //        // Simula una tasa de FPS de alrededor de 60 FPS
    //        Thread.Sleep(16); // Aproximadamente 16 ms entre frames (1000ms / 60 FPS)
    //    }

    //    // Asegúrate de que el cubo llegue exactamente al final
    //    Console.Clear();
    //    Console.SetCursorPosition((int)endX, 0);
    //    Console.Write("■");

    //    Console.WriteLine("\nAnimación completada.");
    //}

    // Función de interpolación lineal
    static float Lerp(float start, float end, float progress)
    {
        return start + (end - start) * progress;
    }
}

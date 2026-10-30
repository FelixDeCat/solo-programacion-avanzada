using System.Collections.Generic;
using UnityEngine;

public static class RandomTools
{
    public static void Shuffle<T>(this T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int indexR = Random.Range(i, array.Length);

            //swap
            T aux = array[i];
            array[i] = array[indexR];
            array[indexR] = aux;
        }
    }
    public static void Shuffle<T>(this List<T> array)
    {
        for (int i = 0; i < array.Count; i++)
        {
            int indexR = Random.Range(i, array.Count);

            //swap
            T aux = array[i];
            array[i] = array[indexR];
            array[indexR] = aux;
        }
    }

    public static float[,] GenerateNoiseMap(int width, int height, int seed)
    {
        float[,] noiseMap = new float[width, height];

        System.Random random = new System.Random(seed);

        float offsetX = random.Next(-100000, 100000);
        float offsetY = random.Next(-100000, 100000);

        float scale = 20f;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float sampleX = (x / scale) + offsetX;
                float sampleY = (y / scale) + offsetY;

                noiseMap[x, y] = Mathf.PerlinNoise(sampleX, sampleY);
            }
        }

        return noiseMap;
    }
}

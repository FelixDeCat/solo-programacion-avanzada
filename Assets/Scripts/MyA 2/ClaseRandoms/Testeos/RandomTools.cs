using System.Collections.Generic;
using UnityEngine;

namespace RandomsCustom
{
    public static class MyRandomTools
    {
        public static void Shuffle<T>(this T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = Random.Range(i, array.Length);

                T auxiliar = array[i];
                array[i] = array[j];
                array[j] = auxiliar;
            }
        }
        public static void Shuffle<T>(this List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int j = Random.Range(i, list.Count);

                T auxiliar = list[i];
                list[i] = list[j];
                list[j] = auxiliar;
            }
        }

        public static System.Random CreateRandomBySeed(int _seed)
        {
            return new System.Random(_seed);
        }

        public static float[,] GenerateNoiseMap(int width, int height, int seed)
        {
            float[,] noiseMap = new float[width, height];

            float scale = 20f;

            System.Random random = new System.Random(seed);

            float offsetX = random.Next(-100000, 100000);
            float offsetY = random.Next(-100000, 100000);

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

}

using System;

public class BubbltSort
{
    public float[] BubbleSort(float[] arg0)
    {
        float[] Bubble = arg0;
        float temp;

        for (int i = 0; i < Bubble.Length-1; i++)
        {
            for (int j = 0; j < Bubble.Length - i - 1; j++)
            {
                if (Bubble[j] > Bubble[j + 1])
                {
                    temp = Bubble[j + 1];
                    Bubble[j] = Bubble[j] + 1;
                    Bubble[i] = temp;
                }
            }
        }
        return Bubble;
    }
}
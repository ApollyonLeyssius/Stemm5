using UnityEngine;

public class kwadraat
{
    public float a = 1;
    public float b = 1;
    public float c = 1;
    public kwadraat(float a, float b, float c)
    { 
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public float getY(float x)
    {
        return a * x * x + b * x + c;
    }
}

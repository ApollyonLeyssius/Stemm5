using UnityEngine;

public class parabool : MonoBehaviour
{
    [SerializeField] point point;
    int NumberOfPoints = 11;
    Vector2 minScreem, maxScreen;

    kwadraat f;

    [SerializeField] public float a = 1;
    [SerializeField] public float b = 2;
    [SerializeField] public float c = -3;

    void Start()
    {
        minScreem = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        float dx = (maxScreen.x - minScreem.x) / NumberOfPoints;

        f = new kwadraat(1, 2, 3);

        for (int i = 0; i <= NumberOfPoints; i++)
        {
            float x = minScreem.x + i * dx;
            float y = f.getY(x);
            point copyOfpoint = Instantiate(point);
            copyOfpoint.transform.position = new Vector3(x, y, 0);
        
        }
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

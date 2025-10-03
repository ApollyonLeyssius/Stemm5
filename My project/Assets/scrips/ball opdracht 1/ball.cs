using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] Vector3 velocity = new Vector3(1, 1, 0);
    [SerializeField] Vector3 acceleration = new Vector3(0, -1, 0);
    Vector2 minScreem, maxScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minScreem = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

    }

    // Update is called once per frame
    void Update()
    {
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        Vector3 temp = transform.position;

        if (temp.y > maxScreen.y)
        {
            velocity.y = -Mathf.Abs(velocity.y);
        }
        if (temp.y < minScreem.y)
        {
            velocity.y = Mathf.Abs(velocity.y);
        }
        if (temp.x > maxScreen.x)
        {
            velocity.x = -Mathf.Abs(velocity.x);
        }
        if (temp.x < minScreem.x)
        {
            velocity.x = Mathf.Abs(velocity.x);
        }

    }
}

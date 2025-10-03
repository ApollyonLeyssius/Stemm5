using UnityEngine;

public class Jumpingblock : MonoBehaviour
{
    [SerializeField] Transform Block;
    [SerializeField] Vector3 accelerationBegin;
    [SerializeField] Vector3 velocityBegin;

    Vector3 velocity;
    Vector3 acceleration;
    [SerializeField] float t = 0;

    float yMin;

    enum State
    { 
        onGround,
        airborne
    }

    State myState = State.onGround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        velocity = Vector3.zero;
        acceleration = Vector3.zero;

        yMin = Block.position.y;
        myState = State.onGround;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == State.onGround)
        {
            if (Input.GetMouseButtonDown(0))
            {
                myState = State.airborne;
                t = 0;
                velocity = velocityBegin;
                acceleration = accelerationBegin;
            }
        }
        if (myState == State.airborne) 
        {   
            t += Time.deltaTime;
            if (Block.position.y < yMin)
            { 
                myState = State.onGround;
                velocity = Vector3.zero;   
                acceleration = Vector3.zero;
                Block.position = new Vector3(Block.position.x, yMin, 0);
            }
        }
        velocity += acceleration * Time.deltaTime;
        Block.position += velocity * Time.deltaTime;
    }
}

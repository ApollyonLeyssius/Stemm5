using UnityEngine;

public class endlessrunner : MonoBehaviour
{
    [SerializeField] float vBegin = 10;

    [SerializeField] float gavity = -10f;

    Animator animator;
    Vector3 velocity = Vector3.zero;
    Vector3 acceleration = Vector3.zero;

    float t;
    float tmax = 10;

    enum State
    {
        Running,
        Jumping
    }
    State myState = State.Running;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == State.Running)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.Play("Running Jump");
                velocity = new Vector3(0, vBegin, 0);
                gavity = 2 * vBegin / tmax;
                acceleration = new Vector3(0, gavity, 0);
                myState = State.Jumping;
            }
        }
        if (myState == State.Jumping)
        {
            if (t < tmax)
            {
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
                myState = State.Running;
            }

        }

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

    }
}

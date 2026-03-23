using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStr;
    private bool isAlive = true;
    private Logic logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStr;
        }        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.game_over();
        isAlive = false;
    }
}

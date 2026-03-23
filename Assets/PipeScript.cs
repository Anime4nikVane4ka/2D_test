using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 2;
    private Logic logic;
    private float deadZone = -30;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player")) {
            logic.add_score();
        }        
    }
}

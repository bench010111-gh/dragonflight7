using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, -distanceY, 0);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // on trigger collision, run once
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // missile collided -> missile destroy
            Destroy(collision.gameObject);

            // missile collided -> enemy destroy
            Destroy(gameObject);
        }
    }
}

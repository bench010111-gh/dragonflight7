using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject effect;

    void Start()
    {
        
    }

    void Update()
    {
        // move in y-axis
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    // function to call when moving outisde screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // bullet or enemy, only one implementation will suffice
        // on trigger collision, run once
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // instantiate effect
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            // ½Ì±ÛÅæ ÇÔ¼ö È£Ãâ
            SoundManager.instance.SoundDie();

            // Á¡¼ö
            GameManager.Instance.AddScore(100);

            // enemy collided -> enemy destroy
            Destroy(collision.gameObject);

            // enemy collided -> bullet destroy
            Destroy(gameObject);
        }

        //if (collision.gameObject.tag == "Bullet")
        //{

        //}
    }
}

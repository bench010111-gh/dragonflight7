using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 0.3f);
    }

    void Shoot()
    {
        SoundManager.instance.SoundBullet();
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}

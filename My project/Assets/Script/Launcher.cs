using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // method to load missile prefab

    void Start()
    {
        // InvokeRepeating("function name, initial delay, delay interval);
        InvokeRepeating("Shoot", 0.5f, 0.3f);
    }

    void Shoot()
    {
        // ½Ì±ÛÅæ»ç¿îµå ÇÃ·¹ÀÌ
        SoundManager.instance.SoundBullet();
        // missile prefab, launch position, no direction vector
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

}

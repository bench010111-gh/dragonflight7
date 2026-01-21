using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = true;
    public GameObject enemy;

    public void SpawnEnemy()
    {
        float randomX = Random.Range(-2.5f, 2.5f);

        if (enableSpawn)
        {
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }

    }

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 0.5f);
    }

    void Update()
    {
        
    }
}

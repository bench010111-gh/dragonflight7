using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject enemy; // prefab으로 만든 적을 가져온다

    // 적을 생성하는 함수
    public void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f); // 적이 나타날 x좌표를 램덤으로 생성한다.

        if (enableSpawn)
        {
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }

    }

    void Start()
    { // SpawnEnemy를 반복해서 불러주고, 최초 1초, 이후엔 0.5초마다 부르기
        InvokeRepeating("SpawnEnemy", 1f, 0.5f);
    }

    void Update()
    {
        
    }
}

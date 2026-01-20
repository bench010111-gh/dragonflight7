using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    // 자주 쓰이는 디자인 패턴 중 하나

    public static SingletonTest instance; // has to only make one, but can be used anywhere

    private void Awake()    // is loaded before Start()
    {
        if (instance == null)
        {
            instance = this; // 자기참조객체
        }
    }


    public void PlayerSound()
    {
        Debug.Log("플레이어 사운드야");
    }

    public void EnemySound()
    {
        Debug.Log("적 사운드야");
    }


}

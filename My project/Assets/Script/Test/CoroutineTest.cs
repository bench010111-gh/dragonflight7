using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Coroutine: per-frame control. not thread, but references main()

    void Start()
    {
        StartCoroutine(ChangeText());
    }



    // memorize this part:
    IEnumerator ChangeText()
    {
        Debug.Log("준비");

        yield return new WaitForSeconds(1f); // wait 1 sec

        Debug.Log("시작");

        yield return new WaitForSeconds(1f);

        Debug.Log("끝");
    }

}

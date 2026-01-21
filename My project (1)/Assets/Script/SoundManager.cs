using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    AudioSource myAudio;


    public AudioClip soundBullet;
    public AudioClip soundDie;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }

    public void SoundBullet()
    {
        myAudio.PlayOneShot(soundBullet);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource AudioSource;
    public AudioClip AudioClip;

    public static int soundOn = 1;

    public static bool staticSound = false;

    public void PlaySound()
    { 
        if(soundOn == 1)
        {
            AudioSource.Stop();
            AudioSource = gameObject.AddComponent<AudioSource>();
            AudioSource.clip = AudioClip;
            AudioSource.loop = true;
            AudioSource.volume = 0.4f;
            AudioSource.Play();

            staticSound = false;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        if (staticSound == true)
            PlaySound();
        else if (soundOn == 0)
            AudioSource.Stop();
    }
}

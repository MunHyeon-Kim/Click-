using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip AudioClip;

    public static int soundOn = 1;

    public static bool staticSound = false;

    public void PlaySound()
    {
        if (soundOn == 1)
        {
            AudioSource.Stop();
            AudioSource = gameObject.AddComponent<AudioSource>();
            AudioSource.clip = AudioClip;
            AudioSource.loop = false;
            AudioSource.volume = 0.4f;
            AudioSource.Play();

            staticSound = false;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (staticSound == true && soundOn == 1)
            PlaySound();
    }
}

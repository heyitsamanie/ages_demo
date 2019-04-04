using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRandomSounds : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    private AudioSource source;
    float clip = 0;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (source.isPlaying == false)
        {
            clip = Random.Range(0, 2);

            if (clip <= 1.0) { source.Stop();
                source.PlayOneShot(clip1, 1f);

        }
            if (clip > 1.0)
            {
                source.Stop(); source.PlayOneShot(clip2, 1f);
            }
        }
    }
}

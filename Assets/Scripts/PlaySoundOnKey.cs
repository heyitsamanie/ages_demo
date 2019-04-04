using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnKey : MonoBehaviour
{
    public AudioClip Sound1;
    public AudioClip Sound2;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            source.PlayOneShot(Sound1);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            source.PlayOneShot(Sound2);
        }
    }
  
}

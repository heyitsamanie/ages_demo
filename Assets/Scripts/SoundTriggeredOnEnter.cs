using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTriggeredOnEnter : MonoBehaviour
{
    public AudioClip Sound1;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        
        if (otherObject.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(Sound1, 1F);
        }

        //CharacterController player = other.GetComponent<CharacterController>();
        //audioSource.Play();
    }
}

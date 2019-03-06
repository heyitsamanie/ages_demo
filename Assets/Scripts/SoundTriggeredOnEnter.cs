using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTriggeredOnEnter : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        CharacterController player = other.GetComponent<CharacterController>();
        audioSource.Play();
    }
}

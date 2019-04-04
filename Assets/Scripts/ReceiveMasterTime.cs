using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveMasterTime : MonoBehaviour
{
    //first we creat a reference to the other game object to receive from
    GameObject[] foundObjects;
    GameObject receivedFrom;
    //sendTime referenceScript;

    private double receivedTime;
    private bool receivedState = false;

    public AudioClip[] clips = new AudioClip[2];

    //private double nextEventTime;  this variable is now receivedTime - sent from the master
    private int flip = 0;
    private AudioSource[] audioSources = new AudioSource[2];
    private bool running = false;
    private double playTime;

    private void Start()
    {
        //in  start we get the reference to the other game object
        //by finding a game object with a tag
        foundObjects = GameObject.FindGameObjectsWithTag("Player");
        receivedFrom = foundObjects[0];
      //  referenceScript = receivedFrom.GetComponent<sendTime>();

        for (int i = 0; i < 2; i++)
        {
            GameObject child = new GameObject("b_Music");
            child.transform.parent = gameObject.transform;
            audioSources[i] = child.AddComponent<AudioSource>();
        }

        running = true;
       // receivedTime = referenceScript.nextEventTime;
    }

    private void Update()
    {
        if (!running)
        {
            return;
        }

     //   if (referenceScript.time + 1.0f > receivedTime)
        {
            audioSources[flip].clip = clips[flip]; audioSources[flip].PlayScheduled(receivedTime);
            flip = 1 - flip;
      //      receivedTime = referenceScript.nextEventTime;
        }
    }
}

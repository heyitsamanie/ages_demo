using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMasterTime : MonoBehaviour
{
    public float bpm = 140.0f;
    public int numBeatsPerSegment = 8;
    public double nextEventTime = 0.0;
    public bool cueState = false; public double time;

    void Start()
    {
        nextEventTime = AudioSettings.dspTime + 2.0f;
    }

    void Update()
    {
        time = AudioSettings.dspTime;

        if (time + 1.0f > nextEventTime)
        {
            // Place the next event 16 beats from here at a rate of 140 beats per minute
            nextEventTime += 60.0f / bpm * numBeatsPerSegment;
            Debug.Log("nextEventTime is " + nextEventTime);
            cueState = true;
        }
        else
        {
            cueState = false;
        }
    }
}

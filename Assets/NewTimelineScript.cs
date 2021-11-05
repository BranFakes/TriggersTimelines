using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class NewTimelineScript : MonoBehaviour
{
    public PlayableDirector timeline;

    void Start()
    {
        timeline = GetComponent<PlayableDirector>();  
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeline.Stop();
        }
    }

     void OnTriggerEnter(Collider other)
     {
        if (other.gameObject.tag == "Player")
        {
            timeline.Play();
        }
     }
}

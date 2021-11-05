using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {        
        timeline.Play();        

        if (OneTimeTrigger == true)
        {
        Destroy(this.gameObject);
        }        
    }

}

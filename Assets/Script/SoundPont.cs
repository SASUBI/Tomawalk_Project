using UnityEngine;
using System.Collections;

public class SoundPont : MonoBehaviour {
    public AudioSource Audio;
    // Use this for initialization
  
    void OnTriggerEnter(Collider collider)
    {
        Audio.Play();
    }
    void OnTriggerExit(Collider collider)
    {
        Audio.Stop();
    }
    // Update is called once per frame
    
}

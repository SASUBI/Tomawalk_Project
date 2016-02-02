using UnityEngine;
using System.Collections;

public class Dynamite : MonoBehaviour {
    public GameObject MaDynamite;
    public Transform frontplayer;
    public int forceDynamite;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.S))
        {
            
          
           
            GameObject clone = (GameObject)Instantiate(MaDynamite, frontplayer.position, frontplayer.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(frontplayer.forward * forceDynamite);
            
            

        }
       
    }
}

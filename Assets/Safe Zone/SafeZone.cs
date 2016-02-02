using UnityEngine;
using System.Collections;

public class SafeZone : MonoBehaviour {
    public GameObject TargetJoueur;
    public GameObject TargetAI;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnTriggerEnter(Collider TargetJoueur)
    {
        Debug.Log("Bonjour");
        BasicAI.moveSpeed = 0f;
        //Destroy(TargetAI.gameObject);
    }
    void OnTriggerExit(Collider TargetJoueur)
    {
        Debug.Log("Aureveoir");
        BasicAI.moveSpeed = 5f;
        //Instantiate(TargetAI);
    }
}

using UnityEngine;
using System.Collections;

public class TimerDynamite : MonoBehaviour {
    private float timerDynamite = 2f;
    bool turnon = false;
    public AudioSource Audio;
    // Use this for initialization
    void Awake()
    {
        turnon = true;
    }
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (turnon == true)
        {
            timerDynamite -= Time.deltaTime;

        }
        if ((timerDynamite <= 0.3) && (timerDynamite >= 0.25))
        {
            Audio.Play();
        }
        if (timerDynamite <= 0)
        {
            
            Debug.Log("Boom");
            Destroy(this.gameObject);

        }
    }
}

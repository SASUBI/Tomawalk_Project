﻿using UnityEngine;
using System.Collections;

public class GestionAnim : MonoBehaviour {
    public Animation anim;
    public GameObject Monfouet;
    public AudioSource Audio;
    // Use this for initialization
    void Start () {
        anim = Monfouet.GetComponent<Animation>();
        anim.Play();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            Audio.Play();
            Debug.Log("Vasy");
            anim.Play();
        }
        
    }
}

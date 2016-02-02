using UnityEngine;
using System.Collections;

public class Eboulis : MonoBehaviour {
    public AudioSource AudioCailloux;
    public AudioSource AudioExplo;
    bool Explo = false;
    void OnCollisionEnter(Collision collider) {
        if (collider.gameObject.tag == "Dynamite")
        {
            AudioCailloux.Play();
            AudioExplo.Play();
            Explo = true;
            if (Explo == true)
            {
                Destroy(this.gameObject);
                Destroy(collider.gameObject);
            }
            
        }
    }

}

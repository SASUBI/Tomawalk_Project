using UnityEngine;
using System.Collections;

public class Teleporteur : MonoBehaviour
{
    public int code;
    float disableTimer = 0;
    void Update()
    {
        if (disableTimer > 0)
        {
            disableTimer -= Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && disableTimer <= 0)
        {
            foreach (Teleporteur tp in FindObjectsOfType<Teleporteur>())
            {
                if (tp.code == code && tp != this)
                {
                    tp.disableTimer = 2;
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position = position;
                }
            }
        }
    }
}

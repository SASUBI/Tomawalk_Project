using UnityEngine;
using System.Collections;

public class Lasso : MonoBehaviour {
    public GameObject[] PuzzleLasso;
    public GameObject[] PuzzleLasso2;
    public GameObject Puzzle;
    public GameObject Puzzle2;
    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            
            RaycastHit hit;
            float theDistance;
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.green);
            if (Physics.Raycast(transform.position, (forward), out hit))
            {
                theDistance = hit.distance;
                if(hit.collider.gameObject.tag == "LassoDestroy")
                {
                   
                    Destroy(hit.collider.gameObject);
                }
                //print(theDistance + " " + hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "LassoDestroy2")
                {
                   
                    Destroy(hit.collider.gameObject);
                }
                //print(theDistance + " " + hit.collider.gameObject.name);
            }
        }
        PuzzleLasso = GameObject.FindGameObjectsWithTag("LassoDestroy");
        PuzzleLasso2 = GameObject.FindGameObjectsWithTag("LassoDestroy2");
        if (PuzzleLasso.Length == 0)
        {
            
            Puzzle = GameObject.FindGameObjectWithTag("PuzzleLasso");
            Destroy(Puzzle);
        }
        if (PuzzleLasso2.Length == 0)
        {
          
            Puzzle2 = GameObject.FindGameObjectWithTag("PuzzleLasso2");
            Destroy(Puzzle2);
        }
    }
}

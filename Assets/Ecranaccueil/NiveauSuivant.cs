using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NiveauSuivant : MonoBehaviour {

	void Update () {
        if (Input.GetButtonDown("Submit"))
        {
            SceneManager.LoadScene("LevelDesign");
        }
	}
}

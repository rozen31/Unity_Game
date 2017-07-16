using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class MainMenu_Script : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Camera.main.GetComponent<Blur>().iterations = 4;
        Camera.main.GetComponent<Blur>().blurSpread = 0.4f;
    }

}

using UnityEngine;
using System.Collections;

public class Play_PanelScript : MonoBehaviour {

    GameObject Canvas;
	// Use this for initialization
	void Start () {
        Canvas = GameObject.Find("Canvas");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Pause()
    {
        Canvas.transform.GetChild(1).gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

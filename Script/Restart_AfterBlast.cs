using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class Restart_AfterBlast : MonoBehaviour {
    public GameObject Canvas;
    void Start()
    {
        Canvas =  GameObject.Find("Canvas");
        if(Canvas != null)
        Debug.Log("True");
    }


    void Replay_Activate()
    {
        Camera.main.GetComponent<Blur>().iterations = 2;
        Camera.main.GetComponent<Blur>().blurSpread = .8f;
        Canvas.transform.GetChild(2).gameObject.SetActive(true);
        Canvas.transform.GetChild(3).gameObject.SetActive(false);
    }
}

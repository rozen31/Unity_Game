using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
using UnityEngine.SceneManagement;


public class Replay_PanelScript : MonoBehaviour {

    GameObject Canvas;

    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        Camera.main.GetComponent<Blur>().iterations = 4;
        Camera.main.GetComponent<Blur>().blurSpread = 0.4f;
    }

    public void Replay_Yes()
    {
        SceneManager.LoadScene("PlaneDestroyer");
    }

    public void Replay_No()
    {
        
        Canvas.transform.GetChild(0).gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }


}

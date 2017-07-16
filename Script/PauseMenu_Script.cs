using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class PauseMenu_Script : MonoBehaviour {


    GameObject Canvas;
    void Start()
    {
        Camera.main.GetComponent<Blur>().iterations = 4;
        Camera.main.GetComponent<Blur>().blurSpread = 0.4f;
        Time.timeScale = 0;
        Canvas = GameObject.Find("Canvas");
    }

    public void Pause_Abundon_Yes()
    {
        Time.timeScale = 1;
        Camera.main.GetComponent<Blur>().iterations = 0;
        Camera.main.GetComponent<Blur>().blurSpread = 0f;
        Canvas.transform.GetChild(0).gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void Pause_Abundon_No()
    {
        Time.timeScale = 1;
        Camera.main.GetComponent<Blur>().iterations = 0;
        Camera.main.GetComponent<Blur>().blurSpread = 0f;
        this.gameObject.SetActive(false);
        Canvas.transform.GetChild(3).gameObject.SetActive(true);
    }
}

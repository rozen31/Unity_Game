using UnityEngine;
using System.Collections;

public class Obstracle_Script : MonoBehaviour
{
   public GameObject Plane;
    void Start()
    {
        Plane = GameObject.Find("Plane");
    }

    void Update()
    {
        if (Plane)
        {
            if (Mathf.Abs(Mathf.Abs(Plane.transform.position.x) - Mathf.Abs(this.transform.position.x)) > 30f)
            {
                if(Plane.transform.right.x > 0)
                    this.transform.position = new Vector3(Plane.transform.position.x - Random.Range(10f, 12f), Random.Range(2f, 8f), 0f);
                else
                    this.transform.position = new Vector3(Plane.transform.position.x + Random.Range(10f, 12f), Random.Range(2f, 8f), 0f);
            }

        }

    }



}

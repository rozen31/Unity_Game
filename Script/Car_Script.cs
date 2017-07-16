using UnityEngine;
using System.Collections;

public class Car_Script : MonoBehaviour {

    public GameObject Plane;
    public GameObject CarBlast;
    public GameObject CarCrash;

    void Start()
    {
        Plane = GameObject.Find("Plane");
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bomb")
        {
            Destroy(this.gameObject);
            GameObject A = (GameObject)Instantiate(CarBlast, this.transform.position, Quaternion.identity);
            GameObject B = (GameObject)Instantiate(CarCrash, this.transform.position, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update () {
        if (Plane)
        {
            if (Mathf.Abs(Mathf.Abs(Plane.transform.position.x) - Mathf.Abs(this.transform.position.x)) > 30f)
            {
                if (Plane.transform.right.x > 0)
                    this.transform.position = new Vector3(Plane.transform.position.x - Random.RandomRange(-30f,30f), -4.13f, 0f);
                else
                    this.transform.position = new Vector3(Plane.transform.position.x + Random.RandomRange(-30f, 30f), -4.13f, 0f);
            }

        }


    }
}

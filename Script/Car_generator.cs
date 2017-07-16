using UnityEngine;
using System.Collections;

public class Car_generator : MonoBehaviour {

    public int numberofCar = 10;

    public GameObject Plane;
    public float distance = 100f;
    public GameObject Car;

    private GameObject[] Cars;

	// Use this for initialization
	void Start ()
    {
        Cars = new GameObject[numberofCar];
        for (int i = 0; i < numberofCar; i++)
        {
            Cars[i] = (GameObject)Instantiate(Car,new Vector3(100,100,100),Quaternion.identity);
            Cars[i].transform.position = new Vector3(i*7f,-4.13f,0f);
            Cars[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.RandomRange(-4f,4f),0f,0f);
        }

	}
	

}

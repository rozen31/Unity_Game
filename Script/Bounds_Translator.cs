using UnityEngine;
using System.Collections;

[System.Serializable]
public class Background
{
    public GameObject UpperBound;
    public GameObject LowerBound;
    public Background(GameObject UB, GameObject LB)
    {
        UpperBound = UB;
        LowerBound = LB;
    }
    public Background()
    {
        UpperBound = null;
        LowerBound = null;
    }
};


public class Bounds_Translator : MonoBehaviour
{

    public GameObject Plane;   
    public Background[] A = new Background[3];
    public float length = 19.13f;

    public void Rotateback()
    {
        Background temp = new Background();
        A[2].UpperBound.transform.position = A[0].UpperBound.transform.position + new Vector3(length,0f,0f);
        A[2].LowerBound.transform.position = A[0].LowerBound.transform.position + new Vector3(length, 0f, 0f);

        temp = A[0];
        A[0] = A[2];
        A[2] = A[1];
        A[1] = temp;

    }
    public void Rotateforw()
    {
        Background temp = new Background();
        A[0].UpperBound.transform.position = A[2].UpperBound.transform.position - new Vector3(length, 0f, 0f);
        A[0].LowerBound.transform.position = A[2].LowerBound.transform.position - new Vector3(length, 0f, 0f);

        temp = A[0];
        A[0] = A[1];
        A[1] = A[2];
        A[2] = temp;
    }


    void Start()
    {
        
    }

	// Update is called once per frame
	void Update ()
    {
        if (Plane)
        {
            if ((Plane.transform.position.x - A[1].LowerBound.transform.position.x) > (length / 2))
            {
                Rotateback();
            }

            if ((A[1].LowerBound.transform.position.x - Plane.transform.position.x) > (length / 2))
            {
                Rotateforw();
            }

        }
    }
}

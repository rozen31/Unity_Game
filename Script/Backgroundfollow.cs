using UnityEngine;
using System.Collections;

public class Backgroundfollow : MonoBehaviour {

    public Transform Plane;
    Vector3 newPosition = new Vector3(0f, 0f, 0f);
    float a = 0.001f;
    void Update()
    {

        if (Plane)
        {
            if (Plane.GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                newPosition += new Vector3(a, 0f, 0f);
                GetComponent<Renderer>().material.mainTextureOffset = newPosition;
            }
            else
            {
                newPosition -= new Vector3(a, 0f, 0f);
                GetComponent<Renderer>().material.mainTextureOffset = newPosition;
            }
        }
    }
}

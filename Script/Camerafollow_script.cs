using UnityEngine;
using System.Collections;

public class Camerafollow_script : MonoBehaviour {

    public Transform Plane;
    Transform mytransform;
	void Start () {
        mytransform = this.transform;
	}
	
	void Update () {
        if (Plane)
        {
            Vector3 newPosition = new Vector3(Plane.position.x, mytransform.position.y, mytransform.position.z);
            mytransform.position = newPosition;
        }
    }

    public void Vibrate()
    {
        iTween.ShakePosition(this.gameObject, new Vector3(0.2f, 0.2f, 0f),0.1f);
    }
}

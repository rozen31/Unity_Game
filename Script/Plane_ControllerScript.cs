using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Plane_ControllerScript : MonoBehaviour {

    Rigidbody2D myrgbody;
    Transform bodytransform;
    public GameObject PlaneBlast;
    public GameObject PlaneCrash;
    float velx = -4f;

    void Start ()
    {
        myrgbody = this.GetComponent<Rigidbody2D>();
        bodytransform = this.GetComponent<Transform>();

	}

    public void OnClick()
    {
        myrgbody.AddForce(new Vector2(0f,3000f));
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(this.gameObject);
        GameObject A = (GameObject)Instantiate(PlaneBlast,this.transform.position,Quaternion.identity);
        GameObject B = (GameObject)Instantiate(PlaneCrash, this.transform.position, Quaternion.identity);
    }

    void FixedUpdate ()
    {
        //Vector3 Direction = -transform.right;
        //Vector2 direction = new Vector2(Direction.x,Direction.y);
        //Vector2 forw_Vel = direction * velx;

        myrgbody.velocity = new Vector3(velx, 0f, 0f);
        //float a = 7 * CrossPlatformInputManager.GetAxis("Horizontal")*(direction.x/Mathf.Abs(direction.x));
        //myrgbody.AddForce(new Vector3(0f, a*9f, 0f));
        //Vector3 move = new Vector3(0f,0f,0f);
        //if (Mathf.Abs(CrossPlatformInputManager.GetAxis("Vertical")) > 0.3f)
        //{
        //    move = new Vector3(0f, 0f,-1* CrossPlatformInputManager.GetAxis("Vertical")) * 2f;
        //}
        //bodytransform.eulerAngles = bodytransform.eulerAngles+move;

        //if (CrossPlatformInputManager.GetAxis("Vertical") == 0 )
        //{


        //}


    }
}

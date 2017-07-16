using UnityEngine;
using System.Collections;

public class Bomb_Script : MonoBehaviour
{
    public GameObject SmallBlast;
    public GameObject BigBlast;


    void OnCollisionEnter2D(Collision2D coll)
    {
              
        if (coll.gameObject.tag == "Ground")
        {
            GameObject A = (GameObject)Instantiate(SmallBlast,this.transform.position,Quaternion.identity);
            Camera.main.GetComponent<Camerafollow_script>().Vibrate();
        }

        if (coll.gameObject.tag == "Car")
        {
            GameObject A = (GameObject)Instantiate(BigBlast, this.transform.position,Quaternion.identity);
        }
        Destroy(this.gameObject);

    }



}

using UnityEngine;
using System.Collections;

public class Bomb_generator_Script : MonoBehaviour {
    public GameObject Bomb;
    public int BombCount = 3;

    public void Bomb_drop()
    {
        //if (BombCount > 0)
        //{
            GameObject A = (GameObject)Instantiate(Bomb, this.transform.position, Quaternion.Euler(0f,0f,0f));
            A.GetComponent<Rigidbody2D>().velocity = this.GetComponentInParent<Rigidbody2D>().velocity + new Vector2(-5f,0f);
            BombCount -= 1;
        //}
    }





}

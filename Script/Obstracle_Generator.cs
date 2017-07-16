using UnityEngine;
using System.Collections;

public class Obstracle_Generator : MonoBehaviour {

    public GameObject Obs;
    public GameObject[] Obstracle = new GameObject[10];

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Obstracle[i] = (GameObject)Instantiate(Obs, new Vector3(100f, 100f, 0f), Quaternion.identity);
            Obstracle[i].transform.position = new Vector3( Random.Range(-30f,30f), Random.Range(2f, 8f),0f);
            if (Obstracle[i].transform.position.x >= -1f && Obstracle[i].transform.position.x <= 3f)
            {
                Obstracle[i].transform.position += new Vector3(10f, 0f, 0f);
            }
        }

    }

}

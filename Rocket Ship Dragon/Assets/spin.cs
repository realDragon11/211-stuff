using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{

    public float spindir;
    public GameObject the;
    // Start is called before the first frame update
    void Start()
    {
        spindir = Random.Range(-10.0f,10.0f)*10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject the = GetComponent<GameObject>();
        the.transform.Rotate(new Vector3(0,0,1) *spindir,Space.Self);
        the.transform.position = new Vector3(the.transform.position.x,the.transform.position.y-.2f,0);
        if (the.transform.position.y < -10){
        the.transform.position = new Vector3(Random.Range(-10f,10f),the.transform.position.y+20,0);
        }
    }
}

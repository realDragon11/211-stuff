using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_player : MonoBehaviour
{

    public GameObject player;
    public int speed;
    public Animator a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int movex = 0;
        int movey = 0;
        float cspeed = Time.deltaTime*speed;
        if (Input.GetKey(KeyCode.W)){
            movey++;
        }
        if (Input.GetKey(KeyCode.S)){
           movey--;
        }
        if (Input.GetKey(KeyCode.D)){
            movex++;
            a.SetBool("left",false);
        }
        if (Input.GetKey(KeyCode.A)){
            movex--;
            a.SetBool("left",true);
        }

        player.transform.position = new Vector3(player.transform.position.x + movex*cspeed,player.transform.position.y + movey*cspeed,0);


    }
}

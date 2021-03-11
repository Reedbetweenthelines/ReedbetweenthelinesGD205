using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreePlayer : MonoBehaviour
{

    //we assign these to be equivalent in each direction, so fwd = (x = 0, y = 0, z = 1) and bwd = (x = 0, y = 0, z = -1)
    public Vector3 fwd, bwd, lft, rgt, up, dwn;
    public Transform enemy, key, raft;
    Vector3 startPos;
    bool hasKey;

    // Start is called before the first frame update
    void Start() //like setup
    {
        startPos = transform.position;
        hasKey = false;
    }

    // Update is called once per frame
    void Update()
    {

        //access the Input class method called GetKeyDown, which takes a KeyCode parameter
        //This will return true when this specific key is pressed down and false when it isn't
        if (Input.GetKeyDown(KeyCode.W))
        {


            //this is similar to print or println in processing
            Debug.Log("you pressed w :)");


            //modify the position of the transform of whatever gameobject this is attached to
            //offset it by fwd (move from the current position to the current position plus the value of fwd)
            transform.position += fwd;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("you pressed s :/");

            transform.position -= bwd;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("you pressed s ;)");
            transform.position += lft;
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("you pressed d ;o");
            transform.position -= rgt;
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("you pressed q ;o");
            transform.position += up;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("you pressed e ;o");
            transform.position -= dwn;
        }

        if (enemy.position == transform.position)
        {
            transform.position = startPos;
        }

        if (hasKey == true)
        {
            transform.position = raft.position;
        }
       
        if (key.position == transform.position)
        {
            hasKey = true;
        }
    }
}

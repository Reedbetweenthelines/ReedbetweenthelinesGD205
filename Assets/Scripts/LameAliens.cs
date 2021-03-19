using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LameAliens : MonoBehaviour
{
    Rigidbody floppy;
    Vector3 fwd, bwd, lft, rgt, up, dwn;
    public float thrustAmt;
    public float attackSpeed = 2;
    public float attackDistance = 4;


    // Start is called before the first frame update
    void Start()
    {
        floppy = GetComponent<Rigidbody>();
        fwd = new Vector3(0f, 0f, 1f);
        bwd = new Vector3(0f, 0f, -1f);
        lft = new Vector3(-1f, 0f, 0f);
        rgt = new Vector3(1f, 0f, 0f);
        up = new Vector3(0f, 1f, 0f);
        dwn = new Vector3(0f, -1f, 0f);




    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
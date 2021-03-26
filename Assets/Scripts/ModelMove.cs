using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMove : MonoBehaviour
{

    Animator Botty;
    // Start is called before the first frame update
    void Start()
    {
        Botty = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("You can Move!");
            //Botty.transform +
        }
    }
}

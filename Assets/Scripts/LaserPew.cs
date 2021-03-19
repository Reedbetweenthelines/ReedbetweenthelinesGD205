using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPew : MonoBehaviour
{
    public float Kaboom = 6f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Ray laserPew = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(laserPew, out hit, 1000f)) {
            Debug.Log("ahhh!" + hit.transform.gameObject.name);
            //hit.transform.localScale = new Vector3(0.02f, +0.01f, -0.03f);
            if (hit.rigidbody && hit.transform != transform && Input.GetMouseButton(0))
            {
                hit.rigidbody.AddExplosionForce(Kaboom, hit.point, 10f, 3f);
                //Destroy(hit.transform.gameObject);
                Debug.Log("Oww, you hit me!" + hit.transform.gameObject.name);
            }
          
        }


    }
}

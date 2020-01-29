using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    public GameObject theCamera;
    public GameObject create;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Create prefab sphere every frame.
    //void FixedUpdate()
    //{
    //    if (Input.GetMouseButton(1))
    //    {
    //        RaycastHit hit; // to store output
    //        Ray ray = theCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

    //        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
    //        {
    //            GameObject.Instantiate(create, hit.point, Quaternion.identity);
    //        }
    //    }
    //}

    // Only creates prefab sphere on mouse button down.
    //void FixedUpdate()
    //{
    //    if (Input.GetMouseButtonDown(1))
    //    {
    //        RaycastHit hit; // to store output
    //        Ray ray = theCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

    //        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
    //        {
    //            GameObject.Instantiate(create, hit.point, Quaternion.identity);
    //        }
    //    }
    //}

    // Create prefab sphere at a slower speed.
    void FixedUpdate()
    {
        count = count + 1;
        if (count >= 4) { count = 0; }
        if (Input.GetMouseButton(1) && count == 0)
        {
            RaycastHit hit; // to store output
            Ray ray = theCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject.Instantiate(create, hit.point, Quaternion.identity);
            }
        }
    }
}

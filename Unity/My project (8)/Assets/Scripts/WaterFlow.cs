
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class WaterFlow : MonoBehaviour
{
    public GameObject ps;
    public bool a = true;
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && a)
        {
            ps.transform.position = new Vector3(transform.position.x + 0.8f, transform.position.y, transform.position.z);
            ps.transform.rotation = new Quaternion(0f, (float)transform.rotation.x, (float)transform.rotation.y - 2.75f, (float)transform.rotation.z);
            Thread.Sleep(100);
            a = false;
        }
        
        else if (Input.GetMouseButtonDown(0) && !a)
        {
            ps.transform.position = new Vector3(1000, 1000, 1000);
            a = true;
        }

    }
}

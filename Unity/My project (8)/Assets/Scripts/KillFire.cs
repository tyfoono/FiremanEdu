using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class KillFire : MonoBehaviour
{
    public string health;
    public GameObject water;
    public GameObject fire;
    GameObject[] fireObjects = new GameObject[4];
    void Start()
    {
        for (int i = 0; i < 4; i++){
            fireObjects[i] = gameObject.transform.GetChild(i).gameObject;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        Damage();
    }
    void Damage() {
        if (health == "Big")
        {
            for (int i = 3; i >= 0; i--)
            {
                Destroy(fireObjects[i], 5f);
            }
        }
        else if (health == "Small") {
            for (int i = 3; i >= 0; i--)
            {
                Destroy(fireObjects[i], 2.5f);
            }
        }
        
    }
}

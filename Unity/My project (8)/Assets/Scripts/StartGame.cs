using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject WaterGun;
    void Start()
    {
        WaterGun.transform.position = new Vector3(1000, 1000, 1000);
    }
}

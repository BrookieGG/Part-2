using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{
    public GameObject Plane;
    float timer;


    void Start()
    {


    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 5)
        {
            timer = 0;
            Instantiate(Plane);
        }
    }
  
}

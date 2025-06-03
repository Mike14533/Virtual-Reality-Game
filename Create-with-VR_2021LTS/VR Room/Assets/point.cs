using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
     public Transform Totem1;
     public GameObject Needle;
    
    public float rotatespeed = 40f;
    // Update is called once per frame
   
    void Update()
    {
         Vector3 direction = Totem1.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        Needle.transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotatespeed * Time.deltaTime);



      

    }
}

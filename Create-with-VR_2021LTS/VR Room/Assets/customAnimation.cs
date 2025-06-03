using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customAnimation : MonoBehaviour
{
    public GameObject reticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reticle.transform.Rotate(0f, 0.5f, 0f);
    }
}

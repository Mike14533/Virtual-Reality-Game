using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBookZombie : MonoBehaviour
{
    public GameObject Cover;
    public GameObject Zombie;
    public HingeJoint myHinge;

    // Start is called before the first frame update
    void Start()
    {
        var myHinge = Cover.GetComponent<HingeJoint>();
       
        myHinge.useMotor = false;
        
    }
    void Update(){
        if(Cover.transform.eulerAngles.z > 40 )
        {
                  Debug.Log("Open Sesame");
  
        Zombie.SetActive(true);
        }
  
       
    }

    public void Open()
    {
        Debug.Log("Open Sesame");
        myHinge.useMotor = true;

        
    }
}

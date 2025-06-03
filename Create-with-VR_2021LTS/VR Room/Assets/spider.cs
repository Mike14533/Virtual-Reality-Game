using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spider : MonoBehaviour
{
    
    public Vector3 targetPosition;

    public float speed = 1.0f;
    public float rotatespeed = 40f;
    public Camera wolfcam;
    
    public NavMeshAgent agent;
 public GameObject self;



	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, 0.1f, 0);
        
       
          
         
        float distance = targetPosition.magnitude;
        
        
            
            Ray movePosition = wolfcam.ScreenPointToRay(targetPosition);
           
            if(Physics.Raycast(movePosition, out var hitInfo)){
                
                agent.SetDestination(hitInfo.point);

            }

        
        
        else
        {
          speed = 0;
            }

        }
        
         

 
}








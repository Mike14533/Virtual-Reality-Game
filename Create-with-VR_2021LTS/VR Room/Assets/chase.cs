using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chase : MonoBehaviour
{
    public GameObject target;
public Transform target1;
    private Animator animator;
    public float speed = 15.0f;
    public float rotatespeed = 40f;
    public float chaseRange;
    public NavMeshAgent agent;
     private IEnumerator coroutine;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update ()
    {
        
        float speedDelta  = speed * Time.deltaTime;
          Vector3 direction = target1.position - transform.position;
          
         // Vector3 randdirection = new Vector3(Random.Range(1000, -1000), Random.Range(1000, -1000), 0);
        float distance = direction.magnitude;
        
        if(distance < chaseRange)
    
        {
            
            Ray movePosition = Camera.main.ScreenPointToRay(direction);
           
            if(Physics.Raycast(movePosition, out var hitInfo)){
                
                agent.SetDestination(hitInfo.point);
                //Quaternion rotation = Quaternion.LookRotation(hitInfo.point);
                 //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotatespeed * Time.deltaTime);
            }

           // transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
          speed = 0;
            }

        }
        
         

        void FaceTarget()
    {
        var turnTowardNavSteeringTarget = agent.steeringTarget;
     
        Vector3 direction = (turnTowardNavSteeringTarget - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.layer == LayerMask.NameToLayer("sword")){
            animator.SetTrigger("Death");
            speed = 0;
              coroutine = WaitAndPrint(3.0f);
            StartCoroutine(coroutine);

        }
        
    }
     private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.SetActive(false);
        print("Coroutine ended: " + Time.time + " seconds");
    }
}








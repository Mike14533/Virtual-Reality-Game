using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
     private IEnumerator coroutine;
    public int wellbeing = 100;
    public GameObject player;
    public GameObject Transform1;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wellbeing < 0)
        {
            player.transform.position = Transform1.transform.position;
            wellbeing = 100;
        }
    }
     private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.layer == LayerMask.NameToLayer("Zombie"))
        {
            
            wellbeing -= 20 ;
               coroutine = Heal(5.0f);
        StartCoroutine(coroutine);
        }

        }
        private IEnumerator Heal(float waitTime)
    {
        wellbeing +=5;
        Debug.Log("Health:" + wellbeing);
        yield return new WaitForSeconds(waitTime);
        print("Coroutine ended: " + Time.time + " seconds");
    }
    
}

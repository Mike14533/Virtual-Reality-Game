using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathopendoor : MonoBehaviour
{

 public GameObject door;
 public GameObject truck;
 public Color collisionIncorrectColor = Color.green;
 public Color collisionCorrectColor = Color.green;
 public Color resetColor = Color.white;
 public int correctNum;


 public void OnCollisionEnter(Collision collision)
{
    
        if (collision.gameObject.layer == LayerMask.NameToLayer("Correct") ){
                Renderer renderer = collision.gameObject.GetComponent<Renderer>();
             if (renderer != null)
             {
                 renderer.material.color = collisionCorrectColor;
             }
       

    }
        
       if(collision.gameObject.layer == LayerMask.NameToLayer("Incorrect")){
    
        Debug.Log("InCorrect");
          Renderer renderer = collision.gameObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = collisionIncorrectColor;
                gameObject.transform.position = truck.transform.position;
            }
        
       }
                if(collision.gameObject.layer == LayerMask.NameToLayer("FinalTIle")){
                  Debug.Log("final tile");
          Renderer renderer = collision.gameObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = collisionCorrectColor;
                       door.SetActive(false);
            }
        
       }
 
}
}
  

  
    
 





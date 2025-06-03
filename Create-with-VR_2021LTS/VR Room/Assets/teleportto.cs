using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportto : MonoBehaviour
{
   public GameObject Player;
    public GameObject Truck;
  public void teleport(){
     Player.transform.position = Truck.transform.position;
        
    }
}

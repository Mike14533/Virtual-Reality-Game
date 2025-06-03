using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class endgame : MonoBehaviour
{
    public GameObject panel;
  public GameObject totem1;
  public GameObject totem2;
  public GameObject totem3;
  public int totem1Amount = 0;
    public int totem2Amount = 0;
      public int totem3Amount = 0;
 private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.layer == LayerMask.NameToLayer("Totem1"))
        {
            totem1Amount = 1 ;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Totem2"))
        {
             totem2Amount  =1 ;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Totem3"))
        {
             totem3Amount =1;
        }
    }
 void Update(){
    if (totem1Amount == 1 && totem2Amount ==1 && totem3Amount ==1){
        panel.SetActive(true);
    }
 }
}
    


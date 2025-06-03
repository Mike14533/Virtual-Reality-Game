using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class openDoor : MonoBehaviour
{
  public GameObject door;
  public GameObject key;
 private void OnTriggerEnter(Collider other){
    door.SetActive(false);
    key.SetActive(false);
    gameObject.SetActive(false);

 }
}

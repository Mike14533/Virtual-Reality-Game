using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passcode : MonoBehaviour
{

    public string correctPasscode = "1234"; 
    private string enteredPasscode = "";

    public void addNum(string num)
    {
        enteredPasscode += num;
        Debug.Log("Number added");
       
        
        if (enteredPasscode == correctPasscode)
        {
            Debug.Log("Door unlocked!");
            gameObject.SetActive(false);
        }
    }

    public void ClearPasscode()
    {
        enteredPasscode = "";
       
    }
}

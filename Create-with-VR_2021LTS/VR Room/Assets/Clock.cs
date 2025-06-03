using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject secondHand;
    public GameObject minuteHand;
    public GameObject hourHand;
    string oldSeconds;
    // Update is called once per frame
   
    void Update()
    {
        int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        int hoursInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));

        print(hoursInt + " : " + minutesInt + " : " + secondsInt);

        secondHand.transform.rotation = Quaternion.Euler(secondsInt * 360 / 3600, 0, 0);
        minuteHand.transform.rotation = Quaternion.Euler(minutesInt * 6, 0, 0);



        hourHand.transform.rotation = Quaternion.Euler(hoursInt * 30, 0, 0);

    }

}

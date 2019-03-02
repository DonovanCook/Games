using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfSatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int speed = 2;
        int maxSpeed = 2;
        if (speed < maxSpeed)
        {
            Debug.Log("The speed is lower");
        }
        else if (speed > maxSpeed)
        {
            Debug.Log("The speed is greater");
        }
        else 
        {
            Debug.Log("This is the speed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

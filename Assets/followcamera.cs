using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{

[SerializeField] GameObject thingtofollow;

    void LateUpdate()
    {
        transform.position = thingtofollow.transform.position+ new Vector3(0 , 0 , -10);
    }
}


//Note: The postion of camera should be same as the postion of car
//they should follow each other via script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float MoveSpeed = 0.01f;
    [SerializeField] float SlowSpeed = 0.01f;
    [SerializeField] float BoostSpeed = 0.01f;


    void Start()
    {


    }
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

      void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "boost")
        {
            Debug.Log("boost !!!");
            MoveSpeed = BoostSpeed;
          
        }

        if(other.gameObject.tag =="bump")
        {
            Debug.Log("bump !!!");
            MoveSpeed = SlowSpeed;
        }
    }
      void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch !!!");
        MoveSpeed = SlowSpeed;
    }


}

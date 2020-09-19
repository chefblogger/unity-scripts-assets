using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{

    public float movementSpeed = 2f;
    public float rotationSpeed = 200.0f;

    private float nachRechts = 0.1f;
    private float nachLinks = -0.1f;

    private float nachOben = 0.1f;

    private float nachUnten = -0.1f;

    private float drehen = 0.0f;

    public float newSpeed = 0.0f;

    // Update is called once per frame
void FixedUpdate()
    {

        bool isRight = Input.GetKey(KeyCode.RightArrow);
        bool isLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isUp = Input.GetKey(KeyCode.UpArrow);
        bool isDown = Input.GetKey(KeyCode.DownArrow);
        bool drehenLi = Input.GetKey(KeyCode.A);
        bool drehenRe = Input.GetKey(KeyCode.D);
        bool isMoreSpeed = Input.GetKey(KeyCode.W);
        bool isLessSpeed = Input.GetKey(KeyCode.S);
        bool isStop = Input.GetKey(KeyCode.Q);


        if (drehenLi == true)
            {
                drehen = 0.5f;
                Debug.Log ("nach links drehen");
                transform.Rotate(0, 0, 1.0f);
            }

        if (drehenRe == true)
            {
                drehen = -0.5f;
                Debug.Log ("nach Rechts drehen");
                transform.Rotate(0, 0, -1.0f);
            }


        if (isRight == true) 
        {
            Debug.Log ("rechts");
            
            

            transform.Rotate(0, nachRechts * Time.deltaTime * rotationSpeed, 0);
            
        }

        if (isLeft == true) 
        {
            Debug.Log ("links");
            
            transform.Rotate(0, nachLinks * Time.deltaTime * rotationSpeed, 0);
            
        }

        if (isUp == true) 
        {
            Debug.Log ("Oben");
            
            transform.Rotate(nachOben * Time.deltaTime * rotationSpeed,0, 0);
            
        }

        if (isDown == true) 
        {
            Debug.Log ("unten");
            
            transform.Rotate(nachUnten * Time.deltaTime * rotationSpeed,0, 0);
            
        }

        if (isMoreSpeed == true )
            {
               /*transform.Translate(0,0,5f); */
               newSpeed += movementSpeed + 0.1f;
            }
        
        else if (isLessSpeed == true )
            {
               /*transform.Translate(0,0,5f); */
                if (newSpeed < 0.0f )
                    {
                newSpeed = 0.0f;
                    }
                    {
               newSpeed -= movementSpeed - 0.1f;
                    }
            }

        else if ( isStop == true)
            {
                newSpeed = 0.0f;  
            }

        
        
        else {
            transform.Translate(0,0,newSpeed * Time.deltaTime);
        }



            
/*
        if (isForward == true) 
        {
            Debug.Log ("gas geben");
            newSpeed = movementSpeed + newSpeed + 0.1f;
            transform.Translate(0,0,newSpeed);
        }
        else if (isBack == true) 
        {
            Debug.Log ("bremsen");
            newSpeed = movementSpeed - newSpeed - 0.1f;
            transform.Translate(0,0,newSpeed);
        }
        else {
            transform.Translate(0,0,newSpeed);
        }
  */      
        
    }
}

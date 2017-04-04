using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCS : MonoBehaviour {

    public float speed;
    
    
    
    // Update is called once per frame
    void Start()
    {
        
        
    }
    void Update () { // the controls of the player
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }

       

    }
}

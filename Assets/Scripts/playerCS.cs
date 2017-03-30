using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCS : MonoBehaviour {

    public GameObject tower;
    public Vector3 towerPos;
    TowerCs tr;

    
    
    // Update is called once per frame
    void Start()
    {
        
    }
    void Update () { // the controls of the player
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.1f, 0);
        }

       

    }
}

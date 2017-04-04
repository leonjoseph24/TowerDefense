using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MakeCreeps : MonoBehaviour {
    public GameObject[] creeps;
    public Vector3 creepPos;
    float time;
	// Use this for initialization
	void Start () {
        time = 500;
	}
	
	// Update is called once per frame
	void Update () {
        time -= 10;
        if( time <= 1)
        {
            Instantiate(creeps[0], creepPos, Quaternion.identity);
           
            time = 500;
        }
	}
}

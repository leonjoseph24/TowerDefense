using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCs : MonoBehaviour {
    public GameObject player;
    public GameObject bullet;
    public GameObject tower;
    
   
    public GameObject enemy;
    public float bulletSpeed;
   
    // Use this for initialization
    void Start () {

       
	}

    // Update is called once per frame
    void Update()
    {


        Vector3 dist = player.transform.position - transform.position;

        Ray ray = new Ray(transform.position, -Vector3.forward);

        if (Physics.Raycast(ray, 100)&& Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, tower.transform.position, Quaternion.identity);
            bullet.transform.position = Vector3.right;
        }





    }

     
}

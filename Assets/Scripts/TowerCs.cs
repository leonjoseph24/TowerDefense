using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCs : MonoBehaviour {
    public GameObject player;
    public GameObject bullet;
    public GameObject tower;
    
   
    public Vector3[] target;
    public float bulletSpeed;
    float time;
    bool canShoot;
    public goldCS pl;
    // Use this for initialization
    void Start () {
        canShoot = false;
       


    }
     void Awake()
    {
        pl = GameObject.Find("Player").GetComponent<goldCS>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1;

        Vector3 dist = player.transform.position - transform.position;

        Ray ray = new Ray(transform.position, -Vector3.forward);


        
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(ray, 100) && pl.gold>=50 && canShoot ==false )
        {
            canShoot = true;
            Debug.Log("Tower Activated" +pl.gold);
            pl.gold -= 50;
            
        }

        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(ray, 100) && pl.gold <= 50)
        {
            Debug.Log("Insufficient gold" + pl.gold);
        }

        if ( time <= 0 && canShoot)
        {
            GameObject tempBulletHandler;

            tempBulletHandler = Instantiate(bullet, tower.transform.position, Quaternion.identity);
            

            Rigidbody tempRigidBody;
            tempRigidBody = tempBulletHandler.GetComponent<Rigidbody>();

            tempRigidBody.AddForce(target[0] * bulletSpeed);
            
            time = 40;
        }
        if (canShoot == true && Input.GetKey(KeyCode.C) && Physics.Raycast(ray, 100))
        {
            canShoot = false;
            Debug.Log("Tower Deactivated" + pl.gold);
            pl.gold += 30;
            
            
        }





    }

     
}

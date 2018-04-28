using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCs : MonoBehaviour {
    public GameObject player;
    public GameObject bullet;
    public GameObject tower;
    public Material Deactivatedtower;
    public Material activatedtower;
    private bool deactivatedtower;

    
   
    public Vector3[] target;
    public float bulletSpeed;
    float time;
    bool canShoot;
    public goldCS pl;
    // Use this for initialization
    void Start () {
        canShoot = false;

        deactivatedtower = true;

    }
     void Awake()
    {
        pl = GameObject.Find("Player").GetComponent<goldCS>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (deactivatedtower == true)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material = Deactivatedtower;
        }
        time -= 1;

        Vector3 dist = player.transform.position - transform.position;

        Ray ray = new Ray(transform.position, -Vector3.forward);


        
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(ray, 100) && pl.gold>=50 && canShoot ==false )
        {
            deactivatedtower= false;
            Renderer rend = GetComponent<Renderer>();
            rend.material = activatedtower;

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
            deactivatedtower = true;
            canShoot = false;
            Debug.Log("Tower Deactivated" + pl.gold);
            pl.gold += 30;
            
            
        }





    }

     
}

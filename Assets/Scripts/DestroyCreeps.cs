using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyCreeps : MonoBehaviour {



    public float HP;

    public HPCS baseHP;


    // Use this for initialization
    void Start () {
        
    }
     void Awake()
    {
        baseHP = GameObject.Find("Player").GetComponent<HPCS>();

    }

    // Update is called once per frame
    void Update () {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            
            Destroy(other.gameObject);
            HP -= 100;
            Debug.Log("Base Health:"+HP);
            baseHP.health -= 100;

            


        }

        if (HP<= 0 && other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Game Over");
            Debug.Log("Game Over");
            

        }
    }
}

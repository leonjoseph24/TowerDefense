using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyCreeps : MonoBehaviour {

    
    int HP;
    
	// Use this for initialization
	void Start () {
        HP = 1000;
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

            


        }

        if (HP <= 0 && other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Game Over");
            Debug.Log("Game Over");
            

        }
    }
}

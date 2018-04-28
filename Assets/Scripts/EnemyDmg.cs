using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDmg : MonoBehaviour {
    public int enemyHealth;
    public goldCS pl;
    public ScoreCS sc;
    // Use this for initialization
    void Start () {
       
	}

    // Update is called once per frame
     void Awake()
    {
        pl = GameObject.Find("Player").GetComponent<goldCS>();
        sc = GameObject.Find("Player").GetComponent<ScoreCS>();
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            
            enemyHealth -= 1;
            
        }
        if (enemyHealth <= 0)
        {
            Destroy(this.gameObject);
            
            pl.gold +=40;
            Debug.Log("Gold"+pl.gold);
            sc.score += 1;
            Debug.Log("Current Score" + sc.score);
        }
        if (sc.score >= 20)
        {
            SceneManager.LoadScene("Victory");
        }

        
    }
    
}

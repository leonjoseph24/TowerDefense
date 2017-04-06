using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPCS : MonoBehaviour
{
    public float health;
    public GameObject healthTextObj;
    Text healthText;

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        healthText = healthTextObj.GetComponent<Text>();
        healthText.text = "Health:" + health.ToString();
    }
}

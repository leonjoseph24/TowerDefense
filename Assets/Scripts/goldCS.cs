using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldCS : MonoBehaviour {
    public int gold;
    public GameObject goldTextObj;
    Text goldText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        goldText = goldTextObj.GetComponent<Text>();
        goldText.text = "Gold:" + gold.ToString();
	}


}

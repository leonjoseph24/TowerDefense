using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour
{

    public GameObject[] Path;
    int target;
    public float speed;

    // Use this for initialization
    void Start()
    {
        target = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Path[target].transform.position) < 0.01 && target < Path.Length - 1)  // to calculate the distance between the enemy and the waypoint.
        {
            target++;
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, Path[target].transform.position, speed); // to move the enemy from its initial position to the waypoint.
        }
    }
}

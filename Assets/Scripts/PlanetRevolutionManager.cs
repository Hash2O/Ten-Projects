using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRevolutionManager : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    [SerializeField] GameObject target;
    //[SerializeField] GameObject plan;
    [SerializeField] float revolutionSpeed;

    void Start()
    {
        target = GameObject.Find("Sun");
        //plan = GameObject.Find("Plan");
    }

    void Update()
    {
        // Spin the object around the target at revolutionSpeed/second.
        transform.RotateAround(target.transform.position, Vector3.up, revolutionSpeed * Time.deltaTime);
    }
}

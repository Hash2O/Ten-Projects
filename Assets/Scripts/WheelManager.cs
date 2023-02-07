using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelManager : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float revolutionSpeed;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Axis");
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, revolutionSpeed * Time.deltaTime);
    }
}

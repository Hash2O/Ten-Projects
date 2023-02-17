using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTurningWheelManager : MonoBehaviour
{
    [SerializeField] GameObject handController;
    [SerializeField] GameObject axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Vector3.Distance(transform.position, handController.transform.position) < 1)
        {
            transform.LookAt(handController.transform);
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        axis.transform.LookAt(handController.transform);
    }
}

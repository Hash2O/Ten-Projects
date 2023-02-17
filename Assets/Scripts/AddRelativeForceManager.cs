using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRelativeForceManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }

}

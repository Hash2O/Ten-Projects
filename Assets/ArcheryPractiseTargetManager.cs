using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArcheryPractiseTargetManager : MonoBehaviour
{
    public float _zSpeed = 1.0f;
    private Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        //Déplacement
        transform.Translate(direction * Time.deltaTime);

        //Conditions
        if (transform.position.z > -.1f)
        {
            //Debug.Log("Depart");
            direction = new Vector3(0, 0 , -_zSpeed);
        }
        else if (transform.position.z <= - 1f)
        {
            //Debug.Log("Au dela de la limite");
            direction = new Vector3(0, 0, _zSpeed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Arrow"))
        {
            //Code to write here
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGrenadeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform explosionPrefab;

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        Instantiate(explosionPrefab, position, rotation);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatlingManager : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    [SerializeField] GameObject target;
    [SerializeField] float revolutionSpeed;

    [SerializeField] GameObject _projectilePrefab;
    [SerializeField] GameObject _projectileSpawnPoint;

    private void Start()
    {
        target = GameObject.Find("Gatling Gun");
        revolutionSpeed = 500;
    }

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.forward, revolutionSpeed * Time.deltaTime);
    }

    public void OnShoot()
    {
        Instantiate(_projectilePrefab, _projectileSpawnPoint.transform.position, _projectileSpawnPoint.transform.rotation);
    }
}

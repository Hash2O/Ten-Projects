using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingDroneManager : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] float _trainingDistance;
    [SerializeField] float _speed;
    [SerializeField] float revolutionSpeed;
    [SerializeField] GameObject _trainingProjectile;

    [SerializeField] private bool isCloseEnough;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        _trainingDistance = 2f;
        _speed = 1f;
        revolutionSpeed = Random.Range(10, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime;
        //print(time);
    }

    public void closingDistance()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) > _trainingDistance)
        {
            print("Closing distance with target");
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
        }
        else if (Vector3.Distance(transform.position, _player.transform.position) < _trainingDistance)
        {
            print("Keeping distance with target");
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, - _speed * Time.deltaTime);
        }

        if(Vector3.Distance(transform.position, _player.transform.position) <= _trainingDistance)
        {
            isCloseEnough = true;
        }
    }

    public void trainingMode()
    {
        if (isCloseEnough)
        {
            print("Starting Training Mode");
            Transform axis = _player.GetComponentInChildren<Transform>();
            transform.LookAt(_player.transform.position);
            transform.RotateAround(_player.transform.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
    }

    public void fireMode()
    {
        print("Beginning fire at the target");
        Instantiate(_trainingProjectile, transform.position, transform.rotation);
        Rigidbody _trainingProjectileRb = _trainingProjectile.GetComponent<Rigidbody>();
        Vector3 direction = transform.position - _player.transform.position;
        _trainingProjectileRb.AddForce(direction * 100f, ForceMode.Impulse);
    }
}

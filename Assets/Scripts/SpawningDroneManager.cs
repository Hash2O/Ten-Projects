using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningDroneManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        if(transform.position.z < 10)
        {
            gameObject.SetActive(false);
        }
    }
}

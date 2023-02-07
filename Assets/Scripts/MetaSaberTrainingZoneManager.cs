using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaSaberTrainingZoneManager : MonoBehaviour
{
    [SerializeField] TrainingDroneManager trainingDrone1;
    [SerializeField] TrainingDroneManager trainingDrone2;
    [SerializeField] MetaSaberTrainingZoneLightsManager lights;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print("Entering training zone");
        lights.ToggleLights(); 
    }

    void OnTriggerStay(Collider other)
    {
        trainingDrone1.closingDistance();
        trainingDrone1.trainingMode();
    }

    void OnTriggerExit(Collider other)
    {
        print("Exiting training zone");
        lights.ToggleLights();
    }
}

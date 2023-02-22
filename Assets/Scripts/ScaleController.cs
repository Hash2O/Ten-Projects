using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ScaleController : MonoBehaviour
{
    public float scaleSpeed = 1f;
    private XRGrabInteractable grabInteractable;
    private Vector3 initialScale;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        initialScale = transform.localScale;
    }

    private void Update()
    {
        if (grabInteractable.isSelected)
        {
            float distance = Vector2.Distance(grabInteractable.selectingInteractor.GetComponent<XRController>().inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position) ? position : Vector2.zero, Vector2.zero);
            float scaleFactor = 1.0f + distance * scaleSpeed;
            transform.localScale = initialScale * scaleFactor;
        }
        else
        {
            transform.localScale = initialScale;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

//Version chatGPT

//Ce code attache un XRGrabInteractable � la roue pour que l'utilisateur puisse la saisir. La rotation de la roue est bas�e sur la
//valeur de l'axe x du stick analogique du contr�leur de l'utilisateur. La vitesse de rotation de la roue peut �tre ajust�e avec la variable rotationSpeed.

//Dans la m�thode GetRotationAmount(), nous parcourons la liste des InputDevice connect�s pour r�cup�rer la valeur de l'axe x du stick analogique. Ensuite,
//nous retournons cette valeur, en la limitant � une plage de -1 � 1.

//Dans la m�thode Update(), si la roue est s�lectionn�e par l'utilisateur, nous appelons GetRotationAmount() pour r�cup�rer la quantit� de rotation de la
//roue et appliquons cette rotation � la roue en fonction de la vitesse de rotation d�finie. Si la roue n'est pas s�lectionn�e, nous la faisons revenir �
//sa position d'origine avec une rotation graduelle.

public class WheelController : MonoBehaviour
{
    public float rotationSpeed = 5f;

    private XRGrabInteractable interactable;
    private Quaternion originalRotation;

    void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
        originalRotation = transform.rotation;
    }

    void Update()
    {
        if (interactable.isSelected)
        {
            float rotationAmount = GetRotationAmount();
            Quaternion rotation = Quaternion.Euler(0, -rotationAmount * rotationSpeed, 0);
            transform.rotation = rotation * transform.rotation;
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, originalRotation, Time.deltaTime * rotationSpeed);
        }
    }

    float GetRotationAmount()
    {
        float rotationAmount = 0f;
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);

        foreach (var device in devices)
        {
            if (device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position))
            {
                rotationAmount += position.x;
            }
        }

        return Mathf.Clamp(rotationAmount, -1f, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] private List<AudioClip> audioClips;
    [SerializeField] private int _ammo;
    private int _maxBullet;
    // Start is called before the first frame update
    void Start()
    {
        _maxBullet = _ammo;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShoot()
    {
        if (_ammo > 0)
        {
            audioSource.clip = audioClips[0];
            audioSource.Play();
            laserFiring();
            _ammo--;
            
        }

        if (_ammo == 0)
        {
            audioSource.clip = audioClips[2];
            audioSource.Play();
        }

    }

    public void OnReload()
    {
        audioSource.clip = audioClips[1];
        audioSource.Play();
        _ammo = _maxBullet;
    }

    void laserFiring()
    {
        //Ici, insérer le code pour un raycast afin de simuler le laser
        //NB : Penser à récupérer le rigidbody de la cible, afin de lui imprimer une force et/ou une marque pour simuler la touche
    }
}

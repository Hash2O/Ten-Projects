using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrowdManager : MonoBehaviour
{
    private Animator _animatorAnim;

    // Start is called before the first frame update
    void Start()
    {
        _animatorAnim = GetComponent<Animator>();

        //Gère le décalage dans les animations
        _animatorAnim.SetFloat("offset", Random.Range(0.0f, 1.0f));

        StartCoroutine(clappingAnimation());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator clappingAnimation()
    {
        for(int i = 0; i < 100; i++)
        {
            _animatorAnim.SetBool("isClapping", true);
            yield return new WaitForSeconds(2.0f);
            _animatorAnim.SetBool("isClapping", false);
            yield return new WaitForSeconds(Random.Range(5.0f, 10.0f));
        }
        
    }

    public void noClappingAnimation()
    {
        _animatorAnim.SetBool("isClapping", false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaireController : MonoBehaviour
{

    Animator claireAnimator;

    float axeisH, axisV;

    [SerializeField]
    float walkSpeed = 2f, runSpeed = 4f;

    private void Awake()
    {
        claireAnimator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        axeisH = Input.GetAxis("Horizontal");
        axisV = Input.GetAxis("Vertical");

        if (axisV > 0)
        {
            transform.Translate(Vector3.forward * walkSpeed * axisV * Time.deltaTime);
            claireAnimator.SetBool("walk", true);
        }
        else
        {
            claireAnimator.SetBool("walk", false);
        }
    }
}

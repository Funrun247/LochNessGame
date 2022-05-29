using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class hand : MonoBehaviour
{

    Animator animator;
    private float triggerTarget;
    private float gripTarget;

    private float gripCurrent;
    private float triggerCurrent;
    public float speed;
    private string animatorgripparam = "Grip";
    private string animatortriggerparam = "Trigger";


    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();

        }

    // Update is called once per frame
    void Update()
    {
        Animatehand();
      
        
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void Animatehand()
    {
        if (gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorgripparam, gripCurrent);
        } 
        
        if (triggerCurrent != triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat(animatortriggerparam, triggerCurrent);
        }
    }
}

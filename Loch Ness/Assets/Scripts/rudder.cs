using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class rudder : MonoBehaviour
{

    public XRDirectInteractor rHand;
    public XRDirectInteractor lHand;

    public Transform target;


    public Transform lefthandtransform;
    public Transform righthandtransform;

    public float turnspeed;

    public Quaternion startpos;
    public Transform boat;

    public bool grabbed;

    public void Start()
    {
        startpos = this.transform.localRotation;
        

    }
    public void Update()
    {
        transform.position = boat.position;

      

        if (grabbed == true)
        {


            Vector3 targetPostition = new Vector3(target.position.x, this.transform.position.y, target.position.z);

            var targetRotation = Quaternion.LookRotation(targetPostition - transform.position);

            transform.localRotation = Quaternion.Slerp(transform.rotation, targetRotation, turnspeed * Time.deltaTime);

        }

    }


    public void pickhand()
    {
        float leftdist = Vector3.Distance(lefthandtransform.position, transform.position);
        float rightdist = Vector3.Distance(righthandtransform.position, transform.position);

        if (leftdist > rightdist)
        {
            target = righthandtransform;
        }

        if (leftdist < rightdist)
        {
            target = lefthandtransform;
        }
    }


    
   


        public void isgrabbed()
        {
            grabbed = true;

        }

        public void ungrabbed()
        {
            grabbed = false;

        }

    }


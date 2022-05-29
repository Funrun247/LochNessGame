using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatscript : MonoBehaviour
{
    public GameObject rudder;
    public Transform thrustpoint;

    Rigidbody m_Rigidbody;
    public float m_Thrust = 10f;
    public float maxSpeed = 30;
    private bool go;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    public void engineon()
    {

        go = true;
        
    }

    public void engineoff()
    {

        go = false;

    }

    public void FixedUpdate()
    {
        m_Rigidbody.velocity = Vector3.ClampMagnitude(m_Rigidbody.velocity, maxSpeed);

        if (go == true)
        {

            m_Rigidbody.AddForceAtPosition(thrustpoint.transform.forward * m_Thrust, thrustpoint.transform.position);
            

        }
    }
}


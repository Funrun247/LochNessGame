using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sit : MonoBehaviour
{

    public MonoBehaviour contmovement;
    public Transform sitpoint;
    public bool sitting;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (sitting == true)
            {
            this.transform.position = sitpoint.transform.position;
        }

    }

    public void sitdown()
    {
        sitting = true;
        contmovement.enabled = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floater : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float DepthBeforeSubmerged = 1f ;

    public float displacementamount = 3f;

    private void FixedUpdate()
    {
      

        if (transform.position.y < 0f)
        {
            float displacementmultiplier = Mathf.Clamp01(-transform.position.y / DepthBeforeSubmerged) * displacementamount;
            rigidBody.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementmultiplier, 0f), ForceMode.Acceleration); 
        }
    }
}

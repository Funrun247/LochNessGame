using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changelayeronhold : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void held()
    {
        gameObject.layer = LayerMask.NameToLayer("Held");
    }

    public void unheld()
    {
        gameObject.layer = LayerMask.NameToLayer("Default");
    }
}

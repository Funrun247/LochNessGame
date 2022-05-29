using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radarreveal : MonoBehaviour

    
{
    public float timetofade = 1f;
    private Color alphaColor;
    private Color seencolor;
    private bool pinging;
    public float timeseen = 3f;
    // Start is called before the first frame update
    void Start()
    {
        alphaColor = this.GetComponent<Renderer>().material.color;
        alphaColor.a = 1;
        seencolor = this.GetComponent<Renderer>().material.color;
        seencolor.a = 0;

        GetComponent<Renderer>().material.color = alphaColor;

        pinging = false;

    }

    private void Update()
    {
        if (pinging == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(alphaColor, seencolor, timetofade * Time.deltaTime);

        }

        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(seencolor, alphaColor, timetofade * Time.deltaTime);

        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Line")
        {
            StartCoroutine(ping());
        }
    }

    IEnumerator ping()
    {
        Debug.Log("comin");

        pinging = true;

        yield return new WaitForSeconds(timeseen);

        Debug.Log("goin");

        pinging = false;





    }
}

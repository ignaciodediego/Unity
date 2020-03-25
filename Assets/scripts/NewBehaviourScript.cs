using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        Vector3 posicionInicial = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        Vector3[] positions = new Vector3[2] { new Vector3(0, 0, 0),  posicionInicial};
        lineRenderer.startWidth     = 0.05f;
        lineRenderer.endWidth       = 0.05f;
        lineRenderer.startColor     = new Color(1,1,1,1);
        lineRenderer.endColor       = new Color(1,1,1,1);
        lineRenderer.positionCount  = 2;
        lineRenderer.SetPositions(positions);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-10f * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(10f * Time.deltaTime, 0, 0);

            Vector3 posicionInicial2 = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Vector3[] positions2 = new Vector3[2] { new Vector3(0, 0, 0), posicionInicial2 };
            lineRenderer.SetPositions(positions2);
        }
        if (Input.GetKey("up"))
        {
            gameObject.transform.Translate(0, 10f * Time.deltaTime, 0);
        }
        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(0, -10f * Time.deltaTime, 0);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("left"))
        {
            this.OnDrawGizmosSelected();
            gameObject.transform.Translate(-10f * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(10f * Time.deltaTime, 0, 0);
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

    void OnDrawGizmosSelected()
    {
        
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.white;
            Gizmos.DrawLine(gameObject.GetComponent<Transform>().position, new Vector3(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.y - 1, gameObject.GetComponent<Transform>().position.z));

    }
}

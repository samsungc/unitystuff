using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private float direction = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);

        if (transform.position.y > 0.60){
            direction = -1;
        }
        else if (transform.position.y < 0.4){
            direction = 1;
        }
        
        transform.position = new Vector3(transform.position.x, transform.position.y + (direction * Time.deltaTime / 5) , transform.position.z);
    }
}

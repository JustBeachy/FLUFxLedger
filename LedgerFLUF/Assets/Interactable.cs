using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    float lastXspeed, lastYspeed;
    bool notTouched = true;
    public int rotationSpeed=100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(notTouched)
            transform.Rotate(Vector3.up,rotationSpeed*Time.deltaTime, Space.World);

        if (Input.GetMouseButton(0))//for pc testing
        {
            notTouched = false;

            float rotX = Input.GetAxis("Mouse X") * 200 * Time.deltaTime;
            float rotY = Input.GetAxis("Mouse Y") * 200 * Time.deltaTime;

            lastXspeed = -rotX;
            lastYspeed = rotY;

            transform.Rotate(Vector3.up, -rotX, Space.World);
            transform.Rotate(Vector3.right, rotY, Space.World);
        }
        else
        {
            if (Mathf.Abs(lastXspeed) > .5f)
                lastXspeed = .5f * Mathf.Sign(lastXspeed);
            if (Mathf.Abs(lastYspeed) > .5f)
                lastYspeed = .5f * Mathf.Sign(lastYspeed);

            transform.Rotate(Vector3.up, lastXspeed, Space.World);
            transform.Rotate(Vector3.right, lastYspeed, Space.World);
            lastXspeed = lastXspeed / 1.002f;
            lastYspeed = lastYspeed / 1.002f;
        }

       /* if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            notTouched = false;

            float rotX = Input.GetTouch(0).deltaPosition.x * 5 * Time.deltaTime;
            float rotY = Input.GetTouch(0).deltaPosition.y * 5 * Time.deltaTime;

            lastXspeed = -rotX;
            lastYspeed = rotY;

            transform.Rotate(Vector3.up, -rotX, Space.World);
            transform.Rotate(Vector3.right, rotY, Space.World);
        }
        else
        {
            if (Mathf.Abs(lastXspeed) > 1)
                lastXspeed = 4 * Mathf.Sign(lastXspeed);
            if (Mathf.Abs(lastYspeed) > 1)
                lastYspeed = 4 * Mathf.Sign(lastYspeed);

            transform.Rotate(Vector3.up, lastXspeed, Space.World);
            transform.Rotate(Vector3.right, lastYspeed, Space.World);
            lastXspeed = Mathf.Sign(lastXspeed) * (Mathf.Abs(lastXspeed) / 1.001f);
            lastYspeed = Mathf.Sign(lastXspeed) * (Mathf.Abs(lastXspeed) / 1.001f);
        }
        */

    }
}

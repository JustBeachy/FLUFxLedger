using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyObject()
    {
        Destroy(gameObject.transform.parent.gameObject);
        Destroy(gameObject);
    }
}

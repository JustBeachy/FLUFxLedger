using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDestroy : MonoBehaviour
{
    public GameObject objectToDestroy, objectToCreate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    public void CreateObject()
    {
        Instantiate(objectToCreate, GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}

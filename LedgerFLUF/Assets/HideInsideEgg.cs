using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInsideEgg : MonoBehaviour
{
    public GameObject[] Eggs;
    // Start is called before the first frame update
    void Start()
    {
        Eggs = GameObject.FindGameObjectsWithTag("Egg");
        int rand = Random.Range(0, Eggs.Length);
        transform.position = (Eggs[rand].transform.position + new Vector3(0, .05f, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEgg : MonoBehaviour
{
    public Material[] mats;
    public GameObject topEgg;
    public bool isTheOne = false;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, mats.Length);
        GetComponent<MeshRenderer>().material = mats[rand];
        topEgg.GetComponent<MeshRenderer>().material = mats[rand];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameObject.GetComponentInChildren<Animator>().SetBool("Open", true);
    }
}

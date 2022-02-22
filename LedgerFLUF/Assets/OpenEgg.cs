using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEgg : MonoBehaviour
{
    public Material[] mats;
    public GameObject topEgg;
    public GameObject candy;
    float pitch;
    public bool canOpen = true;
    // Start is called before the first frame update
    void Start()
    {
        pitch = Random.Range(.8f, 1.1f);

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
        bool flag = false;   

        if (!gameObject.GetComponentInChildren<Animator>().GetBool("Open")&&canOpen)
        {
            GetComponent<AudioSource>().pitch = pitch;
            GetComponent<AudioSource>().Play();

            if (candy != null)
            {
                candy.GetComponent<AudioSource>().Play();
                flag = true;
            }
        }

        if (canOpen)
        {
            

            gameObject.GetComponentInChildren<Animator>().SetBool("Open", true);

            if (flag)
            {
                foreach (GameObject g in GameObject.FindGameObjectsWithTag("Egg"))
                    g.GetComponent<OpenEgg>().canOpen = false;
            }
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public GameObject objectToShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseAnimation()
    {
        GetComponent<Animation>().enabled = false;
    }

    public void ShowGameObject()
    {
        objectToShow.SetActive(true);
    }
}

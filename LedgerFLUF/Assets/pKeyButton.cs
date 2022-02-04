using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pKeyButton : MonoBehaviour
{
    public Text myText, Keyguess;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLetter()
    {
        Keyguess.text += myText.text;
    }
}

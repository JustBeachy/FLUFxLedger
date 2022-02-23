using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinCodeButton : MonoBehaviour
{
    public Text PINtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyLetter()
    {
        if (PINtext.text.Length < 4)
        {
            PINtext.text = PINtext.text.Trim('-');
            PINtext.text += GetComponentInChildren<Text>().text;

            int newlength = PINtext.text.Length;
            for (int i = 4; i > newlength; i--)
            {
                PINtext.text += "-";
            }

            if (PINtext.text.Length >=4)
            {
                //PINtext do something
            }

        }


    }
}

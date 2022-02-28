using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinCodeButton : MonoBehaviour
{
    public Text PINtext;
    public GameObject TitleText;
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
        TitleText.GetComponent<AudioSource>().Play();
        PINtext.text = PINtext.text.Trim('-');
        if (PINtext.text.Length < 4)
        {
            
            PINtext.text += GetComponentInChildren<Text>().text;

            if (PINtext.text.Length >= 4)
            {
                PINtext.text = "****";
                TitleText.GetComponent<PINtitle>().isWrong = true;
                //PINtext do something
            }


            int newlength = PINtext.text.Length;
            for (int i = 4; i > newlength; i--)
            {
                PINtext.text += "-";
            }

           

        }


    }
}

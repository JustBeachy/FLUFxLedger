using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPhraseButton : MonoBehaviour
{
    public Text seedPhrase;
    Text myText;
    Image myButton;
    public bool clicked=false;
    public GameObject audioCorrect, audioWrong;

    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
        myButton = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed()
    {
        if (seedPhrase.text.Contains(myText.text))
        {
            if (!clicked)
                audioCorrect.GetComponent<AudioSource>().Play();

            myButton.color = Color.green;

            clicked = true;

            GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");

            int count = 0;
            foreach (GameObject b in buttons)
            {
                if (b.GetComponent<KeyPhraseButton>().clicked)
                    count++;
            }

            if (count >= 12)
                print("Do something ");
        }
        else
        {
            myButton.color = Color.red;
            audioWrong.GetComponent<AudioSource>().Play();
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Private key:  c97b246e294b84351c08ab94b5540b2469c9e06a63ab5d717f25144f1a6449c4
//Public key:  9d5fea9f54e38276ed51ad840bed6a51b61e2c48067f56ee119c2a018c9b887860f9ec6f6a100070be203fcf30efd84633390533b37c0b3e9f8d0715ae15d7fa
//Address: 0xbf0a5cf3248ddc7c1ee8e5edc5f550ab25f83b34


public class pKeyButton : MonoBehaviour
{
    string privateKey = "c97b246e294b84351c08ab94b5540b2469c9e06a63ab5d717f25144f1a6449c4";
    public Text myText, Keyguess;
    public bool canPress = true;
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
        if (canPress)
        {
            Keyguess.text += myText.text;

            char[] privArray = privateKey.ToCharArray();
            char[] guessArray = Keyguess.text.ToCharArray();

            bool isMatching = true;
            for (int i = 0; i < guessArray.Length; i++)
            {
                if (guessArray[i] != privArray[i])
                    isMatching = false;

            }

            if (!isMatching)
            {
                Keyguess.text = "Wrong character. Number of characters you entered correctly: " + (guessArray.Length - 1).ToString();

                GameObject[] allButtons = GameObject.FindGameObjectsWithTag("Button");
                foreach (GameObject b in allButtons)
                    b.GetComponent<pKeyButton>().canPress = false;
            }

            if (guessArray.Length == 64 && isMatching)
            {
                Keyguess.text = "I think you cheated!";

                GameObject[] allButtons = GameObject.FindGameObjectsWithTag("Button");
                foreach (GameObject b in allButtons)
                    b.GetComponent<pKeyButton>().canPress = false;
            }
        }

    }
}

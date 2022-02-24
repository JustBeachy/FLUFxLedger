using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PINtitle : MonoBehaviour
{
    public Text pinText;
    public bool isWrong = false;
    public float timer = 0;
    public int tries = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if(isWrong)
        {
            GetComponent<Text>().text = "Invalid PIN code";
            timer += Time.deltaTime;
        }

        if(timer>2f)
        {
            tries++;

            if (tries >= 3)
            {
                GetComponent<Text>().text = "Your device has been reset";
                pinText.text = "";
            }
            else
            {
                GetComponent<Text>().text = (3 - tries).ToString() + " remaining attempt(s).";

                pinText.text = "----";
                isWrong = false;
                timer = 0;
            }
        }

    }
}

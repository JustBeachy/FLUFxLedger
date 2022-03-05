using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PINtitle : MonoBehaviour
{
    public Text pinText;
    public bool isWrong = false;
    public float timer = 0;
    public int tries = 0;
    float nextTimer = 0;
    bool startnextTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startnextTimer)
        {
            nextTimer += Time.deltaTime;
        }
        if(nextTimer>2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        if (isWrong)
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
                startnextTimer = true;
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

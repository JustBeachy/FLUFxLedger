using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyPhraseButton : MonoBehaviour
{
    public Text seedPhrase;
    Text myText;
    Image myButton;
    public bool clicked=false;
    public GameObject audioCorrect, audioWrong;
    bool startTimer = false;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
        myButton = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(startTimer)
        timer += Time.deltaTime;

        if(timer>.5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
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
                startTimer = true;
        }
        else
        {
            myButton.color = Color.red;
            audioWrong.GetComponent<AudioSource>().Play();
        }
    }
}

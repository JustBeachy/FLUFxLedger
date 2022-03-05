using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizQuestion : MonoBehaviour
{

    public Text questionText;
    public bool isAnswer;
    public Scene NextQuestionScene;
    float timer;
    bool correctlyGuessed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correctlyGuessed)
            timer += Time.deltaTime;

        if (timer >= 2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ButtonPressed()
    {
        if (!GetComponent<AudioSource>().isPlaying&&!correctlyGuessed)
            GetComponent<AudioSource>().Play();

        if (isAnswer)
        {
            GetComponent<Image>().color = Color.green;
            correctlyGuessed = true;
            questionText.text = "Correct!";
            questionText.color = Color.green;
        }
        else
            GetComponent<Image>().color = Color.red;
        }
}

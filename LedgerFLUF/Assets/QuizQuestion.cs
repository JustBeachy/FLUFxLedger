using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizQuestion : MonoBehaviour
{
    
   
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
            print("load next scene");//go to next scene
    }

    public void ButtonPressed()
    {
        if (isAnswer)
        {
            GetComponent<Image>().color = Color.green;
            correctlyGuessed = true;
        }
        else
            GetComponent<Image>().color = Color.red;
        }
}

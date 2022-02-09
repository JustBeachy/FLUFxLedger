using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizQuestion : MonoBehaviour
{
    public Text Question;
    public GameObject A1, A2, A3, A4;
    public bool isAnswer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckIfAnswer()
    {
        if (isAnswer)
            ;//do something;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeText : MonoBehaviour
{
    public Text textObject;
    public string textToWrite;
    string currentText = "";
    // Start is called before the first frame update
    void Start()
    {
        textToWrite = textObject.text;
        textObject.text = "";
        StartCoroutine(TypeTheText());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator TypeTheText()
    {
        for (int i = 0; i <= textToWrite.Length; i++)
        {
            currentText = textToWrite.Substring(0, i);
            textObject.text = currentText;

            if (currentText.Length > 1 && currentText[currentText.Length - 1] == '.')
                yield return new WaitForSeconds(.5f);
            else
                yield return new WaitForSeconds(.05f);
        }
        

    }
}
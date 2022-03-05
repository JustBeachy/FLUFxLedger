using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickAPixelGame : MonoBehaviour
{
    public GameObject pixel;
    public Text titleText;
    float timer = 0;

    bool missclicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MissedThePixel()
    {
        if (!missclicked && !GetComponent<AudioSource>().isPlaying)
            GetComponent<AudioSource>().Play();
        missclicked = true;
        pixel.GetComponent<Image>().enabled = true;
        pixel.transform.localScale = new Vector2(4, 4);
        titleText.text = "You missed it. See how impossible this is?";
        titleText.color = Color.red;

    }
    // Update is called once per frame
    void Update()
    {
        if (missclicked == false)
            titleText.text = "Try to select the hidden pixel " + pixel.GetComponent<HiddenPixel>().count + " times in a row.";
        else
            timer += Time.deltaTime;

        if(timer>2.5)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

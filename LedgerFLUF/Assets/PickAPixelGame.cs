using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickAPixelGame : MonoBehaviour
{
    public GameObject pixel;
    public Text titleText;

    bool missclicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MissedThePixel()
    {
        missclicked = true;
        pixel.GetComponent<Image>().enabled = true;
        pixel.transform.localScale = new Vector2(4, 4);
        titleText.text = "You missed it. See how difficult this would be?";
    }
    // Update is called once per frame
    void Update()
    {
        if(missclicked==false)
        titleText.text = "Try to select the hidden pixel " + pixel.GetComponent<HiddenPixel>().count + " times in a row.";
    }
}

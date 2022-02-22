using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenPixel : MonoBehaviour
{
    public int count = 13;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(0, 1200), Random.Range(0, 750));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickedPixel()
    {
        if (count > 1)
        {
            count--;
            Start();
        }
    }
}

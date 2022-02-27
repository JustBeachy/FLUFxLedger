using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideInsideEgg : MonoBehaviour
{
    public GameObject[] Eggs;
    public static int OpenedCount;
    public Text ScoreText;
    public GameObject GameOverScreen;
    public bool found = false;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        HideInsideEgg.OpenedCount = 0;
        Eggs = GameObject.FindGameObjectsWithTag("Egg");
        int rand = Random.Range(0, Eggs.Length);
        transform.position = (Eggs[rand].transform.position + new Vector3(0, 0, 0));
        Eggs[rand].GetComponent<OpenEgg>().candy = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (HideInsideEgg.OpenedCount > 0)
        {
            ScoreText.text = "Empty eggs you've opened: " + OpenedCount.ToString();
            if(found)
                ScoreText.text = "You mined the candy!";
        }

        if(found)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("MoveTowards").transform.position, .01f);
            
            //found = false;
            timer += Time.deltaTime;
        }

        if(timer>=2)
        {
            timer = 0;
            found = false;
            Instantiate(GameOverScreen, GameObject.FindGameObjectWithTag("Canvas").transform);
        }
    }
}

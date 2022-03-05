using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationScript : MonoBehaviour
{
    public GameObject objectToShow;
    public GameObject objectToDestroy, UIObjectToCreate;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void DestroyObject()
    {
        Destroy(objectToDestroy);
    }

    public void PauseAnimation()
    {
        GetComponent<Animation>().enabled = false;
    }

    public void ShowGameObject()
    {
        objectToShow.SetActive(true);
    }

    public void GoToNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DestroyComponent()
    {
        Destroy(transform.parent.gameObject.GetComponent<Interactable>());
    }

    public void CreateUIObject()
    {
        Instantiate(UIObjectToCreate, GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}

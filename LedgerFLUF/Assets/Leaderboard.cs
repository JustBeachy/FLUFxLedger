using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.IO;
using System;

public class Leaderboard : MonoBehaviour
{
    public GameObject content, scoreEntry;
    public bool postScore = false;
    public Text generatedNameText;
    public Text scoreText;
    string genName;

    private void Start()
    {
        if (postScore)
        {
            genName = GeneratedName();
            GetComponent<Leaderboard>().PostScores(genName, (int)HideInsideEgg.OpenedCount);

            if (generatedNameText!=null)
            generatedNameText.text = "Your generated name:\n" + genName;

            if (scoreText != null)
                scoreText.text = "Score: " + HideInsideEgg.OpenedCount.ToString();
        }
        else
            GetComponent<Leaderboard>().RetrieveScores();
    }




    private const string highscoreURL = "https://rationalistic-swall.000webhostapp.com/ledgerleaderboard.php";

    public List<Score> RetrieveScores()
    {
        List<Score> scores = new List<Score>();
        StartCoroutine(DoRetrieveScores(scores));
        return scores;
    }

    public void PostScores(string name, int score)
    {
        StartCoroutine(DoPostScores(name, score));
    }

    IEnumerator DoRetrieveScores(List<Score> scores)
    {
        WWWForm form = new WWWForm();
        form.AddField("retrieve_leaderboard", "true");

        using (UnityWebRequest www = UnityWebRequest.Post(highscoreURL, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {

                string contents = www.downloadHandler.text;
                using (StringReader reader = new StringReader(contents))
                {
                    string line;
                    int count = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Score entry = new Score();
                        entry.name = line;
                        try
                        {
                            Debug.Log("Successfully retrieved scores!");
                            entry.score = Int32.Parse(reader.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Debug.Log("Invalid score: " + e);
                            continue;
                        }


                        scores.Add(entry);
                        GameObject scoreContent = Instantiate(scoreEntry, content.transform);
                        scoreContent.GetComponent<ScoreListing>().playerName.text = entry.name;
                        scoreContent.GetComponent<ScoreListing>().score.text = entry.score.ToString();
                        scoreContent.GetComponent<ScoreListing>().rank.text = "#" + count;
                        if (entry.name == GameObject.FindGameObjectWithTag("GameOver").GetComponent<Leaderboard>().genName)///////////////////////////////////////////////////
                        {
                            scoreContent.GetComponent<Image>().color = Color.yellow;
                        }
                        count++;
                    }
                }
            }
        }
    }

    IEnumerator DoPostScores(string name, int score)
    {
        WWWForm form = new WWWForm();
        form.AddField("post_leaderboard", "true");
        form.AddField("name", name);
        form.AddField("score", score);

        using (UnityWebRequest www = UnityWebRequest.Post(highscoreURL, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Successfully posted score!");
            }
        }
    }

    public string GeneratedName()
    {
        List<string> furList = new List<string>();
        furList.Add("Grey");
        furList.Add("Winter");
        furList.Add("Brown");
        furList.Add("Sandy");
        furList.Add("Darkness");
        furList.Add("Peppermint");
        furList.Add("Orange");
        furList.Add("Red");
        furList.Add("Sky");
        furList.Add("Camo");
        furList.Add("Zebra");
        furList.Add("Tiger");
        furList.Add("Cow");
        furList.Add("Cheetah");
        furList.Add("Marshmellow");
        furList.Add("Smoothie");
        furList.Add("Parrot");
        furList.Add("Bully");
        furList.Add("Highlighter");
        furList.Add("Hawk");
        furList.Add("Retro");
        furList.Add("Guernica");
        furList.Add("Pheonix");
        furList.Add("Zombie");
        furList.Add("Barney");
        furList.Add("Grinch");
        furList.Add("Kandinsky");
        furList.Add("Hirst");
        furList.Add("Kanagawa");
        furList.Add("Blossom");
        furList.Add("Avatar");
        furList.Add("Holographic");
        furList.Add("Silver");
        furList.Add("Gold");

        List<string> bgList = new List<string>();
        bgList.Add("Mansion");
        bgList.Add("Beach");
        bgList.Add("Heaven");
        bgList.Add("Backalley");
        bgList.Add("Swamp");
        bgList.Add("Tiki");
        bgList.Add("Spaceship");
        bgList.Add("Dunes");
        bgList.Add("Lambo");
        bgList.Add("Markets");
        bgList.Add("Garden");
        bgList.Add("Gallery");
        bgList.Add("Forest");

        List<string> clothesList = new List<string>();
        clothesList.Add("Beanie");
        clothesList.Add("Bandana");
        clothesList.Add("Tuft");
        clothesList.Add("Mohawk");
        clothesList.Add("Afro");
        clothesList.Add("Mullet");
        clothesList.Add("Sombrero");
        clothesList.Add("Tuft");
        clothesList.Add("Mohawk");
        clothesList.Add("Halo");
        clothesList.Add("Kimono");
        clothesList.Add("Dress");

        List<string> sexList = new List<string>();
        sexList.Add("Male");
        sexList.Add("Female");


        return bgList[UnityEngine.Random.Range(0, bgList.Count)] + " " + furList[UnityEngine.Random.Range(0, furList.Count)] + " " + clothesList[UnityEngine.Random.Range(0, clothesList.Count)] + " " + sexList[UnityEngine.Random.Range(0, sexList.Count)] + " " + "FLUF";
    }
}

public struct Score
{
    public string name;
    public int score;
}



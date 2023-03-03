using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryEnd : MonoBehaviour
{
    public Button btn;

    public Text text;

    public int sec;
    private float letterPause = 0.1f;
    public int sentencePause = 1;

    private string sentence = "Congratulations!!!\n You have passed my Experiment 1.\n There still another challenges for you. \nGood Luck...";

    void Start()
    {
        StartCoroutine(Delay(sentence));
    }


    IEnumerator Delay(string str)
    {
        yield return new WaitForSeconds(sentencePause);
        StartCoroutine(TypeText(str));
    }

    IEnumerator TypeText(string str)
    {
        foreach (var word in str)
        {
            text.text += word;
            yield return new WaitForSeconds(letterPause);
        }
    }

    void Update()
    {
        Invoke("setTrue", sec);
    }

    private void setTrue()
    {
        btn.gameObject.SetActive(true);
    }
}

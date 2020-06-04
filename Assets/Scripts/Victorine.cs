using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;


public class Victorine : MonoBehaviour
{
    public QuestionList[] Questions;
    public Text[] AnswersText;
    public Text qText;

    private List<object> qList;
    private QuestionList crntQ;
    private int randQ;

    private int Rele = 0;

    public void OnClickPlay()
    {
        if (Rele == 0)
        {
            Rele++;
            qList = new List<object>(Questions);
            _questionGenerate();
        }
        
    }

    void _questionGenerate()
    {
        randQ = UnityEngine.Random.Range(0, qList.Count);
        crntQ = qList[randQ] as QuestionList;
        qText.text = crntQ.Question;
        List<string> Answer = new List<string>(crntQ.Answer);
        for (int i = 0; i < crntQ.Answer.Length; i++)
        {
            int rand = UnityEngine.Random.Range(0, Answer.Count);
            AnswersText[i].text = Answer[rand];
            Answer.RemoveAt(rand);
        }
    }

    public void AnswersButtons(int index)
    {
        if (AnswersText[index].text.ToString() == crntQ.Answer[0])
            Debug.Log("+1");
        else
        {
            Debug.Log("-1");
        }
        qList.RemoveAt(randQ);
        _questionGenerate();
    }
    
}

[System.Serializable]
public class QuestionList
{
    public string Question;
    public string[] Answer = new string[3];
}






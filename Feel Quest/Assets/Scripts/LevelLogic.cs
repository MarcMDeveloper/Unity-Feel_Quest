using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelLogic : MonoBehaviour
{
    public TextMeshProUGUI inputText;
    public TextMeshProUGUI relationText;
    private int relation = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When press enter post request new text
    public void OnWriteText()
    {
        if (inputText.text.Length < 8)
            return;

        // Post text tp server

        // Await for answer
        int answer = 0;

        if (answer == 0 || answer == 1 || answer == 2)
        {
            ChangeRelation(0);
        }
        else if (answer == 3 || answer == 4)
        {
            ChangeRelation(1);
        }

        inputText. = " ";
    }

    private void ChangeRelation(int type)
    {
        if(type == 0)
        {
            relation += 10;
        }
        else
        {
            relation -= 10;
        }

        relationText.text = relation.ToString();

        if (relation <= 0)
        {
            GameOver();
        }
        else if (relation >= 100)
        {
            Victory();
        }
    }

    private void Victory()
    {
        print("Victory");
    }
    private void GameOver()
    {
        print("GameOver");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    public Text finishScoreText;
    public GameObject finishPanel;
    public int score = 0;
    public int BonusScore = 20;
    private bool bonus = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activate()
    {
        finishPanel.SetActive(true);
        finishScoreText.text = ""+score;
    }
    public void scoreUp()
    {
        score++;
        scoreText.text = "" + score;
        if (score > BonusScore && !bonus)
        {
            FindObjectOfType<Utils>().numberDinamite[FindObjectOfType<Utils>().tool]++;
            bonus = true;
        }
    }
}

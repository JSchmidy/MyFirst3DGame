using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using UnityEngine;

public class EndResult : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private TMP_Text highscoreText;
    [SerializeField]
    private FloatSO scoreSO;
    [SerializeField]
    private FloatSO highscoreSO;
    
    private void Start()
    {
        scoreText.text = scoreSO.Value + "";
        
        if (scoreSO.Value > highscoreSO.Highscore)
        {
            highscoreText.text = scoreSO.Value + "";
            highscoreSO.Highscore = scoreSO.Value;
        }
        else
        {
            highscoreText.text = highscoreSO.Highscore + "";
        }
    }
}

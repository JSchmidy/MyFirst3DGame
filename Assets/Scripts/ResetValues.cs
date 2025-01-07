using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ResetValues : MonoBehaviour
{
    [SerializeField]
    private FloatSO scoreSO;
    [SerializeField]
    private FloatSO heartsSO;
    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private TMP_Text heartsText;
    void Start()
    {
        scoreSO.Value = 0;
        heartsSO.Hearts = 3;
        if (scoreSO.Value != 0) 
        {
            scoreSO.Value = 0;
        }
        
        if (heartsSO.Hearts != 3)
        {
            heartsSO.Hearts = 3;
        }

        scoreText.text = scoreSO.Value.ToString(); 
        heartsText.text = heartsSO.Hearts.ToString();
    }
}

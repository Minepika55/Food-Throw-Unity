using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.RestService;
using UnityEngine;
using TMPro;

public class Clicks : MonoBehaviour
{
    private TextMeshProUGUI _scoreText;
        private void Awake()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
        void Update()
    {
        
        int totalAttempts = PlayerPrefs.GetInt("scoreCorrect") + PlayerPrefs.GetInt("scoreIncorrect");
        string scoreMessage = "Score =";
        scoreMessage += PlayerPrefs.GetInt("scoreCorrect") + "/" + totalAttempts;
        _scoreText.text = scoreMessage;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour  
{
    public static score instance;
    private int _score;
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    
    private void Awake() {
        if(instance==null){
            instance = this;
        }
    }

    private void Start() {

        _currentScoreText.text = _score.ToString();

        _highScoreText.text=PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighscore();
    }
    private void UpdateHighscore(){
        if(_score > PlayerPrefs.GetInt("HighScore"))
        PlayerPrefs.SetInt("HighScore", _score);
        _highScoreText.text=_score.ToString();

    }
    public void updateScore(){
        _score++;
        _currentScoreText.text=_score.ToString();
        UpdateHighscore();
    }



}

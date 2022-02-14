using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Text highScoreText;

    public void Start() {
        //ハイスコアを表示
        highScoreText.text = "Heigh Score:" + PlayerPrefs.GetInt("HighScore") + "m";
    }

    public void OnStartButtonClicked() {
        SceneManager.LoadScene("Main");
    }
}

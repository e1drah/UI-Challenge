using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    private float score;
    public TextMeshProUGUI scoreText;
    public void Start()
    {
        SetScoreText();
    }
    public void Play()
    {
        Debug.Log("Play");
    }
    public void Options()
    {
        Debug.Log("Options");
    }
    public void Credits()
    {
        Debug.Log("Credits");
    }
    public void Quit()
    {
        Debug.Log("Quit");
    }
    public void IncreaseScore()
    {
        score += 1;
        SetScoreText();
    }
    public void DecreaseScore()
    {
        score -= 1;
        SetScoreText();
    }
    public void RandomScore()
    {
        score += Random.Range(-5, 10);
        SetScoreText();
    }
    public void SetScoreText()
    {
        score = Mathf.Clamp(score, 0, 10000000);

        scoreText.text = score.ToString();
    }
}

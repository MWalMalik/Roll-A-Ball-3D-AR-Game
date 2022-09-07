using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagerScript : MonoBehaviour
{
    public int Score;
    public TMP_Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateRegularScore()
    {
        this.Score++;
        this.ScoreText.text = this.Score.ToString();
    }

    public void UpdateBonusScore()
    {
        this.Score += 5;
        this.ScoreText.text = this.Score.ToString();
    }

    public void UpdateBombScore()
    {
        this.Score -= 5;
        this.ScoreText.text = this.Score.ToString();
    }
}

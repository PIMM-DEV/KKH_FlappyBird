using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EggScore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score.score > Score.BestScore)
        {
            Score.BestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}

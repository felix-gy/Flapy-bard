using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicManagerScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject GameOverPanel;

    [ ContextMenu("Add Score")]
    public void addScore(int points)
    {
        Debug.Log("Score Added");
        playerScore += points;
        scoreText.text = playerScore.ToString();
    }

    public void restarLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }

}

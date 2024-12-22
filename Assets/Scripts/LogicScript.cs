using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
  public int playerScore;
  public GameObject GameOverScreen;
  public Text  scoreText;
  [ContextMenu("Increase Score")]
  public void addScore(int ScoreToadd)
  {
    playerScore=playerScore+ScoreToadd;
    scoreText.text=playerScore.ToString();
  }
  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 
  }
  public void gameover()
  {
    GameOverScreen.SetActive(true);
  }
}
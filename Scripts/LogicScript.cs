using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public float percentage = 0;
    public Text percentageText;
    public float coins = 0;
    public Text coinsText;
    public float timer = 0;
    public GameObject gameOverScreen;
    public GameObject youWinScreen;

    void Update() 
    {
        timer += Time.deltaTime;
        if (percentage + 1 < timer)
        {
            updatePercentage();
        }
    }

    [ContextMenu("Increase Percentage")]
    public void updatePercentage()
    {
        if (percentage < 100)
        {
            percentage += 1;
            percentageText.text = percentage.ToString() + "%";
        }
    }

    public void updateCoins()
    {
        coins++;
        coinsText.text = "Coins: " + coins.ToString();
    }

    public void loseCoins()
    {
        coins -= 5;
        coinsText.text = "Coins: " + coins.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void youWin()
    {
        youWinScreen.SetActive(true);
    }
}

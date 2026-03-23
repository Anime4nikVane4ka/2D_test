using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    private bool gameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Score+")]
    public void add_score(int adder = 1)
    {
        if (!gameOver)
        {
            score += adder;
            scoreText.text = score.ToString();
        }        
    }

    public void game_over()
    {
        gameOverScreen.SetActive(true);
        gameOver = true;
    }

    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

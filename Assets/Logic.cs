using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
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
        score += adder;
        scoreText.text = score.ToString();
    }
}

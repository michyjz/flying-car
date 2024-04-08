using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public LogicScript logic;
    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGameOver)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }
        if (logic.coins < 0 && !isGameOver)
        {
            logic.gameOver();
            isGameOver = true;
        }
        if (transform.position.y < -8 && !isGameOver)
        {
            logic.gameOver();
            isGameOver = true;
        }
        if (logic.percentage >= 100 && !isGameOver)
        {
            logic.youWin();
            isGameOver = true;
        }
    }
}

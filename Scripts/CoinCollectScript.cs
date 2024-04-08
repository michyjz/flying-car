using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectScript : MonoBehaviour
{
    public LogicScript logic;
    public Rigidbody2D myRigidbody;
    public float timer = 0;
    public float collectTime = 2;
    public float jumpStrength = 2;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.updateCoins();
            Debug.Log("collect coin");
            collect();
        }
    }

    void collect()
    {
        //myRigidbody.velocity = Vector2.up * jumpStrength;
        //while (timer < collectTime)
        //{
        //    timer += Time.deltaTime;
        //}
        //timer = 0;
        Destroy(gameObject);
    }
}

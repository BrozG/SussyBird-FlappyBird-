using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D RdBody;
    public float FlapStrength;
    public LogicScript logic;
    public bool birdIsAlive =true;
    public float fallThreshold=-20;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<fallThreshold && birdIsAlive)
        {
            gameOver();
        }
         Debug.Log("Bird Position: " + transform.position.y);
        if((Input.GetMouseButtonDown(0) && birdIsAlive))
        {
            RdBody.velocity=Vector2.up*FlapStrength;    
        }
        
    }
    private void gameOver()
    {
        logic.gameover();
        birdIsAlive=false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(birdIsAlive)
        {
            gameOver();
        }
    }
}

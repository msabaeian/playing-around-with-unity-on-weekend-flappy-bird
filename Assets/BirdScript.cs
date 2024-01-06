using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrengh;
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start(){
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrengh;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        logic.GameOver();
        birdIsAlive = false;
    }
}

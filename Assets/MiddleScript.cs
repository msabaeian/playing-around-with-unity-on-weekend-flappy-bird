using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        // Bird is on layer = 3
        if(collision.gameObject.layer == 3){
            logic.AddScore(1);
        }
    }
}

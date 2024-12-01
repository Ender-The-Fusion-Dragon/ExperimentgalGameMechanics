using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AstseroidBehaviour : MonoBehaviour{

    private Rigidbody2D rigidBody;
    private GameStateManager gameStateManager;
    float directionY;
    float directionX;
    int health;
    public string moveTo;

    // Start is called before the first frame update
    void Start(){
        rigidBody = this.GetComponent<Rigidbody2D>();
        gameStateManager = GameObject.Find("GameState").GetComponent<GameStateManager>();

        health = 5;

        directionY = Random.Range(-300, 300);
        directionX = Random.Range(-300, 300);
        rigidBody.AddForce(new Vector3(directionX, directionY, 0F));
    }

    // Update is called once per frame
    void Update(){}

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Bullet"){
            health--;

            if(health == 0){
                gameStateManager.adjustScore(1000);
                Destroy(this.gameObject);
                SceneManager.LoadScene(moveTo);
            }
        }
    }
}

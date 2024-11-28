using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour{

    private Rigidbody2D rigidBody;
    public GameObject destructionParticle;
    public float removeParticle;
    private GameStateManager gameStateManager;


    // Start is called before the first frame update
    void Start(){
        rigidBody = this.GetComponent<Rigidbody2D>();
        gameStateManager = GameObject.Find("GameState").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update(){
        rigidBody.AddForce(this.transform.up * 1);
    }

    private void OnCollisionEnter2D(Collision2D collision){

        GameObject explosion;
        removeParticle = Time.time;

        if(collision.gameObject.tag == "Enemy"){
            explosion = Instantiate(destructionParticle, this.transform.position, Quaternion.Euler(0f, 180f, 0f));
            gameStateManager.adjustScore(100);
            Destroy(collision.gameObject);

            Destroy(explosion.gameObject, 0.3F);

        }

        Destroy(this.gameObject);
    }
}

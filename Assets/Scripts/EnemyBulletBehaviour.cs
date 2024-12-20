using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBulletBehaviour : MonoBehaviour{

    private Rigidbody2D rigidBody;
    public GameObject destructionParticle;
    public float removeParticle;
    public string moveTo;


    // Start is called before the first frame update
    void Start(){
        rigidBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        rigidBody.AddForce(-this.transform.up * 1);
    }

    private void OnCollisionEnter2D(Collision2D collision){

        GameObject explosion;
        removeParticle = Time.time;

        if(collision.gameObject.tag == "Player"){
            explosion = Instantiate(destructionParticle, this.transform.position, Quaternion.Euler(0f, 180f, 0f));
            Destroy(collision.gameObject);

            Destroy(explosion.gameObject, 0.3F);

            SceneManager.LoadScene(moveTo);

        }

        Destroy(this.gameObject);
    }
}

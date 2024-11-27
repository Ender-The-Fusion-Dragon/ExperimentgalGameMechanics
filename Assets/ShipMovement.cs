using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour{

    public string left;
    public string right;
    public string fireWeapon;
    ParticleSystem engineLeft, engineRight;
    public GameObject bullet;

    public Rigidbody2D rigidBody;
    public float previouslyFired;
    public float hasCollided;

    public bool disableMovement;


    // Start is called before the first frame update
    void Start(){
        engineLeft = GameObject.Find("LeftEngineEffect").GetComponent<ParticleSystem>();
        engineRight = GameObject.Find("RightEngineEffect").GetComponent<ParticleSystem>();
        rigidBody = this.GetComponent<Rigidbody2D>();
        disableMovement = false;
    }

    // Update is called once per frame
    void Update(){

        GameObject tempBullet;

        if(Input.GetKey(KeyCode.A) && disableMovement == false){
            this.transform.Translate(new Vector3(-5f, 0f, 0f) * Time.deltaTime * 1);
            engineRight.Play();
        }else{
            engineRight.Stop();
        }

        if(Input.GetKey(KeyCode.D) && disableMovement == false){
            this.transform.Translate(new Vector3(5f, 0f, 0f) * Time.deltaTime * 1);
            engineLeft.Play();
        }else{
            engineLeft.Stop();
        }

        if(Input.GetKey(KeyCode.RightControl)){
            if(Time.time > previouslyFired + 1f){
                tempBullet = Instantiate(bullet, this.transform.position +  (this.transform.up), this.transform.rotation);
                previouslyFired = Time.time;
            }
        }

        if(disableMovement == true){

            if(Time.time > hasCollided + 1F){
                disableMovement = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){

        if(collision.gameObject.tag == "Bouncer"){
            rigidBody.AddForce(new Vector3(300f, 0f, 0f));
            disableMovement = true;
            hasCollided = Time.time;
        }

        if(collision.gameObject.tag == "BouncerLeft"){
            rigidBody.AddForce(new Vector3(-300f, 0f, 0f));
            disableMovement = true;
            hasCollided = Time.time;
        }
    }
}

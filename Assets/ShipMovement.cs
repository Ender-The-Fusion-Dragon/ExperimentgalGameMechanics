using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour{

    public string left;
    public string right;
    public string fireWeapon;
    public GameObject bullet;

    public Rigidbody2D rigidBody;
    public float previouslyFired;


    // Start is called before the first frame update
    void Start(){
        rigidBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){

        GameObject tempBullet;

        if(Input.GetKey(KeyCode.A)){
            this.transform.Translate(new Vector3(-5f, 0f, 0f) * Time.deltaTime * 1);
        }

        if(Input.GetKey(KeyCode.D)){
            this.transform.Translate(new Vector3(5f, 0f, 0f) * Time.deltaTime * 1);
        }

        if(Input.GetKey(KeyCode.RightControl)){
            if(Time.time > previouslyFired + 1f){
                tempBullet = Instantiate(bullet, this.transform.position +  (this.transform.up), this.transform.rotation);
                previouslyFired = Time.time;
            }
        }
    }

    void FixedUpdate(){

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour{

    [SerializeField] Transform[] Points;
    [SerializeField] private float enemySpeed;
    private int waypointIndex;
    public GameObject enemyBullet;
    public int enemyFireWeapon;
    public float previouslyFired;

    // Start is called before the first frame update
    void Start(){
        transform.position = Points[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update(){

        GameObject projectile;

        if(waypointIndex <= Points.Length - 1){
            transform.position = Vector2.MoveTowards(transform.position, Points[waypointIndex].transform.position, enemySpeed * Time.deltaTime);

            if(transform.position == Points[waypointIndex].transform.position){
                waypointIndex += 1;
            }
        }

        enemyFireWeapon = Random.Range(0, 1000);

        if(enemyFireWeapon == 500){
            if(Time.time > previouslyFired + 10f){
                projectile = Instantiate(enemyBullet, this.transform.position + (-this.transform.up), this.transform.rotation);
                previouslyFired = Time.time;
            }
        }
    }
}

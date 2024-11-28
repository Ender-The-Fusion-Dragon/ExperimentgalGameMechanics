using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour{

    [SerializeField] Transform[] Points;

    [SerializeField] private float enemySpeed;
    private int waypointIndex;

    // Start is called before the first frame update
    void Start(){
        transform.position = Points[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update(){
        if(waypointIndex <= Points.Length - 1){
            transform.position = Vector2.MoveTowards(transform.position, Points[waypointIndex].transform.position, enemySpeed * Time.deltaTime);

            if(transform.position == Points[waypointIndex].transform.position){
                waypointIndex += 1;
            }
        }
    }
}

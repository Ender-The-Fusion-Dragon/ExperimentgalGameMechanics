using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour{

    public GameObject prefab;
    public int spawnAmount;

    // Start is called before the first frame update
    void Start(){
        GameObject alien;

        for(int i = 0; i < spawnAmount; i++){
            alien = Instantiate(prefab, new Vector3(Random.Range(-8, 8), Random.Range(-3, 4), 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
}

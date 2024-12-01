using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEnemiesDead : MonoBehaviour{

    [SerializeField] List<GameObject> enemyList = new List<GameObject>();

    public GameObject moveToNextLevel;
    
    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){

        GameObject levelChanger;

        for(int i = enemyList.Count - 1; i >= 0; i--){
            Debug.Log(enemyList.Count);
            if(enemyList[i] == null){
                enemyList.RemoveAt(i);
                if(enemyList.Count == 0){
                    Debug.Log("All enemies dead");
                    levelChanger = Instantiate(moveToNextLevel);
                }
            }
        }
    }
}

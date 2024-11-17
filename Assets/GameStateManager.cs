using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour{

    private int score;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    public int getScore(){
        return score;
    }

    public void setScore(int s){
        score = s;
    }

    public void adjustScore(int s){
        score += s;
        Debug.Log("Score is " + score);
    }
}

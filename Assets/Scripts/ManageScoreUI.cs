using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManageScoreUI : MonoBehaviour{

    [SerializeField] TextMeshProUGUI score;
    private GameStateManager gameStateManager;
    float scoreValue;

    // Start is called before the first frame update
    void Start(){
        gameStateManager = GameObject.Find("GameState").GetComponent<GameStateManager>();
    }

    // Update is called once per frame
    void Update(){
        scoreValue = gameStateManager.getScore();
        score.text = scoreValue.ToString();
    }
}

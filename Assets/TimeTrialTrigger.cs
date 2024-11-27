using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeTrialTrigger : MonoBehaviour{

    public string moveTo;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    private void OnTriggerEnter2D(Collider2D transition){
        GameObject go = transition.gameObject;

        if(go.tag == "Player"){
            SceneManager.LoadScene(moveTo);
        }
    }
}

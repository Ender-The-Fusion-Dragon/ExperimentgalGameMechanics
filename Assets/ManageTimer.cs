using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ManageTimer : MonoBehaviour{

    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] float timeRemaining;
    public string moveTo;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if(sceneName == "TimeTrial"){
            timeRemaining -= Time.deltaTime;
            int timerMinutes = Mathf.FloorToInt(timeRemaining / 60);
            int timerSeconds = Mathf.FloorToInt(timeRemaining % 60);
            timer.text = string.Format("{0:00}:{1:00}", timerMinutes, timerSeconds);

            if(timerMinutes == 0 && timerSeconds == 0){
                SceneManager.LoadScene(moveTo);
            }
        }
    }
}

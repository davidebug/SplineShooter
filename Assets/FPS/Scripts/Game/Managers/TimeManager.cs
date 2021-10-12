using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager {

      private static TimeManager _instance;

    public static TimeManager Instance()
    {

            if(_instance == null)
            {
                _instance =  new TimeManager();
            }

            return _instance;
    }

    double gameTime;
    void Awake()
    {
        _instance = this;
    }

    public void updateGameTime(float time){
        gameTime += time;
    }

    public double getGameTime(){
        return gameTime;
    }

    

}
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour{

      private static TimeManager _instance;

    public static TimeManager Instance()
    {

            if(_instance == null)
            {
                _instance = new TimeManager();
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

public void setTimeString(){
        GameObject timeObject =  GameObject.Find("Time");
                    Text time = timeObject.GetComponent<Text>();
                    time.text ="Total Time: "+ gameTime.ToString() + "s";
    }
    

}
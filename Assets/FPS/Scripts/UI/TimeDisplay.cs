using UnityEngine.UI;
using UnityEngine;

public class TimeDisplay : MonoBehaviour {
    
    Text text;
    
     private void Start() {
        text = GetComponent<Text>();
        text.text = "Total Time: " + TimeManager.Instance().getGameTime().ToString("0.00") + "s";
    }
}
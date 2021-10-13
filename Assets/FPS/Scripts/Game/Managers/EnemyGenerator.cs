using System.Collections;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    
    public GameObject enemyRobot;

    public GameObject enemyTurret;

    private int xPos;
    private int zPos;

    private int robotCount;

    void Start(){
        enemyRobot.tag = "Enemy";
        enemyTurret.tag = "Enemy";
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop(){
        int isTurret = Random.Range(0,2);
        if(isTurret == 0){
             xPos = Random.Range(-38,-50);
            zPos = Random.Range(23,38);
            
            Instantiate(enemyRobot, new Vector3(xPos, 7.0f, zPos), Quaternion.identity);
            xPos = Random.Range(-80,-5);
            zPos = Random.Range(18,120);
            
            Instantiate(enemyTurret, new Vector3(xPos, 1.0f, zPos), Quaternion.identity);
        }
        else if(isTurret == 1){
             xPos = Random.Range(-38,-50);
            zPos = Random.Range(23,38);
            
            Instantiate(enemyTurret, new Vector3(xPos, 7.0f, zPos), Quaternion.identity);
            xPos = Random.Range(-80,-5);
            zPos = Random.Range(18,120);
            
            Instantiate(enemyRobot, new Vector3(xPos, 1.0f, zPos), Quaternion.identity);
        }
        else{
             xPos = Random.Range(-38,-50);
            zPos = Random.Range(23,38);
            
            Instantiate(enemyTurret, new Vector3(xPos, 7.0f, zPos), Quaternion.identity);
            xPos = Random.Range(-38,-50);
            zPos = Random.Range(23,38);
            
            Instantiate(enemyRobot, new Vector3(xPos, 7.0f, zPos), Quaternion.identity);
        }
        while(robotCount < 9){
            xPos = Random.Range(-80,-5);
            zPos = Random.Range(18,120);
            
            Instantiate(enemyRobot, new Vector3(xPos, 1.7f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0);
            robotCount += 1;
        }
    }
}
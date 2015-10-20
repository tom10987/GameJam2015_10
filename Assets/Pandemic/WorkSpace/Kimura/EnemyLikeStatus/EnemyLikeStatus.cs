using UnityEngine;
using System.Collections;
using System.IO;

public class EnemyLikeStatus : MonoBehaviour {

    //[SerializeField]
    int enemyHP;
    float  attackPower;
    int attribute;


    EnemyParameter enemyParameter;

	void Start ()
    {
        enemyParameter = GetComponent<EnemyParameter>();
        EnemyAttributeStatusGeneration();
    }
	
	void Update ()
    {
        
	}


    void EnemyAttributeStatusGeneration()
    {
        attribute = Random.Range(0,4);
        enemyParameter.GetAttribute(attribute);
    }

    void CheckAttributeStatus()
    {
        //if()
    }
}

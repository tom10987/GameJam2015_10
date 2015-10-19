using UnityEngine;
using System.Collections;

public class PlayerStressdamager : MonoBehaviour {

    int currentStressGauge;
    [SerializeField]
    int maxStressGauge = 100;

    int stressDamage; 

    void Start ()
    {
        currentStressGauge = 0;
        maxStressGauge = 100;
    }
	
	void Update ()
    {
	
	}

    void PlayerStressdamage()
    {
        currentStressGauge += stressDamage;

        if(maxStressGauge <= currentStressGauge)
        {

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if ()
        {
            PlayerStressdamage();
        }
    }
}

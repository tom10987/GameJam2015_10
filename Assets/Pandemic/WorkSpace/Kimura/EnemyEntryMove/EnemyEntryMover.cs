using UnityEngine;
using System.Collections;

public class EnemyEntryMover : MonoBehaviour {

	void Start ()
    {
	
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            EnemyEnteyManeger();
        }
    }

    void EnemyEnteyManeger()
    {
        if(gameObject.tag == "BossEntryleftPattern")
        {
            leftEnemyEnteymove();
        }

        if(gameObject.tag == "BossEntryUnderPattern")
        {
            UnderEnemyEnteymove();
        }

    }

    void leftEnemyEnteymove()
    {
         iTween.MoveTo(gameObject, iTween.Hash("x", 5, "time", 3.0f));
    }

    void UnderEnemyEnteymove()
    {
        iTween.MoveTo(gameObject, iTween.Hash("y", -3, "time", 10.0f));
    }
}

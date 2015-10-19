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
         iTween.MoveTo(gameObject, iTween.Hash("x", 200, "time", 3.0f,"islocal", true));
    }

    void UnderEnemyEnteymove()
    {
        iTween.MoveTo(gameObject, iTween.Hash("y", -50, "time", 10.0f, "islocal", true));
    }
}

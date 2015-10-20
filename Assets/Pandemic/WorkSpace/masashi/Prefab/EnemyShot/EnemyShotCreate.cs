using UnityEngine;
using System.Collections;

public class EnemyShotCreate : MonoBehaviour
{
    [SerializeField]
    GameObject _enemyShot = null;

    //---------------------------------

    void Create()
    {
        var enemyShot_ = Instantiate(_enemyShot).GetComponent<Transform>();
    }
}

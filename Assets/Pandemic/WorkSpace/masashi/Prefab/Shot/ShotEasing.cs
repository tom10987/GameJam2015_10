using UnityEngine;
using System.Collections;

public class ShotEasing : MonoBehaviour
{

    struct Shot
    {
        int _type;

        Vector3 _playerPos;
        Vector3 _targetPos;

        float _speed;

        float _angle;
    }

    GameObject _player = null;
    GameObject _enemy = null;

    const string _enemyName = "Enemy";
    const string _playerName = "Player";

    public bool IsAttackAnime { get; set; }
    public bool IsAttackIdol { get; set; }
    public bool IsAttackGame { get; set; }
    public bool IsAttackVocalRob { get; set; }
    public bool IsAttackRobot { get; set; }

    float _angle = 0;

    //--------------------------------

    void Start()
    {
        _player = GameObject.Find(_playerName);
        _enemy = GameObject.Find(_enemyName);
    }

    void Update()
    {
        //TODO:それぞれのプレハブを複製
        if (IsAttackAnime)
        {
        }
        if (IsAttackIdol)
        {
        }
        if (IsAttackGame)
        {
        }
        if (IsAttackVocalRob)
        {
        }
        if (IsAttackRobot)
        {
        }
    }

    void FixedUpdate()
    {

    }

}

using UnityEngine;
using System.Collections;

public class ShotEasing : MonoBehaviour
{
    GameObject _enemy = null;

    const string _enemyName = "Enemy";

    float _angle = 0;

    int _time = 0;

    Vector3[] movepath = new Vector3[3];

    [SerializeField, Range(-5, 5), Tooltip("弾が動くXの範囲")]
    float _xMoveRange;
    [SerializeField, Range(0, 3), Tooltip("弾が動く高さの範囲")]
    float _heightMoveRange;

    [SerializeField, Range(0000.1f, 0.001f), Tooltip("弾が小さくなる速度")]
    float _sizeChangeSpped;

    [SerializeField, Range(1, 3), Tooltip("弾が敵に届く秒数")]
    int _goEnemyTime;

    //--------------------------------

    void Start()
    {
        _enemy = GameObject.Find(_enemyName);

        for (int i = 0; i < 2; ++i)
        {
            movepath[i].Set(
                Random.Range(-_xMoveRange, _xMoveRange),
                Random.Range(0.0f, _heightMoveRange),
                Random.Range(-2.5f, -2.5f));
        }
        movepath[2].Set(
            _enemy.transform.localPosition.x,
            _enemy.transform.localPosition.y,
            _enemy.transform.localPosition.z);
    }

    void Update()
    {
        transform.localScale -=
            new Vector3(
                _sizeChangeSpped,
                _sizeChangeSpped,
                _sizeChangeSpped);

        _time++;

        iTween.MoveTo(gameObject, iTween.Hash(
            "path", movepath,
            "time", _goEnemyTime,
            "easetype", iTween.EaseType.easeOutSine));

        if (_time == (60 * _goEnemyTime) ||
            transform.localScale.y <= 0.0f)
        {
            Destroy(gameObject);
        }

        //----------------------------------------------------------------
        //TODO:今は時間経過で消しているが、進行度が上がったら敵の位置と重なったら消す
        //----------------------------------------------------------------
    }

}

using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{
    GameObject _enemy = null;

    const string _enemyName = "Enemy";

    float _angle = 0.0f;

    int _time = 0;

    Vector3[] movepath = new Vector3[3];

    [SerializeField, Range(0.0f, 5.0f), Tooltip("弾が動くXの範囲")]
    float _xMoveRange = 3.0f;
    [SerializeField, Range(0.0f, 3.0f), Tooltip("弾が動く高さの範囲")]
    float _heightMoveRange = 3.0f;

    [SerializeField, Range(0.00001f, 0.1f), Tooltip("弾が小さくなる速度")]
    float _sizeChangeSpped = 0.01f;

    [SerializeField, Range(1, 3), Tooltip("弾が敵に届く秒数")]
    int _goEnemyTime = 2;

    //--------------------------------

    void Start()
    {
        _enemy = GameObject.Find(_enemyName);

        movepath[0].Set(
            Random.Range(-_xMoveRange, 0.0f),
            Random.Range(0.5f, _heightMoveRange),
            Random.Range(-2.5f, -2.5f));
        movepath[1].Set(
            Random.Range(0.0f, _xMoveRange),
            Random.Range(0.5f, _heightMoveRange),
            Random.Range(-2.5f, -2.5f));
        movepath[2].Set(
            _enemy.transform.localPosition.x,
            _enemy.transform.localPosition.y + 2.0f,
            _enemy.transform.localPosition.z);
    }

    void Update()
    {
        //１秒経ったら縮小をかける
        if (_time >= (60 * _goEnemyTime / 2))
        {
            transform.localScale -=
                new Vector3(
                    _sizeChangeSpped,
                    _sizeChangeSpped,
                    _sizeChangeSpped);
        }

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

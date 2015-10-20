using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Shot : MonoBehaviour
{
    [SerializeField]
    List<Sprite> sprite = new List<Sprite>();

    Image image = null;

    GameObject _player = null;
    GameObject _enemy = null;

    const string _playerName = "Player";
    const string _enemyName = "EnemyNear";

    float _angle = 0.0f;

    float _time = 0;

    Vector3[] movepath = new Vector3[2];

    [SerializeField, Range(0.0f, 5.0f), Tooltip("弾が動くXの範囲")]
    float _xMoveRange = 3.0f;
    [SerializeField, Range(0.0f, 3.0f), Tooltip("弾が動く高さの範囲")]
    float _heightMoveRange = 3.0f;

    [SerializeField, Range(0.00001f, 0.1f), Tooltip("弾が小さくなる速度")]
    float _sizeChangeSpped = 0.01f;

    [SerializeField, Range(1, 3), Tooltip("弾が敵に届く秒数")]
    int _goEnemyTime = 5;

    //--------------------------------
    RectTransform rectTrans = null;
    RectTransform goalRectTrans = null;

    void Awake()
    {
        _enemy = GameObject.Find(_enemyName);
        _player = GameObject.Find(_playerName);
        image = transform.GetChild(0).GetComponent<Image>();
        var random = Random.Range(0, sprite.Count);
        image.sprite = sprite[random];
    }

    void Start()
    {
        movepath[0].Set(
            _player.transform.localPosition.x,
            _player.transform.localPosition.y,
            _player.transform.localPosition.z);
        //movepath[1].Set(
        //    Random.Range(-_xMoveRange, 0.0f),
        //    Random.Range(0.5f, _heightMoveRange),
        //    Random.Range(-2.5f, -2.5f));
        //movepath[2].Set(
        //    Random.Range(0.0f, _xMoveRange),
        //    Random.Range(0.5f, _heightMoveRange),
        //    Random.Range(-2.5f, -2.5f));
        // movepath[1].Set(
        //    _enemy.transform.localPosition.x,
        //    _enemy.transform.localPosition.y + 2.0f,
        //    _enemy.transform.localPosition.z);

        //iTween.MoveTo(gameObject, iTween.Hash(
        //   "path", movepath,
        //  "time", _goEnemyTime,
        //  "easetype", iTween.EaseType.easeOutSine));

        rectTrans = GetComponent<RectTransform>();
        goalRectTrans = _enemy.GetComponent<RectTransform>();
        var playerRect = _player.GetComponent<RectTransform>();
        rectTrans.anchoredPosition = new Vector2(playerRect.anchoredPosition3D.x, playerRect.anchoredPosition3D.y);
        rectTrans.localScale = Vector2.one;

    }

    bool isHit = false;

    void Update()
    {
        if (isHit) return;

        //１秒経ったら縮小をかける
        if (_time >= (60 * _goEnemyTime / 2))
        {
            // transform.localScale -=
            //    new Vector3(
            //       _sizeChangeSpped,
            //       _sizeChangeSpped,
            //       _sizeChangeSpped);
        }

        _time += 0.25f;

        rectTrans.Translate(30.0f * Time.deltaTime, Mathf.Cos(_time), 0.0f);

        if (_time == (60 * _goEnemyTime) ||
            transform.localScale.y <= 0.0f)
        {
        }

        if (rectTrans.anchoredPosition.x >= goalRectTrans.anchoredPosition.x)
        {
            const int X = 50;
            const int Y = 50;
            var randomX = Random.Range(-X, X);
            var randomY = Random.Range(-Y, Y);
            rectTrans.anchoredPosition3D = goalRectTrans.anchoredPosition3D + new Vector3(randomX, randomY);
            rectTrans.localScale *= 0.5f;
            isHit = true;
            //Destroy(gameObject);
        }
        //----------------------------------------------------------------
        //TODO:今は時間経過で消しているが、進行度が上がったら敵の位置と重なったら消す
        //----------------------------------------------------------------
    }


}

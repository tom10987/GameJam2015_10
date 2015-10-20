using UnityEngine;
using System.Collections;

public class CreateShot : MonoBehaviour
{
    public bool IsAttackAnime { get; set; }
    public bool IsAttackIdol { get; set; }
    public bool IsAttackGame { get; set; }
    public bool IsAttackVocalRob { get; set; }
    public bool IsAttackRobot { get; set; }

    public int SetEnemyCount { get; set; }

    BalloonParameter _attackState = null;

    [SerializeField]
    GameObject _bolloonPrefab = null;

    [SerializeField]
    GameObject _animeIconPrefab = null;
    [SerializeField]
    GameObject _idolIconPrefab = null;
    [SerializeField]
    GameObject _gameIconPrefab = null;
    [SerializeField]
    GameObject _vocalRobIconPrefab = null;
    [SerializeField]
    GameObject _robotIconPrefab = null;

    const string _shotManagerName = "ShotManager";

    //--------------------------------------


    void Start()
    {
        _attackState = 
            FindObjectOfType<BalloonParameter>();
    }

    public void Create(int attackType_)
    {
        switch (attackType_)
        {

            case (int)BalloonParameter.Attribute.ANIME:
                var animeShot_ = Instantiate(_bolloonPrefab).GetComponent<Transform>();
                for (var i = 0; i < SetEnemyCount; ++i)
                {
                    var icon_ = Instantiate(_animeIconPrefab).GetComponent<Transform>();
                }
                break;

            case (int)BalloonParameter.Attribute.IDOL:
                var idolShot_ = Instantiate(_bolloonPrefab).GetComponent<Transform>();
                for (var i = 0; i < SetEnemyCount; ++i)
                {
                    var icon_ = Instantiate(_idolIconPrefab).GetComponent<Transform>();
                }
                break;

            case (int)BalloonParameter.Attribute.GAME:
                var gameShot_ = Instantiate(_bolloonPrefab).GetComponent<Transform>();
                for (var i = 0; i < SetEnemyCount; ++i)
                {
                    var icon_ = Instantiate(_gameIconPrefab).GetComponent<Transform>();
                }
                break;

            case (int)BalloonParameter.Attribute.VOCALOID:
                var vocaloidShot_ = Instantiate(_bolloonPrefab).GetComponent<Transform>();
                for (var i = 0; i < SetEnemyCount; ++i)
                {
                    var icon_ = Instantiate(_vocalRobIconPrefab).GetComponent<Transform>();
                }
                break;

            case (int)BalloonParameter.Attribute.ROBOT:
                var robotShot_ = Instantiate(_bolloonPrefab).GetComponent<Transform>();
                for (var i = 0; i < SetEnemyCount; ++i)
                {
                    var icon_ = Instantiate(_robotIconPrefab).GetComponent<Transform>();
                }
                break;

            case (int)BalloonParameter.Attribute.ERROR:
                break;
        }
    }
}

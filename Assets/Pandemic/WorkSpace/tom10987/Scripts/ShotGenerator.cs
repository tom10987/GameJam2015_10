
using UnityEngine;


public class ShotGenerator : MonoBehaviour {

  [SerializeField]
  GameObject _shotPrefab = null;

  Transform _parent = null;
  AudioManager _manager = null;


  void Start() {
    var shotObj = GameObject.Find("Shot");
    if (shotObj != null)
    {
        _parent = shotObj.transform;
    }

    _manager = FindObjectOfType<AudioManager>();
  }

  public void AnimFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;

    _manager.RandomPlayPlayerAttackSE();
  }

  public void IdolFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;

    _manager.RandomPlayPlayerAttackSE();
  }

  public void GameFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;

    _manager.RandomPlayPlayerAttackSE();
  }

  public void VocalFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;

    _manager.RandomPlayPlayerAttackSE();
  }

  public void RobotFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;

    _manager.RandomPlayPlayerAttackSE();
  }
}

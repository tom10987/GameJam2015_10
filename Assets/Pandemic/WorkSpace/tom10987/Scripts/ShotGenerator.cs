
using UnityEngine;


public class ShotGenerator : MonoBehaviour {

  [SerializeField]
  GameObject _shotPrefab = null;

  Transform _parent = null;


  void Start() {
    _parent = GameObject.Find("Shot").transform;
  }

  public void AnimFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;
  }

  public void IdolFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;
  }

  public void GameFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;
  }

  public void VocalFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;
  }

  public void RobotFire() {
    var shot = Instantiate(_shotPrefab);
    shot.transform.parent = _parent;
  }
}

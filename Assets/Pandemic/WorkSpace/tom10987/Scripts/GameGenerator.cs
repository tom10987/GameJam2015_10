
using UnityEngine;


public class GameGenerator : MonoBehaviour {

  [SerializeField]
  GameObject[] _objects;


  void Start() {
    foreach (var obj in _objects) { Instantiate(obj); }
  }
}

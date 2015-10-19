
using UnityEngine;
using UnityEngine.UI;


public class PlayerStressdamager : MonoBehaviour {

  [SerializeField]
  int maxStressGauge = 100;

  int currentStressGauge = 0;

  int stressDamage = 0;

  Slider _slider = null;


  void Start() {
    currentStressGauge = 0;
    maxStressGauge = 100;

    _slider = FindObjectOfType<Slider>();
  }

  void Update() {
  }

  void PlayerStressdamage() {
    currentStressGauge += stressDamage;

    if (maxStressGauge <= currentStressGauge) {

    }
  }

  void OnCollisionEnter2D(Collision2D collision) {
    //if ()
    {
      PlayerStressdamage();
    }
  }
}

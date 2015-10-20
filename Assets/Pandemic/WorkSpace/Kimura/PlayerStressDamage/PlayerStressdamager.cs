
using UnityEngine;
using UnityEngine.UI;


public class PlayerStressdamager : MonoBehaviour {

  [SerializeField]
  int maxStressGauge = 100;

  int currentStressGauge = 0;

  int stressDamage = 0;

  Image _bar = null;


  void Start() {
    currentStressGauge = 0;
    maxStressGauge = 100;
    //stressDamage = FindObjectOfType<EnemyParameter>().GetAttackPower();
    stressDamage = 5;

    _bar = GameObject.Find("GaugeBar").GetComponent<Image>();
  }

  void Update() {
    var ratio = currentStressGauge / (float)maxStressGauge;
    _bar.fillAmount = ratio;
  }

  public void PlayerStressdamage() {
    currentStressGauge += stressDamage;
    if (maxStressGauge <= currentStressGauge) { Application.LoadLevel("Result"); }
  }
}

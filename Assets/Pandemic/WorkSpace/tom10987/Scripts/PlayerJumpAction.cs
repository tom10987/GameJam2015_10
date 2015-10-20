
using UnityEngine;


public class PlayerJumpAction : MonoBehaviour {

  void Update() {
    if (TouchController.IsTouchBegan() || TouchController.IsMouseClick()) {
      //TODO: プレイヤーのジャンプ

      var name = FindObjectOfType<BackGroundSetting>();
      name.StageChange(2u);
    }
  }
}

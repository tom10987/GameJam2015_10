
using UnityEngine;


public class PlayerJumpAction : MonoBehaviour {

  void Update() {
    if (TouchController.IsTouchBegan() || TouchController.IsMouseClick()) {
      var player = FindObjectOfType<PlayerJumper>();
      player.PlayerJump();
    }
  }
}

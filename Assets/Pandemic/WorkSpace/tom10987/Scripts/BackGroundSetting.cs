
using UnityEngine;


public class BackGroundSetting : MonoBehaviour {

  [SerializeField]
  GameObject[] _stageText = null;


  public void StageChange(uint stageNum) {
    // 値が配列の範囲外なら範囲内に収める
    var length = (uint)_stageText.Length;
    var num = (stageNum / length);
    if (num > length) { num = length; }

    if (_stageText[num].activeInHierarchy) { return; }

    for (uint index = 0; index < (uint)_stageText.Length; ++index) {
      var isActive = (index == num);
      _stageText[index].SetActive(isActive);
    }
  }
}

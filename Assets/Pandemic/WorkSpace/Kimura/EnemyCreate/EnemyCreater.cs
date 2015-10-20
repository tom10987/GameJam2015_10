
using UnityEngine;


public class EnemyCreater : MonoBehaviour {

  [SerializeField, Tooltip("クラス委員のプレハブを入れてください")]
  GameObject ClassCommittee = null;

  [SerializeField, Tooltip("生徒会長のプレハブを入れてください")]
  GameObject StudentCouncilPresident = null;

  [SerializeField, Tooltip("校長先生のプレハブを入れてください")]
  GameObject HeadMaster = null;

  public Vector3 enemyPosition { get { return gameObject.transform.position; } }
  
  void Start() {
    ClassCommitteeEenmyCreate();
  }

  public void ClassCommitteeEenmyCreate() {
    GameObject classCommitteeEenmyManager_ = GameObject.Find("EnemyManager");

    GameObject game_object = Instantiate(ClassCommittee);
    game_object.transform.SetParent(classCommitteeEenmyManager_.transform);
  }

  public void StudentCouncilPresidentEenmyCreate() {
    GameObject StudentCouncilPresidentEenmyManager_ = GameObject.Find("EnemyManager");

    GameObject game_object = Instantiate(StudentCouncilPresident);
    game_object.transform.SetParent(StudentCouncilPresidentEenmyManager_.transform);

  }

  public void HeadMasterEenmyCreate() {
    GameObject HeadMasterEenmyManager_ = GameObject.Find("EnemyManager");

    GameObject game_object = Instantiate(HeadMaster);
    game_object.transform.SetParent(HeadMasterEenmyManager_.transform);
  }
}

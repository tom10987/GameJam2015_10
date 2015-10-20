
using UnityEngine;


public class EnemyLikeStatus : MonoBehaviour {

  //[SerializeField]
  float enemyHP;
  float attackPower;
  int attribute;


  EnemyParameter enemyParameter;

  void Start() {
    enemyParameter = GetComponent<EnemyParameter>();
    EnemyAttributeStatusGeneration();
  }

  void Update() {
  }

  void EnemyAttributeStatusGeneration() {
    attribute = Random.Range(0, 4);
    enemyParameter.GetAttribute(attribute);//IDでやった方がよい
    enemyHP = enemyParameter.GetHP(attribute);
  }

  void CheckAttributeStatus() {
    //if(enemyParameter.GetAttribute(attribute) == /*enemyParameter.GetAttribute(attribute)*/)
    //{
    //    enemyHP -= enemyParameter.GetAttackPower(attribute);
    //        if(enemyHP <= 0 )
    //{

    //}
    //}
    //else
    //    if(!(enemyParameter.GetAttribute(attribute) == /*enemyParameter.GetAttribute(attribute)*/))
    //{
    //    //反撃の弾の関数を入れる
    //}
  }
}

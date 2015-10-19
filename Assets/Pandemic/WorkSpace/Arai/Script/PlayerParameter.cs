using UnityEngine;
using System.Collections;
using MiniJSON;
using System.IO;

//　<プレイヤーパラメータ>
//　-HP(ストレス値)
//　-属性

//　<仲間>
//　-属性
//　-攻撃スピード

//　<敵(子分)のパラメーター>
//　-属性
//　-HP
//　-攻撃力
//　-攻撃スピード

//　<ボスのパラメーター>
//　-属性
//　-HP
//　-攻撃力
//　-攻撃スピード

//　<噴出し>
//　-属性
//　-攻撃力
//　-速さ
//　

public class PlayerParameter : MonoBehaviour
{

    const string RESOURCE_PATH = "/Pandemic/Resource/JSON/";

    [SerializeField]
    string JSON_PATH = "";

    int _hp = 0;
    float _jump_power = 0.0f;

    public int getHp { get { return _hp; } }
    public float getJumpPower { get { return _jump_power; } }

    void Awake()
    {
        var text = File.ReadAllText(Application.dataPath + RESOURCE_PATH + JSON_PATH);

        JsonNode json = JsonNode.Parse(text);

        var hp = json["HP"].Get<long>();
        _hp = (int)hp;

        var jump_power = json["JumpPower"].Get<double>();
        _jump_power = (float)jump_power;


    }
}
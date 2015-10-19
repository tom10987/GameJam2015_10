using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Collections;

//　<敵(子分)のパラメーター>
//　-属性
//　-HP
//　-攻撃力
//　-攻撃スピード
//　-名前
//　-ID

public class EnemyParameter : MonoBehaviour
{
    const string RESOURCE_PATH = "/Pandemic/Resource/JSON/";

    [SerializeField]
    string JSON_PATH = "";

    public enum Attribute
    {
        ANIME,
        IDOL,
        GAME,
        VOCALOID,
        ROBOT,
        ERROR,
    };

    struct EnemyData
    {
        public string _name;
        public float _attacK_power;
        public float _attack_speed;
        public int _id;
        public int _hp;
        public Attribute _attribute;
    };

    Dictionary<int, EnemyData> _enemy_table = new Dictionary<int, EnemyData>();
    Dictionary<int, string> _enemy_name_table = new Dictionary<int, string>();

    public string GetName(int id)
    {
        if (!_enemy_name_table.ContainsKey(id)) return "error";
        return _enemy_name_table[id];
    }

    public float GetAttackPower(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return 0.0f;
        return _enemy_table[hash_code]._attacK_power;
    }

    public float GetAttackPower(int id)
    {
        return GetAttackPower(GetName(id));
    }

    public float GetAttackSpeed(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return 0.0f;
        return _enemy_table[hash_code]._attack_speed;
    }

    public float GetAttackSpeed(int id)
    {
        return GetAttackSpeed(GetName(id));
    }

    public int GetId(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return -1;
        return _enemy_table[hash_code]._id;
    }

    public int GetHP(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return 0;
        return _enemy_table[hash_code]._hp;
    }

    public int GetHP(int id)
    {
        return GetHP(GetName(id));
    }

    public Attribute GetAttribute(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return Attribute.ERROR;
        return _enemy_table[hash_code]._attribute;
    }

    public Attribute GetAttribute(int id)
    {
        return GetAttribute(GetName(id));
    }

    public bool IsAnime(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return false;
        if (_enemy_table[hash_code]._attribute != Attribute.ANIME) return false;
        return true;
    }

    public bool IsAnime(int id)
    {
        return IsAnime(GetName(id));
    }

    public bool IsIdol(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return false;
        if (_enemy_table[hash_code]._attribute != Attribute.IDOL) return false;
        return true;
    }

    public bool IsIdol(int id)
    {
        return IsIdol(GetName(id));
    }

    public bool IsGame(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return false;
        if (_enemy_table[hash_code]._attribute != Attribute.GAME) return false;
        return true;
    }

    public bool IsGame(int id)
    {
        return IsGame(GetName(id));
    }

    public bool IsVocaloid(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return false;
        if (_enemy_table[hash_code]._attribute != Attribute.VOCALOID) return false;
        return true;
    }

    public bool IsVocaloid(int id)
    {
        return IsVocaloid(GetName(id));
    }

    public bool IsRobot(string name)
    {
        var hash_code = name.GetHashCode();
        if (!_enemy_table.ContainsKey(hash_code)) return false;
        if (_enemy_table[hash_code]._attribute != Attribute.ROBOT) return false;
        return true;
    }

    public bool IsRobot(int id)
    {
        return IsRobot(GetName(id));
    }

    void Awake()
    {
        var text = File.ReadAllText(Application.dataPath + RESOURCE_PATH + JSON_PATH);

        JsonNode json = JsonNode.Parse(text);
        var enemies = json["Enemies"];

        Dictionary<int, Attribute> enemy_attribute_table = new Dictionary<int, Attribute>();
        enemy_attribute_table.Add(0, Attribute.ANIME);
        enemy_attribute_table.Add(1, Attribute.IDOL);
        enemy_attribute_table.Add(2, Attribute.GAME);
        enemy_attribute_table.Add(3, Attribute.VOCALOID);
        enemy_attribute_table.Add(4, Attribute.ROBOT);



        for (var i = 0; i < enemies.Count; ++i)
        {
            EnemyData enemy_data = new EnemyData();
            var enemy = enemies[i];
            enemy_data._name = enemy["Name"].Get<string>();
            enemy_data._id = (int)enemy["ID"].Get<long>();
            enemy_data._hp = (int)enemy["HP"].Get<long>();
            enemy_data._attacK_power = (float)enemy["AttackPower"].Get<double>();
            enemy_data._attack_speed = (float)enemy["AttackSpeed"].Get<double>();

            var enemy_attribute_num = (int)enemy["Attribute"].Get<long>();
            enemy_data._attribute = enemy_attribute_table[enemy_attribute_num];

            _enemy_table.Add(enemy_data._name.GetHashCode(), enemy_data);
            _enemy_name_table.Add(enemy_data._id, enemy_data._name);
        }
    }
}

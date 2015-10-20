using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class StageSequencer : MonoBehaviour
{

    public enum Type
    {
        STAGE01,
        STAGE02,
        STAGE03,
    };

    BackGroundSetting _back_ground_setting = null;
    StageNameSetting _stage_name_setting = null;

    [SerializeField]
    Type _current_type = Type.STAGE01;
    

    void Start()
    {
        _back_ground_setting = FindObjectOfType<BackGroundSetting>();
        _stage_name_setting = FindObjectOfType<StageNameSetting>();
    }

    public Type GetCurrentStageType()
    {
        return _current_type;
    }

    public void Transition(Type type)
    {
        Transition((uint)type);
    }

    public void Transition(uint id)
    {
        _back_ground_setting.StageChange(id);
        _stage_name_setting.StageChange(id);
    }


}

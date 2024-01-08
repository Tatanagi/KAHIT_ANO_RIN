using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(GameManager)), CanEditMultipleObjects]  
public class Game_Manager_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GameManager GameManager= (GameManager)target;
        if (GUILayout.Button("FeedingFrenzy"))
        {
            GameManager.DamagePowerUP_FeedingFrenzy();
        }
        if (GUILayout.Button("WellFed"))
        {
            GameManager.DamagePowerUP_WellFed();
        }
        if (GUILayout.Button("Reset Button"))
        {
            GameManager.ResetValues();
        }
    }
}

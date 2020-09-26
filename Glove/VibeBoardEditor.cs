using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;


[CustomEditor(typeof(VibeBoard))]
public class VibeBoardEditor : Editor
{       
    public override void OnInspectorGUI()
        {
        base.OnInspectorGUI();
        
        VibeBoard objetivo = (VibeBoard)target;
        int[] opt = OpenGloveScript.regions.Select(s => Convert.ToInt32(s)).ToList().ToArray();
        string[] options = Array.ConvertAll(opt, ele => ele.ToString());
       
        objetivo.selected = EditorGUILayout.Popup("Select VibeBoard", objetivo.selected, options);
        objetivo.region = opt[objetivo.selected];


        

    }
}

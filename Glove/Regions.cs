using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(OpenGloveScript))]

public class Regions : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        OpenGloveScript objetivo = (OpenGloveScript)target;
        
         
         string[] options = new string[]
         {
             "Glove 1", "Glove 2", "Glove 3", 
         };
        objetivo.selected= EditorGUILayout.Popup("Select Glove", objetivo.selected, options); 




    }
}

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
             "Guante 1", "Guante 2", "Guante 3", 
         };
        objetivo.selected= EditorGUILayout.Popup("Select Glove", objetivo.selected, options); 
        if (GUILayout.Button("Add Region"))
        {
            objetivo.AgregarRegion(objetivo.region);
            Debug.Log("Region Agregada");
           
        }



    }
}

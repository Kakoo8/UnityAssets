using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Flexor))]
public class FlexorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();



        Flexor objetivo = (Flexor)target;

        if (GUILayout.Button("Set Threshold"))
                {
                    objetivo.setThreshold(objetivo.threshold);
                    Debug.Log("Threshold Setted");
           
                }
        if (GUILayout.Button("Calibrate Flexors"))
        {
            Debug.Log("Open and close your hand many times");
            objetivo.calibrateFlexors();

        }

        int[] opt = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] options = Array.ConvertAll(opt, ele => ele.ToString());

        objetivo.selected = EditorGUILayout.Popup("Select Flexor", objetivo.selected, options);
        objetivo.flexor = opt[objetivo.selected];

    }
    // Start is called before the first frame update
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;


[CustomEditor(typeof(VibeBoard))]
public class VibeBoardEditor : Editor
{
    string[] regions ={"FingerSmallDistal",
        "FingerRingDistal",
        "FingerMiddleDistal",
        "FingerIndexDistal",

        "FingerSmallMiddle",
        "FingerRingMiddle",
        "FingerMiddleMiddle",
        "FingerIndexMiddle",

        "FingerSmallProximal",
        "FingerRingProximal",
        "FingerMiddleProximal",
        "FingerIndexProximal",

        "PalmSmallDistal",
        "PalmRingDistal",
        "PalmMiddleDistal",
        "PalmIndexDistal",

        "PalmSmallProximal",
        "PalmRingProximal",
        "PalmMiddleProximal",
        "PalmIndexProximal",

        "HypoThenarSmall",
        "HypoThenarRing",
        "ThenarMiddle",
        "ThenarIndex",

        "FingerThumbProximal",
        "FingerThumbDistal",

        "HypoThenarDistal",
        "Thenar",

        "HypoThenarProximal" };
    public override void OnInspectorGUI()
        {
        base.OnInspectorGUI();
        
        VibeBoard objetivo = (VibeBoard)target;
        int[] opt = OpenGloveScript.regions.Select(s => Convert.ToInt32(s)).ToList().ToArray();
        string[] options = Array.ConvertAll(opt, ele => regions[ele]);
       
        objetivo.selected = EditorGUILayout.Popup("Select VibeBoard", objetivo.selected, options);
        objetivo.region = opt[objetivo.selected];


        

    }
}

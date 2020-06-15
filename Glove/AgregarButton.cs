using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(ExampleClass))]
public class AgregarButton : Editor
{       
    public override void OnInspectorGUI()
        {
        base.OnInspectorGUI();
        ExampleClass objetivo = (ExampleClass)target;
        
       if (GUILayout.Button("Agregar"))
        {
            objetivo.AgregarRegion(objetivo.region);
            Debug.Log("Region Agregada");

        }



    }
}

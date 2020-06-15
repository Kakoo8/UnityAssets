using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(OpenGloveScript))]

public class Regiones : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        OpenGloveScript objetivo = (OpenGloveScript)target;

        if (GUILayout.Button("Agregar"))
        {
            objetivo.AgregarRegion(objetivo.region);
            Debug.Log("Region Agregada");
            Debug.Log(objetivo.regions);
        }



    }
}

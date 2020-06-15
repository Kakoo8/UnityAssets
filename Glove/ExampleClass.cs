using System.Collections;
using System.Collections.Generic;
using OpenGlove_API_C_Sharp_HL;
using OpenGlove_API_C_Sharp_HL.ServiceReference1;
using System;
using UnityEngine;


public class ExampleClass : MonoBehaviour
{
    


    [Header("Regiones a activar") ]
    public List<int> regions = new List<int>() ;

    [Header("Intensidad en las regiones")]
    public List<int> intensity = new List<int>() { 255, 255, 255, 255, 255 };

    List<int> intensityOff = new List<int>() { 0, 0, 0, 0, 0 };
    public OpenGloveScript UGlove;
    [Header("Agregar Region")]

    public int region;

    public void Awake()
    {
        this.regions = UGlove.regions;
    }


    public void OnMouseDown()
    {

    

        

        Debug.Log(UGlove.glove);
        UGlove.api.Activate(UGlove.glove, regions, intensity);
        Debug.Log("ssss");
        GetComponent<Rigidbody>().useGravity = false;
        //this.transform.position = UGlove.theDest.position;
        this.transform.parent = UGlove.transform;


    }

    public void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        UGlove.api.Activate(UGlove.glove, regions, intensityOff);
    }

    public void AgregarRegion(int region)
    {
        regions.Add(region);
    }
}
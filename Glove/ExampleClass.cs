using System.Collections;
using System.Collections.Generic;
using OpenGlove_API_C_Sharp_HL;
using OpenGlove_API_C_Sharp_HL.ServiceReference1;
using System;
using UnityEngine;
using System.Linq;
[Serializable]
public class ExampleClass : MonoBehaviour
{
    


    [Header("Regiones a activar") ]
    public List<int> regions = new List<int>() ;

    [Header("Intensidad en las regiones")]
    public List<int> intensity = new List<int>() ;

    List<int> intensityOff = new List<int>() ;
    public OpenGloveScript UGlove;
    [Header("Agregar Region")]

    public int region;

    public void Start()
    {
        
        this.regions = OpenGloveScript.regions.Select(s => Convert.ToInt32(s)).ToList();
        intensity.Clear();
        intensityOff.Clear();
        foreach (int region in regions)
        {
            intensity.Add(0);
            intensityOff.Add(0);
        }
    }


    public void OnMouseDown()
    {

    

        

        Debug.Log(UGlove.glove);
        UGlove.api.Activate(UGlove.glove, regions, intensity);
        Debug.Log("Bzzz");
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
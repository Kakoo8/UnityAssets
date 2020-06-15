using OpenGlove_API_C_Sharp_HL;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32;

using System;

using System.Linq;
using System.Windows;


using OpenGlove_API_C_Sharp_HL.ServiceReference1;
using System.ServiceModel;

using UnityEngine;


public class Giroscopio : MonoBehaviour
{
    public OpenGloveScript UGlove;
    [Header("Regiones a activar")]
    public float accx;
    public float accy;
    public float accz;
    public float gyx;
    public float gyy;
    public float gyz;
    public float magx;
    public float magy;
    public float magz;


    // Start is called before the first frame update
    void Start()
    {
        try
        {

            UGlove.api.startIMU(UGlove.glove);
            UGlove.api.startCaptureData(UGlove.glove);
        }
        catch
        {
            Debug.Log("No funciona tu wea");

        }

        Debug.Log("ETCELENTE");
    }

    // Update is called once per frame
    void Update()
    {
        UGlove.api.getDataReceiver(UGlove.glove).imu_ValuesFunction += allIMUValues;
        this.transform.position=  new Vector3(magx,magy,magz);

    }

    public void allIMUValues(float ax, float ay, float az, float gx, float gy, float gz, float mx, float my, float mz)
    {


        accx = ax;
        accy = ay;
        accz = az;
        gyx = gx;
        gyy = gy;
        gyz = gz;
        magx = mx;
        magy = my;
        magz = mz;
     
    }

    }

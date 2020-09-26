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


public class Gyroscope : MonoBehaviour
{
    public OpenGloveScript UGlove;
    [Header("Testing")]
    public Vector3[] vectors;

    [Header("Acelerometro")]
    public Vector3 acc;

    
    [Header("Giroscopio")]
    public Vector3 gyr;
   
    [Header("Magnetometro")]
    public Vector3 mag;
    

    private Vector3 angle = Vector3.zero;
    private float sinAngle = 0.0f;
    private float cosAngle = 0.0f;
    private  Quaternion qX = Quaternion.identity;
    private  Quaternion qY = Quaternion.identity;
    private  Quaternion qZ = Quaternion.identity;

    private  Quaternion r = Quaternion.identity;

    private float Speed = 4f;
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
            Debug.Log("Not Working");

        }

        Debug.Log("Capturing Data");
    }

    // Update is called once per frame
    void Update()
    {
        UGlove.api.getDataReceiver(UGlove.glove).imu_ValuesFunction += allIMUValues;
        if (Math.Abs(acc.x)>0.09 && Math.Abs(acc.y) > 0.09&& Math.Abs(acc.z) > 0.09)
        {
            //this.transform.position += new Vector3(accx, 0, 0);
        }
        transform.rotation = Quaternion.Euler(acc.x*10, acc.y*10, acc.z*10);
    }
    public Quaternion gyroC()
    {
        UGlove.api.getDataReceiver(UGlove.glove).imu_ValuesFunction += allIMUValues;
        this.angle = new Vector3(-90 + gyr.x, 120 + gyr.y, gyr.z);

        sinAngle = Mathf.Sin(Mathf.Deg2Rad * angle.z * 0.5f);
        cosAngle = Mathf.Cos(Mathf.Deg2Rad * angle.z * 0.5f);
        qZ.Set(0, 0, sinAngle, cosAngle);


        sinAngle = Mathf.Sin(Mathf.Deg2Rad * angle.x * 0.5f);
        cosAngle = Mathf.Cos(Mathf.Deg2Rad * angle.x * 0.5f);
        qX.Set(sinAngle, 0, 0, cosAngle);

        sinAngle = Mathf.Sin(Mathf.Deg2Rad * angle.y * 0.5f);
        cosAngle = Mathf.Cos(Mathf.Deg2Rad * angle.y * 0.5f);
        qY.Set(0, sinAngle, 0, cosAngle);

        r = qY * qX * qZ;
        return r;
    }

    public void allIMUValues(float ax, float ay, float az, float gx, float gy, float gz, float mx, float my, float mz)
    {

        acc = new Vector3(ax, ay, az);
        gyr = new Vector3(gx, gy, gz);
        mag = new Vector3(mx, my, mz);

     
    }

    }

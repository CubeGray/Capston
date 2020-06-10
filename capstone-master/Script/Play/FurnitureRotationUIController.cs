﻿using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class FurnitureRotationUIController : MonoBehaviour
{
    CameraController m_camera;
    bool m_isDrag = false;
    public void PD()
    {
        m_isDrag = true;
        m_camera.enabled = false;
        Debug.Log(m_isDrag);
    }

    public void PU()
    {
        m_isDrag = false;
        m_camera.enabled = true;
        Debug.Log(m_isDrag);
    }

    void Start()
    {
        m_camera = Camera.main.GetComponent<CameraController>();
        m_isDrag = false;
    }

    public void Init()
    {
        m_isDrag = false;
        m_camera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
  
        if (m_isDrag)
        {
            BoxCollider box = gameObject.transform.parent.GetComponent<BoxCollider>();
            Vector3 pivot = gameObject.transform.parent.transform.TransformPoint(box.center);

            if (Input.GetAxis("Mouse X") > 0)
            {
                gameObject.transform.parent.RotateAround(pivot, Vector3.up, 4);
                
            }
            else if (Input.GetAxis("Mouse X") < 0)
            {
                gameObject.transform.parent.RotateAround(pivot, Vector3.up, -4);
            }
        }

    }

}
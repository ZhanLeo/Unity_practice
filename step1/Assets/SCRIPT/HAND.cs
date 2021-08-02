using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HAND : MonoBehaviour
{
    public SteamVR_Action_Boolean Forward = null;
    private Transform transRig = null;

    private Transform cameraTrans = null;
    private Vector3 cameraForward;
    private Transform dirTrans;

    private SteamVR_Behaviour_Pose m_Pose = null;
    private FixedJoint m_Joint = null;
    private GameObject m_object = null;
    private bool smoothMode = true;

    private void Awake()
    {
        m_Pose = GetComponent<SteamVR_Behaviour_Pose>();
        m_Joint = GetComponent<FixedJoint>();
        transRig = transform.parent;
        cameraTrans = transRig.Find("Camera");
        dirTrans = transRig.Find("Dir Group");
    }
    void Update()
    {
        cameraForward = (new Vector3(cameraTrans.forward.x, 0f, cameraTrans.forward.z)).normalized;
        if (smoothMode)
        {
            SmoothMove();
        }
        
    }
    private void SmoothMove()
    {
        if (Forward.GetState(m_Pose.inputSource))
        {
            transRig.position = transRig.position + cameraForward * 0.06f;
        }
    }
}

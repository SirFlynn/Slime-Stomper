﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]

public class TriggerDisplay : MonoBehaviour
{
    public Color triggerColour;

    //This does some magic and draws a box that is only visible in the editor view. Great for debugging
    void OnDrawGizmos()
    {
        GetComponent<BoxCollider>().isTrigger = true;
        Vector3 drawBoxVector = new Vector3
            (
            this.transform.lossyScale.x * this.GetComponent<BoxCollider>().size.x,
            this.transform.lossyScale.y * this.GetComponent<BoxCollider>().size.y,
            this.transform.lossyScale.z * this.GetComponent<BoxCollider>().size.z
            );
        Vector3 drawBoxPosition = this.transform.position + this.GetComponent<BoxCollider>().center;

        Gizmos.matrix = Matrix4x4.TRS(drawBoxPosition, this.transform.rotation, drawBoxVector);
        Gizmos.color = triggerColour;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
    }
}

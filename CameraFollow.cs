using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }
    float elapsed = 0f;
    private bool orbitY;

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.transform.position + offset;
            if (orbitY)
            {
                transform.RotateAround(target.transform.position, Vector3.up, elapsed += Time.deltaTime * 15f);
            }
            transform.LookAt(target.transform);
        }
    }
}

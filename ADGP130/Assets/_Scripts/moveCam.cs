using UnityEngine;
using System.Collections;

public class moveCam : MonoBehaviour
{
    public Transform target;
    public float distance = 2.3f;
    public float height = 4.54f;
    public float damping = 1;
    public bool smoothRotating = true;
    public bool followBehind = true;
    public float rotatingDamping = 10.0f;

    void Update()
    {
        Vector3 wantedPosition;

        if (followBehind)
        {
            wantedPosition = target.TransformPoint(0, height, -distance);
        }
        else
        {
            wantedPosition = target.TransformPoint(0, height, distance);
        }

        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);

        if (smoothRotating)
        {
            Quaternion wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.deltaTime * rotatingDamping);
        }
        else transform.LookAt(target, target.up);
    }
}
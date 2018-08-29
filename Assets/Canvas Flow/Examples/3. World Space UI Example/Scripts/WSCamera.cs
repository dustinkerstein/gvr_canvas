using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSCamera : MonoBehaviour
{
    public Transform target;
    public new Camera camera;
    public Vector2 angleSpread;

    private Quaternion defaultRotation;

    private void Awake()
    {
        defaultRotation = target.rotation;
    }

    void Update ()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 mousePosition01 = new Vector3(mousePosition.x / Screen.width,
                                              mousePosition.y / Screen.height);
        
        float xAngle = Mathf.Lerp(-angleSpread.x, angleSpread.x, mousePosition01.x);
        float yAngle = Mathf.Lerp(angleSpread.y, -angleSpread.y, mousePosition01.y);

        Quaternion xRotation = Quaternion.AngleAxis(xAngle, Vector3.up);
        Quaternion yRotation = Quaternion.AngleAxis(yAngle, Vector3.right);
        target.rotation = defaultRotation * xRotation * yRotation;
	}
}

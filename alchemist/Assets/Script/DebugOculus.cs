using UnityEngine;
using System.Collections;

public class DebugOculus : MonoBehaviour
{

#if UNITY_EDITOR
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }

    public bool keyDebug = true;
    public bool cameraDebug = true;
    public bool mouseDebug = true;
    public RotationAxes axes = RotationAxes.MouseXAndY;

    public Vector2 senstiviyMouse = new Vector2(5f, 5f);
    public Vector2 minMouse = new Vector2(-360f, -360f);
    public Vector2 maxMouse = new Vector2(360f, 360f);


    Quaternion originalRotation;

    float rotationX = 0F;
    float rotationY = 0F;

    void Update()
    {
        if (mouseDebug)
        {

            if (axes == RotationAxes.MouseXAndY)
            {
                // Read the mouse input axis
                rotationX += Input.GetAxis("Mouse X") * senstiviyMouse.x;
                rotationY += Input.GetAxis("Mouse Y") * senstiviyMouse.y;

                rotationX = ClampAngle(rotationX, minMouse.x, maxMouse.x);
                rotationY = ClampAngle(rotationY, minMouse.y, maxMouse.y);

                Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
                Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, Vector3.left);

                transform.localRotation = originalRotation * xQuaternion * yQuaternion;
            }
            else if (axes == RotationAxes.MouseX)
            {
                rotationX += Input.GetAxis("Mouse X") * senstiviyMouse.x;
                rotationX = ClampAngle(rotationX, minMouse.x, maxMouse.x);

                Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
                transform.localRotation = originalRotation * xQuaternion;
            }
            else
            {
                rotationY += Input.GetAxis("Mouse Y") * senstiviyMouse.y;
                rotationY = ClampAngle(rotationY, minMouse.y, maxMouse.y);

                Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, Vector3.left);
                transform.localRotation = originalRotation * yQuaternion;
            }
        }
    }

    void Start()
    {
        if (mouseDebug)
        {
            // Make the rigid body not change rotation
            if (GetComponent<Rigidbody>())
                GetComponent<Rigidbody>().freezeRotation = true;
            originalRotation = Quaternion.identity;// transform.localRotation;
        }

        //if (cameraDebug)
        //{
        //    Camera leftCam = CameraManager.instance.GetOculusCamera(OculusEyeType.LEFT);
        //    if( leftCam != null) {
        //        leftCam.rect = new Rect(0f, 0f, 0.5f, 1f);
        //    }

        //    Camera rightCam = CameraManager.instance.GetOculusCamera(OculusEyeType.RIGHT);
        //    if (rightCam != null)  {
        //        rightCam.rect = new Rect(0.5f, 0f, 0.5f, 1f);
        //    }
        //}

    }


    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }

#endif
}

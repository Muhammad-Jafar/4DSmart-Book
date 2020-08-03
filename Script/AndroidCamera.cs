using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// UnityからAndroidのCamera LEDを制御する例
// startPreview() でカメラのプレビューを開始した状態で LEDOn() で光る
// SUMBER : https://gist.github.com/GOROman/d403d39b34d7f99934fd

public class AndroidCamera : MonoBehaviour
{
    AndroidJavaObject camera = null;

    public AndroidCamera()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        Debug.Log("Camera Name:" + devices[0].name);

        open();
    }

    public void open()
    {
        if (camera == null)
        {
#if (UNITY_ANDROID && !UNITY_EDITOR)
			AndroidJavaClass cameraClass = new AndroidJavaClass("android.hardware.Camera");
			camera = cameraClass.CallStatic<AndroidJavaObject>("open");
#endif
        }
    }

    public void release()
    {
        if (camera != null)
        {
            LEDOff();

            camera.Call("release");
            camera = null;
        }
    }

    public void startPreview()
    {
        if (camera != null)
        {
            Debug.Log("AndroidCamera::startPreview()");
            camera.Call("startPreview");
        }
    }

    public void stopPreview()
    {
        if (camera != null)
        {
            Debug.Log("AndroidCamera::stopPreview()");
            LEDOff();
            camera.Call("stopPreview");
        }
    }

    // FLASHLIGHT INITIALIZING
    private void setFlashMode(string mode)
    {
        if (camera != null)
        {
            AndroidJavaObject cameraParameters = camera.Call<AndroidJavaObject>("getParameters");
            cameraParameters.Call("setFlashMode", mode);
            camera.Call("setParameters", cameraParameters);
        }
    }

    // FLASHLIGHT MODE ON
    public void LEDOn()
    {
        setFlashMode("torch");
    }

    // FLASHLIGHT MODE OFF
    public void LEDOff()
    {
        setFlashMode("off");
    }

}

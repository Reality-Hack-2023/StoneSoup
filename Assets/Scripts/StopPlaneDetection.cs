using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.OpenXR;
using UnityEngine.XR.ARSubsystems;

public class StopPlaneDetection : MonoBehaviour
{
    [SerializeField]
    private  ARPlaneManager planeManager;
    [SerializeField]
    private Button stopPlaneDetection;

    private void Start()
    {
        stopPlaneDetection.onClick.AddListener(OnButtonClicked);
    }

    public void OnButtonClicked()
    {
        planeManager.requestedDetectionMode = PlaneDetectionMode.None;
    }
}

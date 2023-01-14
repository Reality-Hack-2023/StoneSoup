using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

internal sealed class PlaceMapOnPlane : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject housingMapsPrefb;
    private GameObject housingMap;
    // Start is called before the first frame update
    void Start()
    {
        housingMap = GameObject.Instantiate(housingMapsPrefb);
        housingMap.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var hitPosition = eventData.pointerCurrentRaycast.worldPosition;
        housingMap.transform.position = hitPosition;
        //ToDo:placing map facing the camera direction
        housingMap.transform.LookAt(Camera.main.transform);
        var rot = housingMap.transform.rotation.eulerAngles;
        rot.x = 0;
        rot.z = 0;
        housingMap.transform.eulerAngles = rot;

        housingMap.SetActive(true);
    }
}

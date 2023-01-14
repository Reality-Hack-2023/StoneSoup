using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

internal sealed class PlaceMapOnPlane : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    private GameObject housingMapsPrefb;
    [SerializeField]
    private InputActionReference  placeAction;

    // Start is called before the first frame update
    void Start()
    {
        placeAction.action.performed += OnPlaceAction;
        housingMapsPrefb.SetActive(false);
    }

    private void OnPlaceAction(InputAction.CallbackContext ctx)
    {
        // This would cast rays only against colliders in layer 8.
        //var layerMask = LayerMask.NameToLayer("PlaneLayer");

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("PlaneLayer"))
            {
                PlaceMape(hit.point);
                hit.transform.gameObject.SetActive(false);
                Debug.Log("spatial plane");
            }
            else if (hit.transform.gameObject.layer == LayerMask.NameToLayer("TinyHomeLayer"))
            {
                var housingOption = hit.transform.gameObject;
                var HousingController = housingOption.GetComponent<TinyHomeController>();
                HousingController.OnClickedAction();
                Debug.Log("Housing Option");
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
    private void PlaceMape(Vector3 hitPosition)
    {
        housingMapsPrefb.transform.position = hitPosition;
        housingMapsPrefb.transform.LookAt(Camera.main.transform);
        var rot = housingMapsPrefb.transform.rotation.eulerAngles;
        rot.x = 0;
        rot.z = 0;
        housingMapsPrefb.transform.eulerAngles = rot;
        housingMapsPrefb.SetActive(true);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }
}

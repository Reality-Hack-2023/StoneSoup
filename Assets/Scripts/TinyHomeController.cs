using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TinyHomeController : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    private GameObject housingOption;
    [SerializeField]
    private GameObject masterPlan;

    // Start is called before the first frame update
    void Start()
    {
        housingOption.SetActive(false);
    }

    public void OnClickedAction()
    {
        housingOption.SetActive(true);
        masterPlan.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }
}

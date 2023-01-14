using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GobackToMap : MonoBehaviour
{
    [SerializeField]
    private Button goBackToMap;
    [SerializeField]
    private GameObject goBackToMapUI;
    [SerializeField]
    private GameObject housingMap;
    [SerializeField]
    private List<GameObject> largeHouses;

    // Start is called before the first frame update
    void Start()
    {
        goBackToMap.onClick.AddListener(OnGoBackToMap);
    }

    private void OnGoBackToMap()
    {
        for (int i = 0; i < largeHouses.Count; i++)
        {
            largeHouses[i].SetActive(false);
        }
        housingMap.SetActive(true);
        goBackToMapUI.SetActive(false);
    }
}

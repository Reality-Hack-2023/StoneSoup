using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBackToMapCanvas : MonoBehaviour
{
    [SerializeField]
    private GameObject backToMapCanvas;

    // Start is called before the first frame update
    private void Start()
    {
        backToMapCanvas.SetActive(false);
    }

    public void OnScaleUpAnimationTrigger()
    {
        backToMapCanvas.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderStatTracker : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private Stat value;
    [SerializeField] private Stat maxValue;
    private Data targetData;
    private Slider healthSlider;

    private void Start()
    {
        healthSlider = GetComponent<Slider>();
        targetData = target.GetComponent<Data>();
    }

    private void Update()
    {
        healthSlider.value = targetData.stats[value] / targetData.stats[maxValue];
    }
}

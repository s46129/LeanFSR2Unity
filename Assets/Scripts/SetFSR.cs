using System;
using FidelityFX;
using TMPro;
using UnityEngine;

public class SetFSR : MonoBehaviour
{
    [SerializeField] Fsr2ImageEffect fsr2ImageEffect;
    [SerializeField] TMP_Dropdown dropdown;

    private void Start()
    {
        dropdown.options.Clear();
        foreach (var quality in Enum.GetValues(typeof(Fsr2.QualityMode)))
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(quality.ToString()));
        }

        dropdown.value = (int)fsr2ImageEffect.qualityMode;
        dropdown.onValueChanged.AddListener(delegate { ChangeQuality(); });
    }

    public void ChangeQuality()
    {
        fsr2ImageEffect.qualityMode = (Fsr2.QualityMode)dropdown.value;
    }
}
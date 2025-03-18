using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VersionTxt : MonoBehaviour
{
    void Start()
    {
        var textmesh = GetComponent<TextMeshProUGUI>();
        textmesh.text = Application.version;
    }
}

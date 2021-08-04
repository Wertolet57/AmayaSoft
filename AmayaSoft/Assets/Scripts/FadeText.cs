using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeText : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().DOFade(1f, 3f);
    }
}

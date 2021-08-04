using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EndPanel : MonoBehaviour
{
    [SerializeField] private Button _restarButton;
    public void PanelOn()
    {
        transform.GetChild(0).GetComponent<Image>().DOFade(0.8f, 3f);
        _restarButton.gameObject.SetActive(true);
    }
}

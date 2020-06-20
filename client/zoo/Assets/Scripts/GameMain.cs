using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameMain : MonoBehaviour
{
    public Transform transformCamera;

    void Start()
    {
        DOTween.Sequence().Append(transformCamera.DOMoveX(88f, 3f))
            .Append(transformCamera.DOMoveX(0f, 5f))
            .SetLoops(-1);
    }
}

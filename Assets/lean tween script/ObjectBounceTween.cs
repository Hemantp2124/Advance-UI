using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBounceTween : MonoBehaviour
{
    public LeanTweenType easeType;
    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.moveY(gameObject, 13.5f, 0.3f).setLoopPingPong().setEase(easeType);
    }

}

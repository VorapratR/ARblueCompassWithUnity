using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionArrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arrow;
    // Start is called before the first frame update
    public void Enable() {
        arrow.SetActive(true);
    }

    public void Disable() {
        arrow.SetActive(false);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {
    void OnTriggerExit(Collider other)
    {
        DestroyObject(other.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnapsackItem :UIDragDropItem {

    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);
        if (surface.tag == "Grid")
        {
            this.transform.parent = surface.transform;
        }
          this.transform.localPosition = Vector3.zero;
    }
}

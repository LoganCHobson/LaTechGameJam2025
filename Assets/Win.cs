using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class Win : MonoBehaviour
{
   public  LayerMask layer;
    private void Update()
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, new Vector2(2, 2), 0, Vector2.down, 2, layer);

        if (hit.collider != null && hit.collider.gameObject.CompareTag("Player"))
        {
            Game.Instance.Win();
        }
    }
}

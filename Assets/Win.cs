
using UnityEngine;


public class Win : MonoBehaviour
{
   public  LayerMask layer;
    private void Update()
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, new Vector2(10, 10), 0, Vector2.down, 2, layer);

        if (hit.collider != null && hit.collider.gameObject.CompareTag("Player"))
        {
            Game.Instance.render.ChangeRenderFeature(modes.None);
            Game.Instance.Win();
            
        }
    }
}

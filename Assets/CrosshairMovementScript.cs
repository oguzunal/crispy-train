using UnityEngine;
using System.Collections;

public class CrosshairMovementScript : MonoBehaviour {

    public Rect crosshairRectBounds;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        mousePos.x = Mathf.Clamp(mousePos.x, crosshairRectBounds.x, crosshairRectBounds.width);
        mousePos.y = Mathf.Clamp(mousePos.y, crosshairRectBounds.y, crosshairRectBounds.height);

        transform.position = mousePos;
	}

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(new Vector3(crosshairRectBounds.x, crosshairRectBounds.y, 0), new Vector3(crosshairRectBounds.x, crosshairRectBounds.height, 0));
        Gizmos.DrawLine(new Vector3(crosshairRectBounds.x, crosshairRectBounds.y, 0), new Vector3(crosshairRectBounds.width, crosshairRectBounds.y, 0));
        Gizmos.DrawLine(new Vector3(crosshairRectBounds.x, crosshairRectBounds.height, 0), new Vector3(crosshairRectBounds.width, crosshairRectBounds.height, 0));
        Gizmos.DrawLine(new Vector3(crosshairRectBounds.width, crosshairRectBounds.y, 0), new Vector3(crosshairRectBounds.width, crosshairRectBounds.height, 0));

    }
}

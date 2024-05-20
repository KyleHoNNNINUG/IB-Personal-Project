using UnityEngine;

public class Grabber : MonoBehaviour
{
    public GameObject grabbedCard, grabbedCardDeck;

    public Vector3 ObjectPosition(float x_offset = 0, float y_offset = 0, float z_offset = 0)
    {
        Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(transform.position).z);
        Vector3 worldposition = Camera.main.ScreenToWorldPoint(position);
        return new Vector3(worldposition.x + x_offset, y_offset, worldposition.z + z_offset);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(grabbedCard == null)
            {
                RaycastHit hit = CastRay();

                if(hit.collider != null)
                {
                    if (hit.collider.CompareTag("drag"))
                    {
                        grabbedCard = hit.collider.gameObject;
                        grabbedCard.GetComponent<Grabbed>().dropped = false;
                    }
                    else if (hit.collider.transform.parent != null && hit.collider.transform.parent.CompareTag("Card Deck"))
                    {
                        grabbedCardDeck = hit.collider.transform.parent.gameObject;
                    }
                    else return;
                }
            }
            else
            {
                grabbedCard.GetComponent<Grabbed>().dropped = true;
            }
        }
    }

    public RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.farClipPlane);
        Vector3 screenMousePosNear = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.nearClipPlane);
        Vector3 worldMousePosFar = Camera.main.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = Camera.main.ScreenToWorldPoint(screenMousePosNear);
        RaycastHit hit;
        Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);

        return hit;
    }
}

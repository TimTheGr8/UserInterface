using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private Image _imageDrop;

    private Vector3 _snapPosition;
    private Image _image;


    private void Start()
    {
        _image = GetComponent<Image>();
        if (_image == null)
            Debug.LogError("This Draggable object does not have an Image.");
        _snapPosition = _image.rectTransform.localPosition;
    }

    public void ResetPosition()
    {
        _image.rectTransform.localPosition = _snapPosition;
    }

    public void SetPosition(Vector3 newPosition)
    {
        _snapPosition = newPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        ResetPosition();
        _image.raycastTarget = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _image.raycastTarget = false;
    }
}

using UnityEngine;

public class RescaleSize : MonoBehaviour
{
    private float scale = 1.0f;

    private bool isScaling = false;
    private float initialDistance;
    public OVRHand leftHand;
    public OVRHand rightHand;

    void Update()
    {
        bool leftPinch = leftHand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        bool rightPinch = rightHand.GetFingerIsPinching(OVRHand.HandFinger.Index);

        if (leftPinch && rightPinch)
        {
            if (!isScaling)
            {
                isScaling = true;
                initialDistance = Vector3.Distance(leftHand.transform.position, rightHand.transform.position);
            }
            else
            {
                float currentDistance = Vector3.Distance(leftHand.transform.position, rightHand.transform.position);
                float scaleChange = currentDistance / initialDistance;
                scale *= scaleChange;
                transform.localScale = new Vector3(scale, scale, scale);
                initialDistance = currentDistance;
            }
        }
        else
        {
            isScaling = false;
        }
    }
}

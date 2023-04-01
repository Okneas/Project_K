using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour
{
    public float Tension;
    private bool _pressed;
 
    public Transform RopeTransform;
   
    public Vector3 RopeNearlocalPosition;
    public Vector3 RopeFarlocalPosition;
    
   
    public float ReturnTime;
    public int ArrowCount = 4;
   

    public AnimationCurve RopeReturnAnimation;
    public Arrow CurrentArrow;
    private int ArrowIndex = 0;
    public float ArrowSpeed;
    public Arrow[] ArrowsPool;
    // Start is called before the first frame update
    void Start()
    {
        RopeNearlocalPosition = RopeTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ArrowCount > 0)
            {

                _pressed = true;
                ArrowIndex++;
                if (ArrowIndex >= ArrowsPool.Length)
                {
                    ArrowIndex = 0;
                }
                CurrentArrow = ArrowsPool[ArrowIndex];
                CurrentArrow.SetToRope(RopeTransform);
            }
            else
            {
                
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            _pressed = false;
            Tension = 0;
            StartCoroutine(RopeReturn());
            CurrentArrow.Shot(ArrowSpeed);
            ArrowCount--;
                }
        if (_pressed)
        {
            if (Tension < 1f)
            {
                Tension += Time.deltaTime;
            }
            RopeTransform.localPosition = Vector3.Lerp(RopeNearlocalPosition, RopeFarlocalPosition , Tension);
        }
    }

    IEnumerator RopeReturn()
    {
        Vector3 startLocalposition = RopeTransform.localPosition;
        for(float f = 0; f < 1f; f += Time.deltaTime /ReturnTime)
        {
            RopeTransform.localPosition = Vector3.Lerp(startLocalposition, RopeNearlocalPosition,RopeReturnAnimation.Evaluate( f));
            yield return null;
        }
        RopeTransform.localPosition = RopeNearlocalPosition;
    }
}

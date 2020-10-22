using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain : MonoBehaviour
{
    public GameObject mountain;
    public int numConesMin = 2;
    public int numConesMax = 4;
    public Vector3 coneOffsetScale = new Vector3(2, 1, 2);
    public Vector2 coneScaleRangeX = new Vector2(4,8);
    public Vector2 coneScaleRangeY = new Vector2(2,4);
    public Vector2 coneScaleRangeZ = new Vector2(3,4);
    public float scaleYMin = 2f;

    private List<GameObject> cones;

    // Start is called before the first frame update
    void Start()
    {
        cones = new List<GameObject>();

        int num = Random.Range(numConesMin, numConesMax);
        for(int i = 0; i<num; i++)
        {
            GameObject cn = Instantiate<GameObject>(mountain);
            cones.Add(cn);
            Transform cnTrans = cn.transform;
            cnTrans.SetParent(this.transform);

            Vector3 offset = Random.insideUnitSphere;
            offset.x *= coneOffsetScale.x;
            offset.y *= coneOffsetScale.y;
            offset.z *= coneOffsetScale.z;

            Vector3 scale = Vector3.one;
            scale.x = Random.Range(coneScaleRangeX.x, coneScaleRangeX.y);
            scale.y = Random.Range(coneScaleRangeY.x, coneScaleRangeY.y);
            scale.z = Random.Range(coneScaleRangeZ.x, coneScaleRangeZ.y);

            //scale.z *= 1 - (Mathf.Abs(offset.x) / coneOffsetScale.x);
            //scale.z = Mathf.Max(scale.z, scaleYMin);

            cnTrans.localScale = scale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Restart();
        }
    }

    void Restart()
    {
        foreach(GameObject cn in cones)
        {
            Destroy(cn);
        }

        Start();
    }
}

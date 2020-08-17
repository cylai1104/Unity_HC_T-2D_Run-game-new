using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    // 插值:取得兩點之間的中間值
    // A:0
    // B:10
    // 取得A與B之間50%值
    // 插值 (A, B, 0.5f) = 50% 
    public float A = 0;
    public float B = 100;

    private void Start()
    {
        float result = Mathf.Lerp(A, B, 0.5f);
        print(result);
    }

    public float C = 0;
    public float D = 100;

    private void Update()
    {
        C = Mathf.Lerp(C, D, 0.7F * Time.deltaTime);
        
    }

}


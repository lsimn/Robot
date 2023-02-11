using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFunction
{
    // interface 는 일반적인 변수를 선언할 수 없다.
    public void Damage();
}
public class NewBehaviourScript : MonoBehaviour, IFunction
{
    float degree;
    public int data = 5;

    public void Damage()
    {
        Debug.Log("Damage 가 호출되었습니다.");
    }

    void Start()
    {
        Damage();
        Debug.Log("data 변수의 값 : " + data);
    }

    void Update()
    {
        degree += Time.deltaTime;
        if(degree >= 360)
            degree= 0;

        RenderSettings.skybox.SetFloat("_Rotation", degree);
    }
}

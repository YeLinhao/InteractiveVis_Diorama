using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoomerSpawner : MonoBehaviour
{
    public GameObject BoomerPrefab;
    public float spawnHeight = 5f;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        // 从摄像机发射一条射线到鼠标点击的位置
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // 检测射线是否击中当前物体（plane）
        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == this.gameObject)
        {
            // 获取被点击的世界坐标
            Vector3 clickPosition = hit.point;

            // 计算生成位置：点击的x, z坐标，y坐标在上方5单位处
            Vector3 spawnPosition = new Vector3(clickPosition.x, clickPosition.y + spawnHeight, clickPosition.z);

            // 生成bomb预制件
            Instantiate(BoomerPrefab, spawnPosition, Quaternion.identity);
        }

    
    }



}

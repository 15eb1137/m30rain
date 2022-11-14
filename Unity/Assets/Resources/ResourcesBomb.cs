using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesBomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject objBomb = (GameObject)Resources.Load("musicbox.bomb");

        //pink
        Instantiate(objBomb, new Vector3(-3.02f, 6.00f, 109.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 6.00f, 163.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 6.00f, 174.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 6.00f, 183.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 6.00f, 209.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 6.00f, 263.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 6.00f, 274.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 6.00f, 283.0f), Quaternion.identity);

        //green
        Instantiate(objBomb, new Vector3(-0.99f, 6.00f, 305.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 6.00f, 312.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 6.00f, 331.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 6.00f, 339.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 6.00f, 347.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 6.00f, 369.0f), Quaternion.identity);

        //blue
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 124.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 144.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 154.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 176.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 184.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 224.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 244.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 254.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 6.00f, 276.5f), Quaternion.identity);

        //orange
        Instantiate(objBomb, new Vector3(3.05f, 6.00f, 117.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 6.00f, 122.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 6.00f, 126.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 6.00f, 141.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 6.00f, 150.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 6.00f, 163.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 6.00f, 189.0f), Quaternion.identity);
    }
}

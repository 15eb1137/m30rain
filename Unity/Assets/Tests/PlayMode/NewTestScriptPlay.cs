using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

// テスト用クラス
public class HogeComponentTest
{
    [UnityTest]
    public IEnumerator CountTest()
    {
        var go = new GameObject("Hoge");
        var hoge = go.AddComponent<HogeComponent>();

        // Start()前
        Assert.AreEqual(0, hoge.count);

        yield return null;

        // Start()後
        Assert.AreEqual(1, hoge.count);
    }
}
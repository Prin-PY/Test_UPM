using UnityEditor;
using UnityEngine;
namespace PrinKindom.Test_UPM
{
    public class Test_Debug
    {
        [MenuItem("Tests/Test_UPM")]
        private static void TestUPM_Menu()
        {
            DebugTest();
        }

        private static void DebugTest()
        {
            Debug.Log("Test UPM");
        }

        public static void Test()
        {
            DebugTest();
        }
    }

}

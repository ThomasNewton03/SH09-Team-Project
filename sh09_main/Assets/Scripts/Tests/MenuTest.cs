using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class MenuSuite : InputTestFixture
    {

        Mouse mouse;
        public override void Setup()
        {
            base.Setup();
            SceneManager.LoadScene("Scenes/scene1");
            mouse = InputSystem.AddDevice<Mouse>();

        }

        public void ClickUI(GameObject uiElement, GameObject canvas)
        {
            Camera camera = GameObject.Find("XR Origin/Camera Offset/Main Camera").GetComponent<Camera>();
            var position = camera.WorldToScreenPoint(uiElement.transform.position);
            position.z = (canvas.transform.position - camera.transform.position).magnitude;
            Vector3 theLocationOfUIObjectInWorldSpace = Camera.main.ScreenToWorldPoint(position);
            Vector2 uiPos = uiElement.GetComponent<RectTransform>().anchoredPosition;
            Vector3 screenPos = camera.WorldToScreenPoint(uiElement.GetComponent<RectTransform>().anchoredPosition);
            Debug.Log(uiElement.GetComponent<RectTransform>().anchoredPosition);
            Debug.Log(theLocationOfUIObjectInWorldSpace);
            Set(mouse.position, theLocationOfUIObjectInWorldSpace);
            Click(mouse.leftButton);
        }

        [UnityTest]
        public IEnumerator TestGameStart()
        {
            GameObject canvas = GameObject.Find("Canvas");
            GameObject rightMenuButton = GameObject.Find("Canvas/Lone Button Right");
            Debug.Log("1");
            ClickUI(rightMenuButton, canvas);
            yield return new WaitForSeconds(3f);
            ClickUI(rightMenuButton, canvas);
            yield return new WaitForSeconds(3f);
        }
    }
}

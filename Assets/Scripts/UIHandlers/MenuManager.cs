using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StereoApp
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField]
        private RectTransform menuButton;
        [SerializeField]
        private RectTransform toolbarMenu;

        public void OnMenuButtonPressed()
        {
            if(!toolbarMenu.gameObject.activeSelf)
            {
                menuButton.anchoredPosition = new Vector2(menuButton.anchoredPosition.x, menuButton.anchoredPosition.y + toolbarMenu.rect.height);
                toolbarMenu.gameObject.SetActive(true);
            }
            else
            {
                menuButton.anchoredPosition = new Vector2(menuButton.anchoredPosition.x, menuButton.anchoredPosition.y - toolbarMenu.rect.height);
                toolbarMenu.gameObject.SetActive(false);
            }
        }
    }
}
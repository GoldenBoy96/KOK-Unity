using KOK.Assets._Scripts.ApiHandler.DTOModels.Response;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KOK
{
    public class ItemBinding : MonoBehaviour
    {
        public Item Item { get; private set; }
        [SerializeField] Image itemImage;
        [SerializeField] TMP_Text itemNameText;
        [SerializeField] TMP_Text itemPriceText;
        [SerializeField] GameObject blurForeground;
        [SerializeField] Sprite defaultImage;
        private ShopItemManager shopItemManager;

        public void Init(Item item, ShopItemManager shopItemManager)
        {
            this.Item = item;
            this.name = item.ItemName;
            //Debug.Log(item.ItemName + " | " + item.ItemCode + " | " + item.ItemType + " | " + ApiHandler.DTOModels.ItemType.CHARACTER + " | " + item.IsOwned);
            if (item.ItemType == ApiHandler.DTOModels.ItemType.CHARACTER)
            {
                itemImage.sprite = Resources.Load<Sprite>(item.ItemCode + "AVA");
            }
            Debug.Log(item.ItemCode + " | " + itemImage.sprite);


            string tmpName = item.ItemName;
            if (tmpName.Count() > 7) { itemNameText.text = tmpName.Substring(0, 7) + "..."; }
            else { itemNameText.text = tmpName; }

            itemPriceText.text = (int)item.ItemBuyPrice + "";

            if ((bool)item.IsOwned)
            {
                blurForeground.SetActive(true);
                itemPriceText.color = Color.gray;


            }
            else if (itemImage.sprite == null || itemImage.sprite.ToString().Trim().ToLower().Equals("null"))
            {
                itemImage.sprite = defaultImage;
                blurForeground.SetActive(true);
                itemPriceText.color = Color.gray;
            }
            else
            {
                blurForeground.SetActive(false);
            }
            this.shopItemManager = shopItemManager;

        }

        public void ShowDetailPanel()
        {
            shopItemManager.ItemDetailBinding.gameObject.SetActive(true);
            shopItemManager.ItemDetailBinding.Init(Item, shopItemManager);
        }
        private void OnDestroy()
        {
            StopAllCoroutines();
        }
    }
}

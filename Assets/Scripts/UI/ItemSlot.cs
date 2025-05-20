using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{

    public ItemData item;

    public Button button;
    public Image icon;
    public TextMeshProUGUI quantityText; // 수량표시 Text
    private Outline outline; // 선택시 Outline 표시위한 컴포넌트

    public UIInventory inventory;


    public int index; // 몇 번째 Slot인지 index 할당
    public bool equipped; // 장착여부
    public int quantity; // 수량데이터

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void OnEnable()
    {
        outline.enabled = equipped;
    }

    public void Set()
    {
        icon.gameObject.SetActive(true);
        icon.sprite = item.icon;
        quantityText.text = quantity > 1 ? quantity.ToString() : string.Empty;

        if(outline != null )
        {
            outline.enabled = equipped;
        }

    }

    // UI(슬롯 한 칸)에 정보가 없을 때 UI를 비워주는 함수
    public void Clear()
    {
        item = null;
        icon.gameObject.SetActive(false);
        quantityText.text = string.Empty;
    }

    // 슬롯을 클릭했을 때 발생하는 함수.
    public void OnClickButton()
    {
        // 인벤토리의 SelectItem 호출, 현재 슬롯의 인덱스만 전달.
        inventory.SelectItem(index);
    }
}

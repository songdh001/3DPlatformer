using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{

    public ItemData item;

    public Button button;
    public Image icon;
    public TextMeshProUGUI quantityText; // ����ǥ�� Text
    private Outline outline; // ���ý� Outline ǥ������ ������Ʈ

    public UIInventory inventory;


    public int index; // �� ��° Slot���� index �Ҵ�
    public bool equipped; // ��������
    public int quantity; // ����������

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

    // UI(���� �� ĭ)�� ������ ���� �� UI�� ����ִ� �Լ�
    public void Clear()
    {
        item = null;
        icon.gameObject.SetActive(false);
        quantityText.text = string.Empty;
    }

    // ������ Ŭ������ �� �߻��ϴ� �Լ�.
    public void OnClickButton()
    {
        // �κ��丮�� SelectItem ȣ��, ���� ������ �ε����� ����.
        inventory.SelectItem(index);
    }
}

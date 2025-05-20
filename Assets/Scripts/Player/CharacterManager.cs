using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instance;
    public static CharacterManager Instance
    {
        get
        {
            //Ȥ�ö� _instace�� ������� ��� �����ؼ� �־���
            if (_instance == null)
            {
                _instance = new GameObject("CharacterManager").AddComponent<CharacterManager>();
            }
            return _instance;
        }
    }

    public Player _player;

    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }

    private void Awake()
    {
        if (_instance != null)
        {
            _instance = this; //�� �ڽ��� ����ִ´�.
            DontDestroyOnLoad(gameObject);
        }
        else//���� �ν�ź���� �̹� �ִٸ�
        {
            if(_instance == this)//�׸��� �ν�ź���� ���� �Ͱ� ���ٸ�
            {
                Destroy(gameObject);//�ı�
            }
        }
    }
}

using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instance;
    public static CharacterManager Instance
    {
        get
        {
            //혹시라도 _instace가 비어있을 경우 생성해서 넣어줌
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
            _instance = this; //나 자신을 집어넣는다.
            DontDestroyOnLoad(gameObject);
        }
        else//만약 인스탄스가 이미 있다면
        {
            if(_instance == this)//그리고 인스탄스가 지금 것과 같다면
            {
                Destroy(gameObject);//파괴
            }
        }
    }
}

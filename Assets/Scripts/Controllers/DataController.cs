using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class DataController : MonoBehaviour
{
    // ---�̱������� ����--- 
    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }
    static DataController _instance;
    public static DataController Instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "DataController";
                _instance = _container.AddComponent(typeof(DataController)) as DataController;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    // --- ���� ������ �����̸� ���� ---
    public string GameDataFileName = "StarfishData.json";

    // "���ϴ� �̸�(����).json"
    public GameData _gameData;
    public GameData gameData
    {
        get
        {
            // ������ ���۵Ǹ� �ڵ����� ����ǵ���
            if (_gameData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _gameData;
        }
    }

    private void Start()
    {
        LoadGameData();
        SaveGameData();
    }

    // ����� ���� �ҷ�����
    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;

        // ����� ������ �ִٸ�
        if (File.Exists(filePath))
        {
            print("�ҷ����� ����");
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }

        // ����� ������ ���ٸ�
        else
        {
            print("���ο� ���� ����");
            _gameData = new GameData();
        }
    }

    // ���� �����ϱ�
    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(gameData);
        string filePath = Application.persistentDataPath + GameDataFileName;

        // �̹� ����� ������ �ִٸ� �����
        File.WriteAllText(filePath, ToJsonData);

        // �ùٸ��� ����ƴ��� Ȯ�� (�����Ӱ� ����)
        print("����Ϸ�");
    }

    // ������ �����ϸ� �ڵ�����ǵ���
    private void OnApplicationQuit()
    {
        //DataController.Instance.gameData.currentStage = EnemyController.currentEnemy;
        DataController.Instance.gameData.currentStage = 1;
        // �ǹ����� ������ ���� ���� �ֱ�
        DataController.Instance.gameData.Damage = 1;
        DataController.Instance.gameData.Gold = 0;
        //DataController.Instance.gameData.shield = PlayerData.shield;
        DataController.Instance.gameData.recovery = 1;
        DataController.Instance.gameData.critical = 0;
        DataController.Instance.gameData.Diamond = 0;
        /*DataController.Instance.gameData.currentStage = EnemyController.currentEnemy;
        DataController.Instance.gameData.Damage = 10.0f;
        DataController.Instance.gameData.Gold = 0;*/
        SaveGameData();
    }
}
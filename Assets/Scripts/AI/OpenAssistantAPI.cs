using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;

public class ChatGPTClient : MonoBehaviour
{
    private string apiKey = "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"; // ������� ��� API ���� ���
    private string apiUrl = "https://api.openai.com/v1/completions";

    void Start()
    {
        StartCoroutine(SendMessageToChatGPT("�����, ChatGPT! �� ������?"));
    }

    IEnumerator SendMessageToChatGPT(string message)
    {
        // ϳ�������� ����� ��� ������
        var jsonData = "{\"model\": \"gpt-3.5-turbo\", \"messages\": [{\"role\": \"user\", \"content\": \"" + message + "\"}]}";

        // ��������� ������
        UnityWebRequest request = new UnityWebRequest(apiUrl, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonData);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("Authorization", "Bearer " + apiKey);

        // ³������� ������
        yield return request.SendWebRequest();

        // �������� �� �������
        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error: " + request.error);
        }
        else
        {
            string response = request.downloadHandler.text;
            Debug.Log("ChatGPT response: " + response);
        }
    }
}

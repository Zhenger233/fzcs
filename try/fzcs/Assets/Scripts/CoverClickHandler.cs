// CoverClickHandler.cs
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class CoverClickHandler : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private GameObject coverImage;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(PlayVideo);
    }

    private void PlayVideo()
    {
        coverImage.SetActive(false); // ���ط���
        videoPlayer.Play();

        // ��Ƶ������ɺ�ص�
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        // ������ת����һ������
        Debug.Log("��Ƶ���Ž���");
        SceneManager.LoadScene("Scene0");
    }
}
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
        coverImage.SetActive(false); // 隐藏封面
        videoPlayer.Play();

        // 视频播放完成后回调
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        // 例如跳转到下一个场景
        Debug.Log("视频播放结束");
        SceneManager.LoadScene("Scene0");
    }
}